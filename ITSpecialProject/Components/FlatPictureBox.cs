using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components.Interfaces;

namespace ITSpecialProject.Components
{
    public class FlatPictureBox : PictureBox, IBackColorOnDefault, IBackColorOnHover, IBackColorOnClick, IEllipseOnDefault, IEllipseOnHover, IEllipseOnClick
    {
        #region Initialization

        private Color _backColorOnDefault;
        private int _ellipseOnDefault;

        private ToolTip _toolTip;

        public FlatPictureBox()
        {
            InitDefaultProperties();

            InitCustomProperties();
        }

        private void InitDefaultProperties()
        {
            this.Size = new Size(100, 100);
            this.Image = Properties.Resources.Picture_100;
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void InitCustomProperties()
        {
            BackColorOnDefault = ColorHelper.FlatBlueNormal;
            BackColorOnHover = ColorHelper.FlatBlueNormal;
            BackColorOnClick = ColorHelper.FlatBlueNormal;

            SetEllipseOnDefault();

            _toolTip = new ToolTip();
            ToolTip = string.Empty;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            SetBackColorOnHover();
            SetEllipseOnHover();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            SetBackColorOnDefault();
            SetEllipseOnDefault();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            SetBackColorOnClick();
            SetEllipseOnClick();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            SetBackColorOnHover();
            SetEllipseOnHover();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SetEllipseOnDefault();
        }

        #endregion

        #region Properties

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
        public Color BackColorOnHover { get; set; }

        public void SetBackColorOnHover() => this.BackColor = BackColorOnHover;

        [Category("Custom")]
        public Color BackColorOnClick { get; set; }

        public void SetBackColorOnClick() => this.BackColor = BackColorOnClick;

        #endregion

        #region Ellipse Properties

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

        public void SetEllipseOnDefault() => TransitionHelper.SetEllipse(this, EllipseOnDefault);

        [Category("Custom")]
        public int EllipseOnHover { get; set; }

        public void SetEllipseOnHover() => TransitionHelper.SetEllipse(this, EllipseOnHover);

        [Category("Custom")]
        public int EllipseOnClick { get; set; }

        public void SetEllipseOnClick() => TransitionHelper.SetEllipse(this, EllipseOnClick);

        #endregion
    }
}
