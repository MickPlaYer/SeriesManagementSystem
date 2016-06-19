using System;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI
{
    public partial class RecordForm : Form
    {
        /// <summary>
        /// form 的回傳值
        /// </summary>
        public string ReturnRecord
        {
            get
            {
                if (checkBox_AddTimeStamp.Checked)
                {
                    return textBox_Record.Text != "" ? textBox_Record.Text +"<" +DateTime.Now.ToShortDateString()+">" : "";
                }
                return textBox_Record.Text;
            }
        }

        public RecordForm(string episodeName, bool addCommand)
        {
            InitializeComponent();
            label_EpisodeName.Text += episodeName;

            if (!addCommand)
            {
                button_Cancel.Text = "不留下評論";
                button_Yes.Text = "留下評論";
            }            
        }
    }
}
