using SeriesManagementSystem.Domain;
using SeriesManagementSystem.UI.ViewModel;
using System;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI
{
    public partial class AddDataForm : Form
    {
        private AddDataFormPresentationModel _pModel;
        
        /// <summary>
        /// form 的回傳值
        /// </summary>
        public string ReturnName
        {
            get
            {
                return _pModel.Name;
            }
        }

        public string ReturnDesc
        {
            get
            {
                return _pModel.Description;
            }
        }

        /// <summary>
        /// add series 的 form
        /// </summary>
        public AddDataForm(bool series)
        {
            InitializeComponent();
            if (series)
            {
                this.Text = "新增 Series";
                this.button_Confirm.Text = "新增影集";
            }
            else
            {
                this.Text = "新增 Episode";
                this.button_Confirm.Text = "新增 Episode";
            }
            
            _pModel = new AddDataFormPresentationModel();
            button_Confirm.DataBindings.Add("Enabled", _pModel, "IsOkButtonEnabled");
        }

        /// <summary>
        /// edit series 的 form
        /// </summary>
        /// <param name="series"></param>
        public AddDataForm(string name, string description)
        {
            InitializeComponent();
            this.Text = "修改 Series";
            this.button_Confirm.Text = "修改影集";

            _pModel = new AddDataFormPresentationModel(name, description);

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
            _pModel.Name = textBox_SeriesName.Text;
        }

        private void ChangeTextBoxSeriesDescription(object sender, EventArgs e)
        {
            _pModel.Description = textBox_SeriesDesc.Text;
        }
    }
}
