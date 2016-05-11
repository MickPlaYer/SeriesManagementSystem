using SeriesManagementSystem.Domain;
using System;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI
{
    public partial class SoftwareForm : Form
    {
        private Software _software;

        public SoftwareForm(Software software)
        {
            InitializeComponent();
            _software = software;
            seriesListBindingSource.DataSource = _software.GetSeriesList();
            if (_software.IsNoInternet)
                MessageBox.Show("目前裝置尚未連接網路");
        }

        private void OnAddSeries(object sender, EventArgs e)
        {
            using (var addForm = new SeriesForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _software.AddSeries(addForm.ReturnSeries.Name, addForm.ReturnSeries.Description);
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
                    /*SeriesForm s = new SeriesForm(name, desc);
                    seriesForm.ShowDialog();
                    if (s.DialogResult == DialogResult.OK)
                        _software.ModifySeries(s.SeriesName, s.Description);*/
                }
                seriesListBindingSource.ResetBindings(true);
            }
        }
    }
}
