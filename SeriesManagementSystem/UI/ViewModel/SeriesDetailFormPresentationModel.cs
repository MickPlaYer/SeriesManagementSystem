using SeriesManagementSystem.Domain;
using System.Collections.Generic;

namespace SeriesManagementSystem.UI.ViewModel
{
    public class SeriesDetailFormPresentationModel
    {
        Series _series;

        public SeriesDetailFormPresentationModel(Series series)
        {
            _series = series;
        }

        public int EpisodeNumber
        {
            get
            {
                return _series.Episodes.Count;
            }
        }

        public string SeriesName
        {
            get
            {
                return _series.Name;
            }
        }

        public string SeriesDescription
        {
            get
            {
                return _series.Description;
            }
        }

        public List<Command> GetCommands(string episodeName)
        {
            return _series.Episodes.Find((x) => x.Name == episodeName).CommandList;
        }
    }
}
