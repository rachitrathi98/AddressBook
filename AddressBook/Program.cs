using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            AddressBk addressBk = new AddressBk();
            while (choice != 5)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Enter the contact");
                Console.WriteLine("2. Display contacts");
                Console.WriteLine("3. Edit the contact");
                Console.WriteLine("4. Delete a contact");
                Console.WriteLine("5. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
            
                switch (choice)
                {

                    case 1:
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
                        break;

                    case 2: List<Contact> contactList = addressBk.getContact();
                            foreach (Contact o in contactList) {

                            Console.WriteLine(o.toString());
                               }
                            break;
             
                    case 3: Console.WriteLine("Enter the name of the contact to edit");
                            string name = Console.ReadLine();
                            addressBk.editContact(name);
                            break;

                    case 4: Console.WriteLine("Enter the name of the contact to be deleted");
                            string delname = Console.ReadLine();
                            addressBk.delContact(delname);     
                                break;



                    case 5: Console.WriteLine("Exiting....");
                        break;

                    default: Console.WriteLine("Please enter a valid choice");
                        break;
                 }
            }
         }
     }
}
    

