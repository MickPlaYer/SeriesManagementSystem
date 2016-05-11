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

        private void AddSeries(object sender, EventArgs e)
        {
            SeriesForm seriesForm = new SeriesForm();
            seriesForm.ShowDialog();
            if (seriesForm.DialogResult == DialogResult.OK)
            {
                Series s = seriesForm.ReturnSeries;
                _software.AddSeries(s.Name, s.Description);
            }
        }
    }
}
