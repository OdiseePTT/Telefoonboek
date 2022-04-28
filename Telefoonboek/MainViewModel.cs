using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Telefoonboek
{
    internal class MainViewModel
    {
        private string name;
        private string firstName;
        private string email;
        private string phoneNumber;
        private ObservableCollection<TelephoneBookItem> telephoneBookItems = new ObservableCollection<TelephoneBookItem>();

        public string Name { get => name; set => name = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public ICommand SaveCommand { get; set; }
        public ObservableCollection<TelephoneBookItem> TelephoneBookItems { get => telephoneBookItems; set => telephoneBookItems = value; }

        public MainViewModel()
        {  
            SaveCommand = new MyCommand(saveCommandAction);
           
        }

        private void saveCommandAction()
        {
            if(Name != null && FirstName != null && (email != null || phoneNumber != null))
            {
                TelephoneBookItem telephoneBookItem = new TelephoneBookItem(Name, FirstName, PhoneNumber, Email);
                TelephoneBookItems.Add(telephoneBookItem);
            }
        }
    }
}
