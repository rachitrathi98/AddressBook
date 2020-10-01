using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
                AddressBk addressBk = new AddressBk();
                string fname, lname, address, city, state, email;
                long phoneNumber, zip;
                Console.WriteLine("Enter the contact details");
                Console.WriteLine("Enter the first name");
                fname = Console.ReadLine();
                Console.WriteLine("Enter the last name");
                lname = Console.ReadLine();
                Console.WriteLine("Enter the address");
                address = Console.ReadLine();
                Console.WriteLine("Enter the city");
                city = Console.ReadLine();
                Console.WriteLine("Enter the state");
                state = Console.ReadLine();
                Console.WriteLine("Enter the zip code");
                zip = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the phone number");
                phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the EmailId");
                email = Console.ReadLine();
                Contact contact = new Contact(fname, lname, address, city, state, zip, phoneNumber, email);
                addressBk.add(contact);
            





        }
    }
}
