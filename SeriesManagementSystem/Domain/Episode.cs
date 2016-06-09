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
        #endregion
    }
}
