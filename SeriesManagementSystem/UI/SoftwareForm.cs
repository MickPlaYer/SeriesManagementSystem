using SeriesManagementSystem.Domain;
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
            SwitchCheckBoxValue(0, true);
        }

        private void OnAddSeries(object sender, EventArgs e)
        {
            using (var addForm = new AddDataForm(true))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _software.AddSeries(addForm.ReturnName, addForm.ReturnDesc);
                    seriesListBindingSource.ResetBindings(true);
                    ClickCheckBoxAll(this, new EventArgs());
                }
            }
        }

        private void OnCellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = _seriesGridView.Columns[e.ColumnIndex];
            var row = _seriesGridView.Rows[e.RowIndex];
            int sid = Int32.Parse(row.Cells[4].Value.ToString());
            if (column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string name = row.Cells[2].Value.ToString();
                string desc = row.Cells[3].Value.ToString();
                if (column.Name == "Remove")
                    DeleteSeries(sid);
                else if (column.Name == "Modify")
                    ModifySeries(name, desc, sid);
                seriesListBindingSource.ResetBindings(true);
            }
            else
            {
                _software.SelectSeries(sid);
                new SeriesDetailForm(_seriesManager.SelectedSeries, _seriesManager).ShowDialog();
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
            using (var modifyForm = new AddDataForm(name, desc))
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
                    ClickCheckBoxAll(this, new EventArgs());
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
            ClickCheckBoxAll(this, new EventArgs());
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

        private void SwitchCheckBoxValue(int index, bool value)
        {
            /// 0 => CheckBoxAll
            /// 1 => CheckBoxFollowing
            /// 2 => CheckBoxUnfollowing
            bool[] _checkBoxList = new bool[3] { false, false, false };
            _checkBoxList[index] = value;
            if (index == 0 && !value)
                _checkBoxList[index] = true;
            else if (index != 0 && !value)
                _checkBoxList[0] = true;

            if (value)
                _seriesManager.SetSeriesFlitter((SeriesListFlitter)index);
            else
                _seriesManager.SetSeriesFlitter(0);

            checkBox_All.Checked = _checkBoxList[0];
            checkBox_Following.Checked = _checkBoxList[1];
            checkBox_Unfollowing.Checked = _checkBoxList[2];
            seriesListBindingSource.DataSource = _seriesManager.SeriesList;
            seriesListBindingSource.ResetBindings(true);
        }

        private void ClickCheckBoxAll(object sender, EventArgs e)
        {
            SwitchCheckBoxValue(0, checkBox_All.Checked);
        }

        private void ClickCheckBoxFollowing(object sender, EventArgs e)
        {
            SwitchCheckBoxValue(1, checkBox_Following.Checked);
        }

        private void ClickCheckBoxUnfollowing(object sender, EventArgs e)
        {
            SwitchCheckBoxValue(2, checkBox_Unfollowing.Checked);
        }
    }
}
