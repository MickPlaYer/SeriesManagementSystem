using SeriesManagementSystem.Domain;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI
{
    public partial class SoftwareForm8888 : Form
    {
        private Software _software;
        public SoftwareForm8888(Software software)
        {
            InitializeComponent();
            _software = software;
        }
    }
}
