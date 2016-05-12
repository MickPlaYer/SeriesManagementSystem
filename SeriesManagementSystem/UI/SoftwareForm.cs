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
            _seriesManager = _software.GetSeriesManager();
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
            var senderGrid = (DataGridView)sender;
            var column = senderGrid.Columns[e.ColumnIndex];
            var row = senderGrid.Rows[e.RowIndex];
            if (column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int sid = Int32.Parse(row.Cells[4].Value.ToString());
                if (column.Name == "Remove")
                {
                    var result = MessageBox.Show("是否刪除影集？", "刪除影集", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        _software.RemoveSeries(sid);
                }
                else if (column.Name == "Modify")
                {
                    _software.SelectSeries(sid);
                    string name = row.Cells[2].Value.ToString();
                    string desc = row.Cells[3].Value.ToString();
                    using (var modifyForm = new SeriesForm(name, desc))
                    {
                        if (modifyForm.ShowDialog() == DialogResult.OK)
                        {
                            _software.ModifySeries(modifyForm.ReturnName, modifyForm.ReturnDesc);
                            seriesListBindingSource.ResetBindings(true);
                        }
                    }
                }
                seriesListBindingSource.ResetBindings(true);
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
            ReportFromServer();
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            this.Enabled = false;
            _software.AddServerData(new Server());
            this.Enabled = true;
            ReportFromServer();
        }

        private void ReportFromServer()
        {
            if (_software.IsNoInternet)
            {
                MessageBox.Show("目前裝置尚未連接網路", "連線失敗");
            }
            else if (!_seriesManager.IsExistNewOne)
            {
                MessageBox.Show("沒有新的影音資訊", "已更新");
            }
        }
    }
}
