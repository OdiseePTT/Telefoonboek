using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Telefoonboek
{
    internal class MainViewModel: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string lastname;
        private string firstname;
        private string email;
        private string phoneNumber;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public MainViewModel()
        {
            SaveCommand = new ActionCommand(SaveCommandAction);
            DeleteCommand = new ActionCommand(DeleteCommandAction);
        }

        private void SaveCommandAction()
        {

        }

        private void DeleteCommandAction()
        {

        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        } 
        {
            get => saveButtonEnabled;
            private set
            {
                saveButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        private void CheckSaveButtonEnabled()
        {
            SaveButtonEnabled = (Lastname != null && FirstName != null && (email != null || phoneNumber != null));
        }


        public bool DeleteButtonEnabled
        {
            get => deleteButtonEnabled;
            private set
            {
                deleteButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        public TelephoneBookItem SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                DeleteButtonEnabled = SelectedItem != null;
                if (SelectedItem == null)
                {
                    Lastname = null;
                    FirstName = null;
                    Email = null;
                    PhoneNumber = null;

                }
                else
                {
                    Lastname = SelectedItem.Lastname;
                    FirstName = SelectedItem.Firstname;
                    Email = SelectedItem.Email;
                    PhoneNumber = SelectedItem.PhoneNumber;

                }
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            SaveCommand = new ActionCommand(SaveCommandAction);
            DeleteCommand = new ActionCommand(DeleteCommandAction);

        }

        private void SaveCommandAction()
        {
            if (SelectedItem==null)
            {
                TelephoneBookItem telephoneBookItem = new TelephoneBookItem(Lastname, FirstName, PhoneNumber, Email);
                TelephoneBookItems.Add(telephoneBookItem);
            } else
            {
                SelectedItem.Lastname = Lastname;
                SelectedItem.Email = Email;
                SelectedItem.PhoneNumber = PhoneNumber;
                SelectedItem.Firstname = FirstName;
            }

            SelectedItem = null;
        }

        private void DeleteCommandAction()
        {
            TelephoneBookItems.Remove(SelectedItem);
        }

        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        {
            get => saveButtonEnabled;
            private set
            {
                saveButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        private void CheckSaveButtonEnabled()
        {
            SaveButtonEnabled = (Lastname != null && FirstName != null && (email != null || phoneNumber != null));
        }


        public bool DeleteButtonEnabled
        {
            get => deleteButtonEnabled;
            private set
            {
                deleteButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        public TelephoneBookItem SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                DeleteButtonEnabled = SelectedItem != null;
                if (SelectedItem == null)
                {
                    Lastname = null;
                    FirstName = null;
                    Email = null;
                    PhoneNumber = null;

                }
                else
                {
                    Lastname = SelectedItem.Lastname;
                    FirstName = SelectedItem.Firstname;
                    Email = SelectedItem.Email;
                    PhoneNumber = SelectedItem.PhoneNumber;

                }
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            SaveCommand = new ActionCommand(SaveCommandAction);
            DeleteCommand = new ActionCommand(DeleteCommandAction);

        }

        private void SaveCommandAction()
        {
            if (SelectedItem==null)
            {
                TelephoneBookItem telephoneBookItem = new TelephoneBookItem(Lastname, FirstName, PhoneNumber, Email);
                TelephoneBookItems.Add(telephoneBookItem);
            } else
            {
                SelectedItem.Lastname = Lastname;
                SelectedItem.Email = Email;
                SelectedItem.PhoneNumber = PhoneNumber;
                SelectedItem.Firstname = FirstName;
            }

            SelectedItem = null;
        }

        private void DeleteCommandAction()
        {
            TelephoneBookItems.Remove(SelectedItem);
        }

        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        {
            get => saveButtonEnabled;
            private set
            {
                saveButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        private void CheckSaveButtonEnabled()
        {
            SaveButtonEnabled = (Lastname != null && FirstName != null && (email != null || phoneNumber != null));
        }


        public bool DeleteButtonEnabled
        {
            get => deleteButtonEnabled;
            private set
            {
                deleteButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        public TelephoneBookItem SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                DeleteButtonEnabled = SelectedItem != null;
                if (SelectedItem == null)
                {
                    Lastname = null;
                    FirstName = null;
                    Email = null;
                    PhoneNumber = null;

                }
                else
                {
                    Lastname = SelectedItem.Lastname;
                    FirstName = SelectedItem.Firstname;
                    Email = SelectedItem.Email;
                    PhoneNumber = SelectedItem.PhoneNumber;

                }
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            SaveCommand = new ActionCommand(SaveCommandAction);
            DeleteCommand = new ActionCommand(DeleteCommandAction);

        }

        private void SaveCommandAction()
        {
            if (SelectedItem==null)
            {
                TelephoneBookItem telephoneBookItem = new TelephoneBookItem(Lastname, FirstName, PhoneNumber, Email);
                TelephoneBookItems.Add(telephoneBookItem);
            } else
            {
                SelectedItem.Lastname = Lastname;
                SelectedItem.Email = Email;
                SelectedItem.PhoneNumber = PhoneNumber;
                SelectedItem.Firstname = FirstName;
            }

            SelectedItem = null;
        }

        private void DeleteCommandAction()
        {
            TelephoneBookItems.Remove(SelectedItem);
        }

        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        {
            get => saveButtonEnabled;
            private set
            {
                saveButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        private void CheckSaveButtonEnabled()
        {
            SaveButtonEnabled = (Lastname != null && FirstName != null && (email != null || phoneNumber != null));
        }


        public bool DeleteButtonEnabled
        {
            get => deleteButtonEnabled;
            private set
            {
                deleteButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        public TelephoneBookItem SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                DeleteButtonEnabled = SelectedItem != null;
                if (SelectedItem == null)
                {
                    Lastname = null;
                    FirstName = null;
                    Email = null;
                    PhoneNumber = null;

                }
                else
                {
                    Lastname = SelectedItem.Lastname;
                    FirstName = SelectedItem.Firstname;
                    Email = SelectedItem.Email;
                    PhoneNumber = SelectedItem.PhoneNumber;

                }
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            SaveCommand = new ActionCommand(SaveCommandAction);
            DeleteCommand = new ActionCommand(DeleteCommandAction);

        }

        private void SaveCommandAction()
        {
            if (SelectedItem==null)
            {
                TelephoneBookItem telephoneBookItem = new TelephoneBookItem(Lastname, FirstName, PhoneNumber, Email);
                TelephoneBookItems.Add(telephoneBookItem);
            } else
            {
                SelectedItem.Lastname = Lastname;
                SelectedItem.Email = Email;
                SelectedItem.PhoneNumber = PhoneNumber;
                SelectedItem.Firstname = FirstName;
            }

            SelectedItem = null;
        }

        private void DeleteCommandAction()
        {
            TelephoneBookItems.Remove(SelectedItem);
        }

        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
