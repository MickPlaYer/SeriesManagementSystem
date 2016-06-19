using System;

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
