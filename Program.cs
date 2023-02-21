namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program. ");

            //UseCase1

            //AddressBook myAddressBook = new AddressBook();
            //Contacts newContact = new Contacts("Kundan", "kumar", "INDIA", "7975461361", "kundankr@example.com");
            //myAddressBook.AddContact(newContact);
            //myAddressBook.PrintContacts();


            //UseCase2

            //AddressBook myAddressBook = new AddressBook();

            //Console.WriteLine("Add new contact:");
            //Console.Write("Enter first name: ");
            //string firstName = Console.ReadLine();
            //Console.Write("Enter last name: ");
            //string lastName = Console.ReadLine();
            //Console.Write("Enter country: ");
            //string country = Console.ReadLine();
            //Console.Write("Enter phone number: ");
            //string phoneNumber = Console.ReadLine();
            //Console.Write("Enter email: ");
            //string email = Console.ReadLine();

            //Contacts newContact = new Contacts(firstName, lastName, country, phoneNumber, email);

            //myAddressBook.AddContact(newContact);
            //Console.WriteLine("Contact Details: ");
            //myAddressBook.PrintContacts();

            //UseCase3

            //AddressBook myAddressBook = new AddressBook();
            //Contacts newContact = new Contacts("kundan", "kumar", "INDIA", "7975461361", "kundan.kr@example.com");
            //myAddressBook.AddContact(newContact);
            //myAddressBook.PrintContacts();

            //myAddressBook.EditContacts("kundan", "kumar", "Rajan", "Kumar", "INDIA", "7975461361", "rajan.kr123@example.com");
            //myAddressBook.PrintContacts();

            //UseCase4

            AddressBook myAddressBook = new AddressBook();
            Contacts newContact = new Contacts("Kundan", "kumar", "INDIA", "7975461361", "kundan.kr123@example.com");
            Contacts newContact1 = new Contacts("Rajan", "Kumar", "India", "9693253810", "rajankumar.123@example.com");
            myAddressBook.AddContact(newContact);
            myAddressBook.AddContact(newContact1);

            myAddressBook.PrintContacts();

            myAddressBook.DeleteContact("Kundan", "kumar");
            myAddressBook.PrintContacts();



        }
    }
}