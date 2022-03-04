using System;
using System.Collections.Generic;

namespace address_book
{
    public class AddressBook
    {
        private Dictionary<string, Contact> _contactList = new Dictionary<string, Contact>();
        public Dictionary<string, Contact> contactList
        {
            get
            {
                return _contactList;
            }
        }
        public void AddContact(Contact givenContact)
        {
            try
            {
                contactList.Add(givenContact.Email, givenContact);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You cannot add duplicate contacts.");
            }
        }

        public Contact GetByEmail(string email)
        {
            return contactList[email];
        }

    }
}