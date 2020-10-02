using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace AddressBook
{
    class AddressBk
    {
        int flag, choice = 0;
        private List<Contact> li = new List<Contact>();
        public void add(Contact obj)
        {
            li.Add(obj);
        }
        public List<Contact> getContact()
        {
            return li;

        }

        public void editContact(string name)
        {
            foreach (Contact obj in li)
            {
                if (obj.getFname().Equals(name) && flag == 0)
                {
                    flag = 1;
                    Console.WriteLine("Enter the choice to change");
                    Console.WriteLine("1. Change First name");
                    Console.WriteLine("2. Change last name");
                    Console.WriteLine("3. Change the address");
                    Console.WriteLine("4. Change the city");
                    Console.WriteLine("5. Change the state");
                    Console.WriteLine("6. Change the zip");
                    Console.WriteLine("7. Change the phone number");
                    Console.WriteLine("8. Change the EmailID");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Enter the new First name");
                        string fname = Console.ReadLine();
                        obj.setFname(fname);

                    }
                    if (choice == 2)
                    {
                        Console.WriteLine("Enter the new Last name");
                        string lname = Console.ReadLine();
                        obj.setLname(lname);

                    }
                    if (choice == 3)
                    {
                        Console.WriteLine("Enter the address");
                        string address = Console.ReadLine();
                        obj.setAdd(address);

                    }
                    if (choice == 4)
                    {
                        Console.WriteLine("Enter the new City");
                        string city = Console.ReadLine();
                        obj.setCity(city);

                    }
                    if (choice == 5)
                    {
                        Console.WriteLine("Enter the new State");
                        string state = Console.ReadLine();
                        obj.setState(state);

                    }
                    if (choice == 6)
                    {
                        Console.WriteLine("Enter the new Zip code");
                        long zip = Convert.ToInt64(Console.ReadLine());
                        obj.setZip(zip);

                    }
                    if (choice == 7)
                    {
                        Console.WriteLine("Enter the new Phone Number");
                        long phoneNo = Convert.ToInt64(Console.ReadLine());
                        obj.setPhoneNo(phoneNo);

                    }
                    if (choice == 8)
                    {
                        Console.WriteLine("Enter the new EmailId");
                        string emaiId = Console.ReadLine();
                        obj.setEmailId(emaiId);

                    }


                }
            }

        }
        public void delContact(string name)
        {

            foreach (Contact obj in li)
            {
                if (obj.getFname().Equals(name))
                {
                    li.Remove(obj);
                }
            }

        }
    }
}
