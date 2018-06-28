using System.Collections.ObjectModel;

namespace MVVM.ViewModels
{
    using Models;

    class ContactManagerViewModel : ObservableCollection<Contact>
    {
        public ContactManagerViewModel()
        {
            PrepareContactCollection();
        }

        private void PrepareContactCollection()
        {
            //Create new contacts and add them to the ViewModel's 
            //ObservableCollection. 
            var ContactOne = new Contact
            {
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "jdoe@email.com",
                TelephoneNumber = "555-555-5555"

            };
            Add(ContactOne);

            var ContactTwo = new Contact
            {
                FirstName = "Bob",
                LastName = "Watson",
                EmailAddress = "bwatson@email.com",
                TelephoneNumber = "555-555-5555"

            };
            Add(ContactTwo);

            var ContactThree = new Contact
            {
                FirstName = "Joe",
                LastName = "Johnson",
                EmailAddress = "jjohnson@email.com",
                TelephoneNumber = "555-555-5555"

            };

            Add(ContactThree);
        }
    }
}