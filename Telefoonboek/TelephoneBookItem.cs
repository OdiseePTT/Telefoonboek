using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Telefoonboek
{
    internal class TelephoneBookItem : INotifyPropertyChanged
    {
        private string lastname;
        private string firstname;
        private string phoneNumber;
        private string email;

        public TelephoneBookItem(string lastname, string firstname, string phoneNumber, string email)
        {
            Lastname = lastname;
            Firstname = firstname;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Lastname
        {
            get => lastname;
            set
            {
                lastname = value;
                OnPropertyChanged();
            }
        }
        public string Firstname
        {
            get => firstname; set
            {
                firstname = value;
                OnPropertyChanged();
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber; set
            {
                phoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => email; set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public override string ToString()
        {
            return $"{lastname} {firstname}";
        }
    }
}