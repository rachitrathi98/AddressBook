using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBk
    {
        private List<Contact> li = new List<Contact>();
        public void add(Contact obj)
        {
            li.Add(obj);
            Console.WriteLine(obj.toString());
        }
    }
}
