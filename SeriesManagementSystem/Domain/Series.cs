using Newtonsoft.Json;
using System.Collections.Generic;

namespace SeriesManagementSystem.Domain
{
    public class Series
    {
        private int _seriesID;
        private string _name;
        private string _description;
        private List<Episode> _episodes;
        

        public Series(string name, string description)
        {
            _name = name;
            _description = description;
            _episodes = new List<Episode>();
        }

        [JsonConstructor]
        public Series(string name, string description, int seriesID) :
            this(name, description)
        {
            _seriesID = seriesID;
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

        public int SeriesID
        {
            get
            {
                return _seriesID;
            }
            set
            {
                _seriesID = value;
            }
        }

        public List<Episode> Episodes
        {
            get
            {
                return _episodes;
            }
        }
        #endregion

        public void AddEpisode(string episodeName, string episodeDescription)
        {
            _episodes.Add(new Episode(episodeName, episodeDescription, _episodes.Count));
        }
    }
}
