// See https://aka.ms/new-console-template for more information
using System;
using MaintainingAddressBook;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("********** Welcome in this Address Book ************");
        AddressBook addressBook = new AddressBook();
        Console.WriteLine("Please Enter the Information");
        bool check = true;
        Console.WriteLine(" Enter the Zero to Stop The Execution 0\n Display The Information1\n Edit the Information 2\n Delete The Information 3\n Add Data in the Dictionary 4\n EditingDictionary Data in the AddressBook 5\n  Deleting data from Dictionary 6\n Searching Person in City 8\n Searching Person Details With The Name Of City 9\n Displaying Contact Number 10\n Sorting the Data By the Person Name 11\n");

        while (check)
        {
            Console.WriteLine("***** Please Enter The Above Option *******");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: addressBook.Display(); break;
                case 2:
                    Console.WriteLine("Enter the Name for Edit the Information");
                    string name = Console.ReadLine();
                    addressBook.EditContactInAddressBook(name); break;
                case 3:
                    Console.WriteLine("Enter the Name for Delete the Information");
                    string deleteName1 = Console.ReadLine();
                    addressBook.DeletingContactINAddressBook(deleteName1); break;
                case 4:
                    Console.WriteLine("Enter the Name for Adding data in Dictionary ");
                    string dictionaryName = Console.ReadLine();
                    addressBook.AddDictionary(dictionaryName); break;
                case 5:
                    Console.WriteLine("Enter the Name for Editing data in Dictionary ");
                    string dictName = Console.ReadLine();
                    string contactName = Console.ReadLine();
                    addressBook.EditingDictionary(dictName, contactName); break;
                case 6:
                    Console.WriteLine("Enter the Name for Deleting data in Dictionary ");
                    string deleteName = Console.ReadLine();
                    addressBook.DeleteDictionaryData(deleteName); break;
                case 8:
                    Console.WriteLine("Enter the Person And City Name for Searchin Person City in Dictionary ");
                    string cityName = Console.ReadLine();
                    addressBook.SearchingPersonInCity(cityName); break;
                case 9:
                    Console.WriteLine("Enter the City Name  for Searching Person City in Dictionary ");
                    string city = Console.ReadLine();

                    addressBook.MaintingDictionaryWithCityAndPerson(city);
                    break;
                case 10:
                    Console.WriteLine("Enter the City Name  for Searching Person City in Dictionary ");
                    string enterCityName = Console.ReadLine();
                    addressBook.GetPhoneNumberByCity(enterCityName); break;
                    break;
                case 11:

                    addressBook.SortingDataByPersonName(); break;
                    break;
                case 0: check = false; break;
                default: Console.WriteLine("Please Enter the Valid Option"); break;
            }

        }
    }
}
