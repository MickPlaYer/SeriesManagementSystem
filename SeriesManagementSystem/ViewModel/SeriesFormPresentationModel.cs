using System.ComponentModel;

namespace SeriesManagementSystem.ViewModel
{
    public class SeriesFormPresentationModel : INotifyPropertyChanged
    {
        private string _name;
        private string _description;

        public event PropertyChangedEventHandler PropertyChanged;

        public SeriesFormPresentationModel()
        {
            _name = string.Empty;
            _description = string.Empty;
        }

        public SeriesFormPresentationModel(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public bool IsOkButtonEnabled
        {
            get
            {
                if (_name != string.Empty)
                {
                    return true;
                }
                return false;
            }
        }

        public void ModifyName(string name)
        {
            _name = name;
            Notify("IsOkButtonEnabled");
        }

        public void ModifyDescription(string desc)
        {
            _description = desc;
        }

        private void Notify(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
