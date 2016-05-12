using SeriesManagementSystem.Domain;
using SeriesManagementSystem.UI.ViewModel;
using System;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI
{
    public partial class SeriesForm : Form
    {
        private SeriesFormPresentationModel _model;
        
        /// <summary>
        /// form 的回傳值
        /// </summary>
        public string ReturnName
        {
            get
            {
                return _model.Name;
            }
        }

        public string ReturnDesc
        {
            get
            {
                return _model.Description;
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

            _model = new SeriesFormPresentationModel();
            button_Confirm.DataBindings.Add("Enabled", _model, "IsOkButtonEnabled");
        }

        /// <summary>
        /// edit series 的 form
        /// </summary>
        /// <param name="series"></param>
        public SeriesForm(string name, string description)
        {
            InitializeComponent();
            this.Text = "修改 Series";
            this.button_Confirm.Text = "修改影集";

            _model = new SeriesFormPresentationModel(name, description);

            this.textBox_SeriesName.Text = name;
            this.textBox_SeriesDesc.Text = description;
        }

        private void ClickButtonConfirm(object sender, EventArgs e)
        {
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
            _model.Name = textBox_SeriesName.Text;
        }

        private void ChangeTextBoxSeriesDescription(object sender, EventArgs e)
        {
            _model.Description = textBox_SeriesDesc.Text;
        }
    }
}
