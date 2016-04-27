using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.Domain
{
    public class Software
    {
        private List<Series> _seriesList = new List<Series>();

        public void AddSeries(string name, string description)
        {
            Series s = new Series(name, description);
            _seriesList.Add(s);
        }
    }
}
