namespace Telefoonboek
{
    internal class TelephoneBookItem
    {
        private string name;
        private string firstname;
        private string phoneNumber;
        private string email;

        public TelephoneBookItem(string name, string firstname, string phoneNumber, string email)
        {
            Name = name;
            Firstname = firstname;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get => name; private set => name = value; }
        public string Firstname { get => firstname; private set => firstname = value; }
        public string PhoneNumber { get => phoneNumber; private set => phoneNumber = value; }
        public string Email { get => email; private set => email = value; }


        public override string ToString()
        {
            return $"{name} {firstname}" ;
        }
    }
}