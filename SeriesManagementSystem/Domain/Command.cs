using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.Domain
{
    public class Command
    {
        private string _content;

        public Command(string content)
        {
            _content = content;
        }

        public String Content
        {
            get
            {
                return _content;
            }
        }
    }
}
