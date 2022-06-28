using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintainingAddressBook
{
    public class AddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dictionaryName = new Dictionary<string, List<Contact>>();
        public AddressBook()
        {
            Contact address1 = new Contact()
            {
                FirstName = "Vijay",
                LastName = "Kumar",
                Address = "Indranagar",
                City = "Lucknow",
                State = "Utter Pradesh",
                EmailAddress = "vijay123@gmail.com",
                PostalCode = 226021,
                MobileNumber = 9721944611
            };
            Contact address2 = new Contact()
            {
                FirstName = "Arun",
                LastName = "Arya",
                Address = "CSMT",
                City = "Mumbai",
                State = "Maharastra",
                EmailAddress = "arun123@gmail.com",
                PostalCode = 400008,
                MobileNumber = 9721945611
            };
            Console.WriteLine("Enter the FirstName LastName Address City State Email postalCode mobile Number");
            Contact address3 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                EmailAddress = Console.ReadLine(),
                PostalCode = Convert.ToInt32(Console.ReadLine()),
                MobileNumber = Convert.ToInt64(Console.ReadLine())
            };
            addressBook.Add(address1);
            addressBook.Add(address2);
            addressBook.Add(address3);
        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
            }
        }
        public void EditContactInAddressBook(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter the Option To Update");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the FirstName to Update");
                            contact.FirstName = Console.ReadLine(); break;
                        case 2:
                            Console.WriteLine("Enter the LastName to Update");
                            contact.LastName = Console.ReadLine(); break;
                        case 3:
                            Console.WriteLine("Enter the Address to Update");
                            contact.Address = Console.ReadLine(); break;
                        case 4:
                            Console.WriteLine("Enter the City to Update");
                            contact.City = Console.ReadLine(); break;
                        case 5:
                            Console.WriteLine("Enter the State to Update");
                            contact.State = Console.ReadLine(); break;
                        case 6:
                            Console.WriteLine("Enter the Email to Update");
                            contact.EmailAddress = Console.ReadLine(); break;
                        case 7:
                            Console.WriteLine("Enter the Postal to Update");
                            contact.PostalCode = Convert.ToInt32(Console.ReadLine()); break;
                        case 8:
                            Console.WriteLine("Enter the MobileNumber to Update");
                            contact.MobileNumber = Convert.ToInt64(Console.ReadLine()); break;
                    }
                }
                Display();
            }
        }

                
                /// Deletings the contact in address book.
       
            public void DeletingContactINAddressBook(string name)
            {
            Contact delete = new Contact();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Display();
            }

        // add person details one at a time
        public void AddDictionary(string name)
        {
            if (dictionaryName == null)
            {
                dictionaryName.Add(name, addressBook);
            }
            if (NameExists(name) == false)
            {
                dictionaryName.Add(name, addressBook);
            }
            Console.WriteLine(dictionaryName);
        }
        public bool NameExists(string name)
        {
            foreach (var data in dictionaryName.Keys)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

    

