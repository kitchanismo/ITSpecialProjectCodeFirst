using System;
using System.ComponentModel;

namespace ITSpecialProject.Views.Utilities
{
    public partial class PaginatorView
    {
        private int _currentPage = 1;
        private int _maxPage = 1;

        private void Initialize()
        {
            cbRecords.SelectedIndex = 0;
        }

        private void GoToFirstPage()
        {
            SetCurrentPage(_currentPage = 1);
        }

        private void GoToNextPage()
        {
            if (_currentPage == _maxPage) return;

            SetCurrentPage(++_currentPage);
        }

        private void GoToPreviousPage()
        {
            if (_currentPage == 1) return;

            SetCurrentPage(--_currentPage);
        }

        private void GoToLastPage()
        {
            SetCurrentPage(_currentPage = _maxPage);
        }

        public void ResetPage()
        {
            _currentPage = 1;
            lblCurrentPage.Text = _currentPage.ToString();
        }

        private void SetCurrentPage(int currentPage) => lblCurrentPage.Text = currentPage.ToString();

        public void SetMaxPage(int recordCount)
        {
            _maxPage = ((recordCount / GetRecordsPerPage));

            if (recordCount % GetRecordsPerPage != 0 || _maxPage == 0) _maxPage++;

            lblLastPage.Text = _maxPage.ToString();
        }

        public int GetCurrentPage => _currentPage;

        public int GetRecordsPerPage => int.TryParse(cbRecords.Text, out var count) ? count : 0;

        public int SetRecordsPerPage(int index) => cbRecords.SelectedIndex = index;

        public int GetSkipPage => (GetCurrentPage - 1) * GetRecordsPerPage;


        [Category("Custom")]
        public bool HasRecordCount
        {
            get => pnlPaginatorL.Visible;
            set => pnlPaginatorL.Visible = value;
        }

        [Category("Custom")]
        public bool HasRefresh
        {
            get => pnlPaginatorR.Visible;
            set => pnlPaginatorR.Visible = value;
        }

        public event EventHandler RecordCountChanged
        {
            add => cbRecords.SelectedIndexChanged += value;
            remove => cbRecords.SelectedIndexChanged += value;
        }

        public event EventHandler PageNavigationButtonClicked
        {
            add
            {
                btnFirstPage.Click += value;
                btnPreviousPage.Click += value;
                btnNextPage.Click += value;
                btnLastPage.Click += value;
            }
            remove
            {
                btnFirstPage.Click -= value;
                btnPreviousPage.Click -= value;
                btnNextPage.Click -= value;
                btnLastPage.Click -= value;
            }
        }

        public event EventHandler RefreshButtonClicked
        {
            add => btnRefresh.Click += value;
            remove => btnRefresh.Click -= value;
        }
    }
}
