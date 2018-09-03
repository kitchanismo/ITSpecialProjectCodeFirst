using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ITSpecialProject.Components
{
    public class FlatTextBox : TextBox, IColorOnEnter, IColorOnLeave, IFontOnEnter, IFontOnLeave
    {
        #region Initialization

        private Color _backColorOnLeave;
        private Color _foreColorOnLeave;
        private Font _fontOnLeave;
        private string _placeHolder;

        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);


        private const int WM_NCPAINT = 0x85;
        private const int EM_SETCUEBANNER = 0x1501;


        public FlatTextBox()
        {
            InitDefaultProperties();

            InitCustomProperties();
        }

        private void InitDefaultProperties()
        {
            this.Width = 200;
            this.Padding = new Padding(5, 0, 5, 0);
            this.Margin = new Padding(0, 0, 0, 0);
        }

        private void InitCustomProperties()
        {
            BorderColor = ColorHelper.FlatGreenDark;

            BackColorOnEnter = ColorHelper.FlatWhiteLight;
            ForeColorOnEnter = ColorHelper.FlatBlackNormal;
            FontOnEnter = FontHelper.BoldFont;

            BackColorOnLeave = ColorHelper.FlatWhiteLight;
            ForeColorOnLeave = ColorHelper.FlatBlackNormal;
            FontOnLeave = FontHelper.RegularFont;

            InputValidation = Validation.None;

            SendMessage(this.Handle, EM_SETCUEBANNER, 0, PlaceHolder);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCPAINT && this.Focused)
            {
                var dc = GetWindowDC(Handle);
                using (var g = Graphics.FromHdc(dc))
                {
                    g.DrawRectangle(new Pen(BorderColor), 0, 0, Width - 1, Height - 1);
                }
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            SetPropertiesOnEnter();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            SetPropertiesOnLeave();
        }

        private void SetPropertiesOnEnter()
        {
            SetBackColorOnEnter();
            SetForeColorOnEnter();
            SetFontOnEnter();
        }

        private void SetPropertiesOnLeave()
        {
            SetBackColorOnLeave();
            SetForeColorOnLeave();
            SetFontOnLeave();
        }

        #endregion

        #region Properties

        [Category("Custom")]
        public string PlaceHolder
        {
            get => _placeHolder;
            set
            {
                _placeHolder = value;

                SendMessage(this.Handle, EM_SETCUEBANNER, 0, value);
            }
        }

        #endregion

        #region Color Properties

        [Category("Custom")]
        public Color BorderColor { get; set; }

        [Category("Custom")]
        public Color BackColorOnEnter { get; set; }

        public void SetBackColorOnEnter() => this.BackColor = BackColorOnEnter;

        [Category("Custom")]
        public Color ForeColorOnEnter { get; set; }

        public void SetForeColorOnEnter() => this.ForeColor = ForeColorOnEnter;

        [Category("Custom")]
        public Color BackColorOnLeave
        {
            get => _backColorOnLeave;
            set
            {
                _backColorOnLeave = value;

                SetBackColorOnLeave();
            }
        }

        public void SetBackColorOnLeave() => this.BackColor = BackColorOnLeave;

        [Category("Custom")]
        public Color ForeColorOnLeave
        {
            get => _foreColorOnLeave;
            set
            {
                _foreColorOnLeave = value;

                SetForeColorOnLeave();
            }
        }

        public void SetForeColorOnLeave() => this.ForeColor = ForeColorOnLeave;

        #endregion

        #region Font Properties

        [Category("Custom")]
        public Font FontOnEnter { get; set; }

        public void SetFontOnEnter() => this.Font = FontOnEnter;

        [Category("Custom")]
        public Font FontOnLeave
        {
            get => _fontOnLeave;
            set
            {
                _fontOnLeave = value;

                SetFontOnLeave();
            }
        }

        public void SetFontOnLeave() => this.Font = FontOnLeave;

        #endregion

        #region Validation Properties

        public enum Validation : byte
        {
            None = 0,
            AlphaNumeric = 1,
            Alphabet = 2,
            Numeric = 3,
            AlphaNumericNoSpace = 4,
            AlphabetNoSpace = 5,
            NumericNoSpace = 6,
            Decimal = 7,
            Email = 8
        }

        [Category("Custom")]
        public Validation InputValidation { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            switch (InputValidation)
            {
                case Validation.None:
                    e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar) || !IsInjectionCharacter(e.KeyChar));
                    break;
                case Validation.AlphaNumeric:
                    e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar));
                    break;
                case Validation.Alphabet:
                    e.Handled = !(char.IsLetter(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar));
                    break;
                case Validation.Numeric:
                    e.Handled = !(char.IsDigit(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar));
                    break;
                case Validation.AlphaNumericNoSpace:
                    e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || IsBack(e.KeyChar));
                    break;
                case Validation.AlphabetNoSpace:
                    e.Handled = !(char.IsLetter(e.KeyChar) || IsBack(e.KeyChar));
                    break;
                case Validation.NumericNoSpace:
                    e.Handled = !(char.IsDigit(e.KeyChar) || IsBack(e.KeyChar));
                    break;
                case Validation.Decimal:
                    e.Handled = IsBack(e.KeyChar)
                        ? e.Handled = false
                        : IsDecimal(e.KeyChar) && this.Text.Contains('.')
                            ? e.Handled = true
                            : e.Handled = !(char.IsDigit(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar) || IsDecimal(e.KeyChar));
                    break;
                case Validation.Email:
                    e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || IsBack(e.KeyChar) || IsEmailCharacter(e.KeyChar));
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }

        private static bool IsBack(char key) => key == (char)Keys.Back;

        private static bool IsSpace(char key) => key == (char)Keys.Space;

        private static bool IsDecimal(char key) => key == '.';

        private static bool IsEmailCharacter(char key) => "._@".Contains(key.ToString());

        private static bool IsInjectionCharacter(char key) => "\\\'\"\t\n%_;{}&".Contains(key.ToString());

        #endregion
    }
}
