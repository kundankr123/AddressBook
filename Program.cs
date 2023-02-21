namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program. ");


            AddressBook myAddressBook = new AddressBook();
            Contacts newContact = new Contacts("Kundan", "kumar", "INDIA", "7975461361", "kundankr@example.com");

            myAddressBook.AddContact(newContact);
            myAddressBook.PrintContacts();
        }
    }
}