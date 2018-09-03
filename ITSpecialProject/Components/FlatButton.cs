using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components.Interfaces;
using DataLayer.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ITSpecialProject.Components
{
    public class FlatButton : Button, IColorOnDefault, IColorOnHover, IColorOnClick, IEllipseOnDefault, IEllipseOnHover, IEllipseOnClick
    {
        #region Initialize

        private Color _backColorOnDefault;
        private Color _backColorOnHover;
        private Color _backColorOnClick;
        private Color _foreColorOnDefault;
        private int _ellipseOnDefault;

        private ToolTip _toolTip;

        public FlatButton()
        {
            InitDefaultProperties();
            InitCustomProperties();
        }

        private void InitDefaultProperties()
        {
            this.Font = FontHelper.BoldFont;
            this.Size = new Size(150, 50);
            this.Margin = new Padding(0, 0, 0, 0);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
        }

        private void InitCustomProperties()
        {
            InitializeBackColor();
            InitializeForeColor();
            InitializeEllipse();

            _toolTip = new ToolTip();
            ToolTip = string.Empty;
        }

        private void InitializeBackColor()
        {
            BackColorOnDefault = ColorHelper.MediumTransparent;
            BackColorOnHover = ColorHelper.LightTransparent;
            BackColorOnClick = ColorHelper.DarkTransparent;
        }

        private void InitializeForeColor()
        {
            ForeColorOnDefault = ColorHelper.FlatBlackDark;
            ForeColorOnHover = ColorHelper.FlatBlackDark;
            ForeColorOnClick = ColorHelper.FlatBlackDark;
        }

        private void InitializeEllipse()
        {
            EllipseOnDefault = 0;
            EllipseOnHover = 0;
            EllipseOnClick = 0;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            SetEllipseOnClick();
            SetForeColorOnClick();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            SetEllipseOnHover();
            SetForeColorOnHover();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            SetEllipseOnDefault();
            SetForeColorOnDefault();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            SetEllipseOnHover();
            SetForeColorOnHover();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SetEllipseOnDefault();
        }

        #endregion

        #region Properties

        private IModule _module;

        public void SetModule(IModule module) => _module = module;

        public IModule GetModule() => _module;

        [Category("Custom")]
        public string ToolTip
        {
            get => _toolTip.GetToolTip(this);
            set => _toolTip.SetToolTip(this, value);
        }

        #endregion

        #region BackColor Properties

        [Category("Custom")]
        public Color BackColorOnDefault
        {
            get => _backColorOnDefault;
            set
            {
                _backColorOnDefault = value;

                SetBackColorOnDefault();
            }
        }

        public void SetBackColorOnDefault() => this.BackColor = BackColorOnDefault;

        [Category("Custom")]
        public Color BackColorOnHover
        {
            get => _backColorOnHover;
            set
            {
                _backColorOnHover = value;

                SetBackColorOnHover();
            }
        }

        public void SetBackColorOnHover() => this.FlatAppearance.MouseOverBackColor = BackColorOnHover;

        [Category("Custom")]
        public Color BackColorOnClick
        {
            get => _backColorOnClick;
            set
            {
                _backColorOnClick = value;

                SetBackColorOnClick();
            }
        }

        public void SetBackColorOnClick() => this.FlatAppearance.MouseDownBackColor = BackColorOnClick;

        #endregion

        #region ForeColor Properties

        [Category("Custom")]
        public Color ForeColorOnDefault
        {
            get => _foreColorOnDefault;
            set
            {
                _foreColorOnDefault = value;

                SetForeColorOnDefault();
            }
        }

        public void SetForeColorOnDefault() => this.ForeColor = ForeColorOnDefault;

        [Category("Custom")]
        public Color ForeColorOnHover { get; set; }

        public void SetForeColorOnHover() => this.ForeColor = ForeColorOnHover;

        [Category("Custom")]
        public Color ForeColorOnClick { get; set; }

        public void SetForeColorOnClick() => this.ForeColor = ForeColorOnClick;

        #endregion

        #region EllipseOnDefault Properties

        [Category("Custom")]
        public int EllipseOnDefault
        {
            get => _ellipseOnDefault;
            set
            {
                _ellipseOnDefault = value;

                SetEllipseOnDefault();
            }
        }

        public void SetEllipseOnDefault()
            => TransitionHelper.SetEllipse(this, EllipseOnDefault);

        #endregion

        #region EllipseOnHover Properties

        [Category("Custom")]
        public int EllipseOnHover { get; set; }

        public void SetEllipseOnHover()
            => TransitionHelper.SetEllipse(this, EllipseOnHover);

        #endregion

        #region EllipseOnClick Properties

        [Category("Custom")]
        public int EllipseOnClick { get; set; }

        public void SetEllipseOnClick()
            => TransitionHelper.SetEllipse(this, EllipseOnClick);

        #endregion

    }
}
