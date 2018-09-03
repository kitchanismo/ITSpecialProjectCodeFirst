using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components.Interfaces;

namespace ITSpecialProject.Components
{
    public class FlatTable : DataGridView, IEllipseOnDefault
    {
        private int _ellipseOnDefault;

        public FlatTable()
        {
            SetDefaultProperties();

            SetEllipseOnDefault();
        }

        private void SetDefaultProperties()
        {
            this.Font = FontHelper.BoldFont;
            this.BackgroundColor = ColorHelper.FlatWhiteLight;
            this.ForeColor = ColorHelper.FlatBlackNormal;
            this.Height = 250;
            this.Width = 500;
            this.BorderStyle = BorderStyle.None;
            this.Margin = new Padding(0, 0, 0, 0);

            this.EnableHeadersVisualStyles = false;

            //Cells
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.GridColor = ColorHelper.FlatBlueNormal;

            //Columns
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AllowUserToResizeColumns = false;
            this.ColumnHeadersHeight = 25;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            this.ColumnHeadersDefaultCellStyle.BackColor = ColorHelper.FlatBlueNormal;
            this.ColumnHeadersDefaultCellStyle.ForeColor = ColorHelper.White;

            //Rows
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.DefaultCellStyle.Font = FontHelper.RegularFont;
            this.DefaultCellStyle.BackColor = ColorHelper.FlatWhiteDark;
            this.DefaultCellStyle.ForeColor = ColorHelper.FlatBlackNormal;
            this.DefaultCellStyle.SelectionBackColor = ColorHelper.FlatBlueLight;
            this.DefaultCellStyle.SelectionForeColor = ColorHelper.White;
            this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.RowsDefaultCellStyle.Font = FontHelper.RegularFont;
            this.RowsDefaultCellStyle.BackColor = ColorHelper.FlatWhiteDark;
            this.RowsDefaultCellStyle.ForeColor = ColorHelper.FlatBlackNormal;
            this.RowsDefaultCellStyle.SelectionBackColor = ColorHelper.FlatBlueLight;
            this.RowsDefaultCellStyle.SelectionForeColor = ColorHelper.White;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.AlternatingRowsDefaultCellStyle.Font = FontHelper.RegularFont;
            this.AlternatingRowsDefaultCellStyle.BackColor = ColorHelper.FlatWhiteNormal;
            this.AlternatingRowsDefaultCellStyle.ForeColor = ColorHelper.FlatBlackNormal;
            this.RowTemplate.Resizable = DataGridViewTriState.True;
            this.RowTemplate.MinimumHeight = 25;
            this.RowTemplate.Height = 25;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
            this.ReadOnly = true;

            //Row Header
            this.RowHeadersWidth = 10;
            this.RowHeadersVisible = true;
            this.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RowHeadersDefaultCellStyle.Font = FontHelper.RegularFont;
            this.RowHeadersDefaultCellStyle.BackColor = ColorHelper.FlatBlackNormal;
            this.RowHeadersDefaultCellStyle.ForeColor = ColorHelper.White;
            this.RowHeadersDefaultCellStyle.SelectionBackColor = ColorHelper.FlatYellowNormal;
            this.RowHeadersDefaultCellStyle.SelectionForeColor = ColorHelper.White;
            this.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SetEllipseOnDefault();
        }

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
    }
}
