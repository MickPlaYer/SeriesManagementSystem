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
    }
}
