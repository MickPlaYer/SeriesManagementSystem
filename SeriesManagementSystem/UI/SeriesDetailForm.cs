using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeriesManagementSystem.UI.ViewModel;
using SeriesManagementSystem.Domain;

namespace SeriesManagementSystem.UI
{
    public partial class SeriesDetailForm : Form
    {
        Software _software;
        SeriesDetailFormPresentationModel _pModel;

        public SeriesDetailForm()
        {
            InitializeComponent();
        }

        public SeriesDetailForm(Series series, Software software)
            : this()
        {
            _software = software;
            _pModel = new SeriesDetailFormPresentationModel(series);

            episodeBindingSource.DataSource = series.Episodes;
            RefreshSeriesData();
        }

        private void RefreshSeriesData()
        {
            label_EpisodeNum.Text = _pModel.EpisodeNumber.ToString();
            label_SeriesDes.Text = _pModel.SeriesDescription;
            label_SeriesName.Text = _pModel.SeriesName;
        }

        private void ClickButton_AddEpisode(object sender, EventArgs e)
        {
            using (var addForm = new AddDataForm(false))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _software.AddEpisode(addForm.ReturnName, addForm.ReturnDesc);
                    episodeBindingSource.ResetBindings(true);
                    RefreshSeriesData();
                }
            }
        }

        private void ClickdataGridView_Episodes_Cell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var column = dataGridView_Episodes.Columns[e.ColumnIndex];
            var row = dataGridView_Episodes.Rows[e.RowIndex];
            string episodeName = row.Cells[0].Value.ToString();
            string episodeDes = row.Cells[1].Value.ToString();

            if (column is DataGridViewButtonColumn)
            {
                using (var recordForm = new RecordForm(episodeName, true))
                {
                    if (recordForm.ShowDialog() == DialogResult.OK)
                        _software.Record(episodeName, recordForm.ReturnRecord);
                }
            }
            else if (column.GetType() == typeof(DataGridViewCheckBoxColumn))
            {
                bool addCommandFlag = false;
                if ((bool)row.Cells[3].Value == true)
                {
                    addCommandFlag = true;
                }
                using (var recordForm = new RecordForm(episodeName, addCommandFlag))
                {
                    if (recordForm.ShowDialog() == DialogResult.OK)
                        _software.Record(episodeName, recordForm.ReturnRecord);
                    else
                        _software.Record(episodeName, "");
                }
            }
            else
            {
                try
                {
                    new CommandForm(label_SeriesName.Text, episodeName, episodeDes, _pModel.GetCommands(episodeName)).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            episodeBindingSource.ResetBindings(true);
            RefreshSeriesData();
        }
    }
}
