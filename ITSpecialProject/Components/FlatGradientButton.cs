﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components.Classes;
using ITSpecialProject.Components.Interfaces;

namespace ITSpecialProject.Components
{
    public class FlatGradientButton : Button, IForeColorOnDefault, IForeColorOnHover, IForeColorOnClick, IGradient, IEllipseOnDefault, IEllipseOnHover, IEllipseOnClick 
    {
        #region Initialization

        private Color _foreColorOnDefault;
        private Color _colorAOnDefault;
        private Color _colorBOnDefault;
        private Color _colorCOnDefault;
        private int _gradientAngleOnDefault;
        private ColorCombination _colorToneOnDefault;
        private int _ellipseOnDefault;

        private ToolTip _toolTip;

        public FlatGradientButton()
        {
            InitDefaultProperties();
            InitCustomProperties();
        }

        private void InitDefaultProperties()
        {
            this.Font = FontHelper.BoldFont;
            this.Size = new Size(100, 100);
            this.Margin = new Padding(0, 0, 0, 0);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.TextImageRelation = TextImageRelation.ImageAboveText;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.ImageAlign = ContentAlignment.MiddleCenter; 
        }

        private void InitCustomProperties()
        {
            InitializeBgColorOnDefault();
            InitializeBgColorOnHover();
            InitializeBgColorOnClick();
            InitializeEllipse();

            _toolTip = new ToolTip();
            ToolTip = string.Empty;
        }

        private void InitializeBgColorOnDefault()
        {
            ForeColorOnDefault = ColorHelper.FlatBlackDark;
            ForeColorOnHover = ColorHelper.FlatBlackDark;
            ForeColorOnClick = ColorHelper.FlatBlackDark;

            ColorToneOnDefault = ColorCombination.SoloColor;

            ColorAOnDefault = ColorHelper.MediumTransparent;
            ColorBOnDefault = ColorHelper.NoColor;
            ColorCOnDefault = ColorHelper.NoColor;

            GradientAngleOnDefault = 45;
        }

        private void InitializeBgColorOnHover()
        {
            ColorToneOnHover = ColorCombination.SoloColor;

            ColorAOnHover = ColorHelper.LightTransparent;
            ColorBOnHover = ColorHelper.NoColor;
            ColorCOnHover = ColorHelper.NoColor;

            GradientAngleOnHover = 45;
        }

        private void InitializeBgColorOnClick()
        {
            ColorToneOnClick = ColorCombination.SoloColor;

            ColorAOnClick = ColorHelper.DarkTransparent;
            ColorBOnClick = ColorHelper.NoColor;
            ColorCOnClick = ColorHelper.NoColor;

            GradientAngleOnClick = 45;
        }

        private void InitializeEllipse()
        {
            EllipseOnDefault = 0;
            EllipseOnHover = 0;
            EllipseOnClick = 0;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            SetEllipseOnHover();
            SetGradientPaintOnHover();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            SetEllipseOnDefault();
            SetGradientPaintOnDefault();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            SetEllipseOnClick();
            SetGradientPaintOnClick();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            SetEllipseOnHover();
            SetGradientPaintOnHover();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            SetGradientPaintOnDefault();
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

        #region GradientOnDefault Properties

        [Category("Custom")]
        public ColorCombination ColorToneOnDefault
        {
            get => _colorToneOnDefault;
            set
            {
                _colorToneOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        [Category("Custom")]
        public Color ColorAOnDefault
        {
            get => _colorAOnDefault;
            set
            {
                _colorAOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        [Category("Custom")]
        public Color ColorBOnDefault
        {
            get => _colorBOnDefault;
            set
            {
                _colorBOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        [Category("Custom")]
        public Color ColorCOnDefault
        {
            get => _colorCOnDefault;
            set
            {
                _colorCOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        [Category("Custom")]
        public int GradientAngleOnDefault
        {
            get => _gradientAngleOnDefault;
            set
            {
                _gradientAngleOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        public void SetGradientPaintOnDefault()
        {
            var gradient = new Gradient<FlatGradientButton>(this,
                ColorAOnDefault, 
                ColorBOnDefault, 
                ColorCOnDefault, 
                ColorToneOnDefault, 
                GradientAngleOnDefault);

            TransitionHelper.GradientPaint(gradient);
        }

        #endregion

        #region GradientOnHover Properties

        [Category("Custom")]
        public ColorCombination ColorToneOnHover { get; set; }

        [Category("Custom")]
        public Color ColorAOnHover { get; set; }

        [Category("Custom")]
        public Color ColorBOnHover { get; set; }

        [Category("Custom")]
        public Color ColorCOnHover { get; set; }

        [Category("Custom")]
        public int GradientAngleOnHover { get; set; }

        [Category("Custom")]
        public void SetGradientPaintOnHover()
        {
            var gradient = new Gradient<FlatGradientButton>(this,
                ColorAOnHover,
                ColorBOnHover,
                ColorCOnHover,
                ColorToneOnHover,
                GradientAngleOnHover);
                
            TransitionHelper.GradientPaint(gradient);
        }

        #endregion

        #region GradientOnClick Properties

        [Category("Custom")]
        public ColorCombination ColorToneOnClick { get; set; }

        [Category("Custom")]
        public Color ColorAOnClick { get; set; }

        [Category("Custom")]
        public Color ColorBOnClick { get; set; }

        [Category("Custom")]
        public Color ColorCOnClick { get; set; }

        [Category("Custom")]
        public int GradientAngleOnClick { get; set; }

        public void SetGradientPaintOnClick()
        {
            var gradient = new Gradient<FlatGradientButton>(this,
                ColorAOnClick,
                ColorBOnClick,
                ColorCOnClick,
                ColorToneOnClick,
                GradientAngleOnClick);

            TransitionHelper.GradientPaint(gradient);
        }

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
