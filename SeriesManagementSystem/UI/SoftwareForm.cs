using SeriesManagementSystem.Domain;
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
        }

        private void ClickAddSeriesButton(object sender, System.EventArgs e)
        {
            using (var addForm = new SeriesForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _software.AddSeries(addForm.ReturnSeries.Name, addForm.ReturnSeries.Description);
                }
            }
        }
    }
}
