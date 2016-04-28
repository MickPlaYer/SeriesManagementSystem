using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeriesManagementSystem.Domain
{
    public class Series
    {
        private string _name;
        private string _description;

        public Series(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }
    }
}
