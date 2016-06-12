using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public RecordForm(string episodeName)
        {
            InitializeComponent();
            label_EpisodeName.Text += episodeName;
        }
    }
}
