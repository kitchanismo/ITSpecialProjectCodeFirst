﻿using System;
using System.ComponentModel;
using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Commons.Helpers;
using System.Drawing;
using System.Windows.Forms;
using ITSpecialProject.Components.Classes;
using ITSpecialProject.Components.Interfaces;

namespace ITSpecialProject.Components
{
    public class FlatPanel : Panel, IGradientOnDefault, IEllipseOnDefault
    {
        #region Initialization

        private ColorCombination _colorToneOnDefault;
        private Color _colorAOnDefault;
        private Color _colorBOnDefault;
        private Color _colorCOnDefault;
        private int _gradientAngleOnDefault;
        private int _ellipse;

        public FlatPanel()
        {
            this.Margin = new Padding(0, 0, 0, 0);

            InitCustomProperties();
        }

        private void InitCustomProperties()
        {
            ColorToneOnDefault = ColorCombination.SoloColor;

            ColorAOnDefault = ColorHelper.NoColor;
            ColorBOnDefault = ColorHelper.FlatWhiteLight;
            ColorCOnDefault = ColorHelper.FlatWhiteLight;

            GradientAngleOnDefault = 45;

            EllipseOnDefault = 0;
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
            => TransitionHelper.GradientPaint(new Gradient<FlatPanel>(this, ColorAOnDefault, ColorBOnDefault, ColorCOnDefault, ColorToneOnDefault, GradientAngleOnDefault));

        #endregion

        #region Ellipse Properties

        [Category("Custom")]
        public int EllipseOnDefault
        {
            get => _ellipse;
            set
            {
                _ellipse = value;

                SetEllipseOnDefault();
            }
        }

        public void SetEllipseOnDefault()
            => TransitionHelper.SetEllipse(this, _ellipse);

        #endregion
    }
}
