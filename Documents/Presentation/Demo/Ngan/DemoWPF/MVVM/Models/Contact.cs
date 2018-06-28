using System.ComponentModel;

namespace MVVM.Models
{
    class Contact : INotifyPropertyChanged
    {

        private string _firstName;
        private string _lastName;
        private string _telephoneNumber;
        private string _emailAddress;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                _emailAddress = value;
                OnPropertyChanged("EmailAddress");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string TelephoneNumber
        {
            get { return _telephoneNumber; }
            set
            {
                _telephoneNumber = value;
                OnPropertyChanged("LastName");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //This routine is called each time a property value has been set. This will 
        //cause an event to notify WPF via data-binding that a change has occurred. 
        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}