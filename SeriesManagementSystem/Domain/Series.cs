using Newtonsoft.Json;

namespace SeriesManagementSystem.Domain
{
    public class Series
    {
        private int _seriesID;
        private string _name;
        private string _description;

        public Series(string name, string description)
        {
            _name = name;
            _description = description;
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
        }
        #endregion
    }
}
