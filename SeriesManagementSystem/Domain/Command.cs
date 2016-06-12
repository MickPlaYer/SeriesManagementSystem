using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.Domain
{
    public class Command
    {
        private string _context;

        public Command(string context)
        {
            _context = context;
        }

        public String Context
        {
            get
            {
                return _context;
            }
        }
    }
}
