using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.Domain
{
    public class Episode
    {
        private string _name;
        private string _description;
        private int _episodeID;
        private bool _isRead;
        private List<Command> _commandList = new List<Command>();

        [JsonConstructor]
        public Episode(string name, string description, int id)
        {
            _name = name;
            _description = description;
            _episodeID = id;
        }

        #region Public Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public int EpisodeID
        {
            get
            {
                return _episodeID;
            }
        }

        public bool IsRead 
        { 
            get
            {
                return _isRead;
            }
        }

        public List<Command> CommandList
        {
            get
            {
                return _commandList;
            }
        }
        #endregion

        public void Record(string command)
        {
            _isRead = true;
            if (command != String.Empty)
            {
                Command c = new Command(command);
                _commandList.Add(c);
            }
        }
    }
}
