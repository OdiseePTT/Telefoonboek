using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Telefoonboek
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string lastname;
        private string firstName;
        private string email;
        private string phoneNumber;
        private ObservableCollection<TelephoneBookItem> telephoneBookItems = new ObservableCollection<TelephoneBookItem>();
        private bool saveButtonEnabled;
        private bool deleteButtonEnabled;
        private TelephoneBookItem selectedItem;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Lastname
        {
            get => lastname;
            set
            {
                lastname = value;
                CheckSaveButtonEnabled();
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                CheckSaveButtonEnabled();
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                CheckSaveButtonEnabled();
                OnPropertyChanged();
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                phoneNumber = value;
                CheckSaveButtonEnabled();
                OnPropertyChanged();
            }
        }


        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ObservableCollection<TelephoneBookItem> TelephoneBookItems { get => telephoneBookItems; set => telephoneBookItems = value; }
        public bool SaveButtonEnabled
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
