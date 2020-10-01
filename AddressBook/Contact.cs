using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace AddressBook
{
    class Contact
    {

        private string fname;
        private string lname;
        private string address;
        private string city;
        private string state;
        private long zip;
        private long phoneNo;
        private string emailId;

        public Contact(string fname, string lname, string address, string city, string state, long zip, long phoneNo, string emailId)
        {
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
            this.emailId = emailId;
        }

        public string getFname()
        {
            return fname;
        }

        public void editContact(string name)
        {
            
        }

        public void deleteContact(String name)
        {

        }

        public string toString()
        {
            
        }

    }
}
