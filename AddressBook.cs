using System;
using System.Collections.Generic;

namespace address_book
{
    public class AddressBook
    {
        public Dictionary<string, Contact> MyContacts = new Dictionary<string, Contact>();

        public void AddContact(Contact Name)
        {
            MyContacts.Add(Name.Email, Name);
        }

        public Contact GetByEmail(string Email)
        {
            return MyContacts[Email];
        }
    }
}