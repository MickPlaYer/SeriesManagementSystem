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
        SeriesDetailFormPresentationModel _pModel;

        public SeriesDetailForm()
        {
            InitializeComponent();
        }

        public SeriesDetailForm(Series series):this()
        {
            _pModel = new SeriesDetailFormPresentationModel(series);
        }
    }
}
