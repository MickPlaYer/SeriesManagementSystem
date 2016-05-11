using SeriesManagementSystem.Domain;
using SeriesManagementSystem.ViewModel;
using System;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI
{
    public partial class SeriesForm : Form
    {
        private Series _series;
        private SeriesFormPresentationModel _model;
        
        /// <summary>
        /// form 的回傳值
        /// </summary>
        public Series ReturnSeries
        {
            get
            {
                return _series;
            }
        }

        /// <summary>
        /// add series 的 form
        /// </summary>
        public SeriesForm()
        {
            //this.button_Confirm.Enabled = true;
            InitializeComponent();
            this.Text = "新增 Series";
            this.button_Confirm.Text = "新增影集";
            _series = new Series("", "");

            _model = new SeriesFormPresentationModel();
            button_Confirm.DataBindings.Add("Enabled", _model, "IsOkButtonEnabled");
        }

        /// <summary>
        /// edit series 的 form
        /// </summary>
        /// <param name="series"></param>
        public SeriesForm(Series series)
        {
            InitializeComponent();
            this.Text = "修改 Series";
            this.button_Confirm.Text = "修改影集";

            this.textBox_SeriesName.Text = series.Name;
            this.textBox_SeriesDes.Text = series.Description;
            _series = series;
            _model = new SeriesFormPresentationModel();
        }

        private void ClickButtonConfirm(object sender, EventArgs e)
        {
            _series.Name = textBox_SeriesName.Text;
            _series.Description = textBox_SeriesDes.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void ClickButtonCancel(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void ChangeTextBoxSeriesName(object sender, EventArgs e)
        {
            _model.ModifyName(textBox_SeriesName.Text);
        }
    }
}
