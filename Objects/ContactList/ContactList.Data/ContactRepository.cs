﻿using ContactList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Data
{
    public class ContactRepository
    {
        Contact[] contacts;

        public ContactRepository()
        {
            contacts = new Contact[10];

            Contact contact1 = new Contact();
            contact1.ContactID = 0;
            contact1.FirstName = "Bill";
            contact1.LastName = "Gates";
            contact1.PhoneNumber = "607-123-4567";
            contact1.Email = "bill.gates@ms.com";

            contacts[0] = contact1;

            Contact contact2 = new Contact();
            contact2.ContactID = 1;
            contact2.FirstName = "Elon";
            contact2.LastName = "Musk";
            contact2.PhoneNumber = "706-765-4321";
            contact2.Email = "elon.musk@spacex.com";

            contacts[1] = contact2;
        }

        public Contact CreateContact(Contact contact, int[] saveIndexArray = null)
        {
            if (saveIndexArray == null)
            {
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] == null)
                    {
                        contact.ContactID = i;
                        contacts[i] = contact;

                        return contact;
                    }
                }
            }
            else
            {
                contact.ContactID = saveIndexArray[0];
                contacts[saveIndexArray[0]] = contact;

                return contact;
            }

            // If the contacts array is already full then the new contact will not be created
            return null;
        }

        public Contact[] RetreiveAllContacts()
        {
            return contacts;
        }

        public Contact RetrieveContactById(int contactID)
        {
            return contacts[contactID];
        }

        public void DeleteContact(int contactID)
        {
            contacts[contactID] = null;
        }

        public Contact EditContact(Contact contact, int saveIndex)
        {
            DeleteContact(saveIndex);
            int[] saveIndexArray = { saveIndex };
            Contact updatedContact = CreateContact(contact, saveIndexArray);

            return updatedContact;
        }
    }
}
