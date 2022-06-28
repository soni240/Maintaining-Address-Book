// See https://aka.ms/new-console-template for more information
using System;
using MaintainingAddressBook;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("********** Welcome in this Address Book ************");
        Contact addressBook = new Contact();
        Console.WriteLine("Please Enter the Information");
        addressBook.FirstName = Console.ReadLine();
        addressBook.LastName = Console.ReadLine();
        addressBook.Address = Console.ReadLine();
        addressBook.City = Console.ReadLine();
        addressBook.State = Console.ReadLine();
        addressBook.EmailAddress = Console.ReadLine();
        addressBook.PostalCode = Convert.ToInt32(Console.ReadLine());
        addressBook.MobileNumber = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine(addressBook.FirstName + " " + addressBook.LastName + " " + addressBook.Address + " " + addressBook.City + " " + addressBook.State + " " + addressBook.EmailAddress + " " + addressBook.PostalCode + " " + addressBook.MobileNumber);

    }
}

