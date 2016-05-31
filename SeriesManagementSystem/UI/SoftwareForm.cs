using SeriesManagementSystem.Domain;
using SeriesManagementSystem.Foundation;
using System;
using System.IO;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI
{
    public partial class SoftwareForm : Form
    {
        private Software _software;
        private SeriesManager _seriesManager;

        public SoftwareForm(Software software)
        {
            InitializeComponent();
            _software = software;
            _seriesManager = _software.SeriesManager;
            seriesListBindingSource.DataSource = _seriesManager.SeriesList;
        }

        private void OnAddSeries(object sender, EventArgs e)
        {
            using (var addForm = new SeriesForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _software.AddSeries(addForm.ReturnName, addForm.ReturnDesc);
                    seriesListBindingSource.ResetBindings(true);
                }
            }
        }

        private void OnCellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = _seriesGridView.Columns[e.ColumnIndex];
            var row = _seriesGridView.Rows[e.RowIndex];
            if (column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int sid = Int32.Parse(row.Cells[4].Value.ToString());
                string name = row.Cells[2].Value.ToString();
                string desc = row.Cells[3].Value.ToString();
                if (column.Name == "Remove")
                    DeleteSeries(sid);
                else if (column.Name == "Modify")
                    ModifySeries(name, desc, sid);
                seriesListBindingSource.ResetBindings(true);
            }
        }

        private void DeleteSeries(int sid)
        {
            var result = MessageBox.Show("是否刪除影集？", "刪除影集", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                _software.RemoveSeries(sid);
        }

        private void ModifySeries(string name, string desc, int sid)
        {
            _software.SelectSeries(sid);
            using (var modifyForm = new SeriesForm(name, desc))
            {
                if (modifyForm.ShowDialog() == DialogResult.OK)
                {
                    _software.ModifySeries(modifyForm.ReturnName, modifyForm.ReturnDesc);
                    seriesListBindingSource.ResetBindings(true);
                }
            }
        }

        private void OnImportSeries(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _software.ImportFile(openFileDialog.FileName);
                    if (_software.IsImportFail)
                        MessageBox.Show("檔案格式錯誤？", "匯入失敗");
                    seriesListBindingSource.ResetBindings(true);
                }
            }
        }

        private void OnShown(object sender, EventArgs e)
        {
            if (_software.IsLoadFail)
            {
                MessageBox.Show("檔案損毀，檔案已刪除", "檔案讀取失敗");
            }
            ReportFromServer();
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            _refreshResultLabel.Text = "連線取得最新資訊中";
            this.Enabled = false;
            _software.RefreshServerData();
            this.Enabled = true;
            seriesListBindingSource.ResetBindings(true);
            ReportFromServer();
        }

        private void ReportFromServer()
        {
            if (_software.IsNoInternet)
            {
                _refreshResultLabel.Text = "";
                MessageBox.Show("目前裝置尚未連接網路", "連線失敗");
            }
            else if (!_seriesManager.IsExistNewOne)
                _refreshResultLabel.Text = "沒有發現新的影音資訊";
            else
                _refreshResultLabel.Text = "已取得最新影集資訊";
        }
    }
}
