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
            if (commands.Count == 0)
                throw new Exception("there is no command in this episode");

            label_SeriesName.Text = seriesName;
            label_EpisodeName.Text = episodeName;
            label_EpisodeDes.Text = episodeDes;
            _commands = commands;
            _nowCommand = 0;

            RefreshCommandContext();
        }

        private void RefreshCommandContext()
        {
            label_CommandNum.Text = (_nowCommand+1).ToString();
            label_Command.Text = _commands[_nowCommand].Context;
        }


        private void ReduceCommandCount(object sender, EventArgs e)
        {
            if (_nowCommand != 0)
            {
                _nowCommand--;
                RefreshCommandContext();
            }
        }

        private void AddCommandCount(object sender, EventArgs e)
        {
            if (_nowCommand < _commands.Count - 1)
            {
                _nowCommand++;
                RefreshCommandContext();
            }
        }
    }
}
