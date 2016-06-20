using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI
{
    public partial class CommandForm : Form
    {
        List<Command> _commands;
        int _nowCommand;

        public CommandForm(string seriesName, string episodeName, string episodeDes, List<Command> commands)
        {
            InitializeComponent();
            string formTitle = seriesName + " - " + episodeName;
            if (commands.Count == 0)
                throw new Exception("there is no command in this episode");
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == formTitle)
                {
                    form.Close();
                    break;
                }
            }

            this.Text = formTitle;
            label_SeriesName.Text = seriesName;
            label_EpisodeName.Text = episodeName;
            label_EpisodeDes.Text = episodeDes;
            _commands = commands;
            _nowCommand = 0;

            RefreshCommandForm();
        }

        private void RefreshCommandForm()
        {
            label_CommandNum.Text = (_nowCommand + 1).ToString();
            label_Command.Text = _commands[_nowCommand].Content;
            button_CommandLeft.Enabled = true;
            button_CommandRight.Enabled = true;

            if (_nowCommand == 0)
            {
                button_CommandLeft.Enabled = false;
            }
            if (_nowCommand == _commands.Count - 1)
            {
                button_CommandRight.Enabled = false;
            }
        }


        private void ReduceCommandCount(object sender, EventArgs e)
        {
            _nowCommand--;
            RefreshCommandForm();
        }

        private void AddCommandCount(object sender, EventArgs e)
        {
            _nowCommand++;
            RefreshCommandForm();
        }

        private void label_EpisodeDes_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
