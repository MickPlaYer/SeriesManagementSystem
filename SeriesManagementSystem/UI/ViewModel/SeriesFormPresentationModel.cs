using System.ComponentModel;

namespace SeriesManagementSystem.UI.ViewModel
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

        #region Public Property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                Notify("IsOkButtonEnabled");
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

        #endregion

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

        private void Notify(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
