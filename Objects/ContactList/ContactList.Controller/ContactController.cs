using ContactList.Data;
using ContactList.Models;
using ContactList.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Controller
{
    public class ContactController
    {
        private UserInterface userInterface;
        private ContactRepository repository;

        public ContactController()
        {
            userInterface = new UserInterface();
            repository = new ContactRepository();
        }

        public void Run()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                int menuChoice = userInterface.ShowMenuAndGetUserChoice();

                switch (menuChoice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        ShowAllContacts();
                        break;
                    case 3:
                        SearchContact();
                        break;
                    case 4:
                        UpdateContact();
                        break;
                    case 5:
                        DeleteContact();
                        break;
                    case 6:
                        keepRunning = false;
                        break;
                }
            }
        }

        private void AddContact()
        {
            Contact newContact = userInterface.GetNewContactInformation();
            Contact addedContact = repository.CreateContact(newContact);

            if (addedContact != null)
            {
                userInterface.DisplayContact(addedContact);
                userInterface.ShowActionSuccess("Add Contact");
            }
            else
            {
                userInterface.ShowActionFail("Add Contact");
            }
        }

        private void ShowAllContacts()
        {
            int nullCounter = 0;
            Contact[] allContacts = repository.RetreiveAllContacts();
            int allContactsArrayLength = allContacts.Length;
            
            for (int i = 0; i < allContactsArrayLength; i++)
            {
                if (allContacts[i] == null)
                {
                    nullCounter++;
                }
                else
                {
                    userInterface.DisplayContact(allContacts[i]);
                }
            }

            if (nullCounter == allContactsArrayLength)
            {
                userInterface.DisplayEmptyContactList();
            }
        }

        private void SearchContact()
        {
            int contactID = userInterface.GetContactID("look up");
            Contact requestedContact = repository.RetrieveContactById(contactID);
            
            if (requestedContact == null)
            {
                userInterface.DisplayEmptyContact(contactID);
            }
            else
            {
                userInterface.DisplayContact(requestedContact);
            }
        }

        private void UpdateContact()
        {
            //Remove this line when you start implementing action method
            Console.WriteLine("This action is not implemented yet.");
        }

        private void DeleteContact()
        {
            int contactID = userInterface.GetContactID("delete");
            repository.DeleteContact(contactID);
            Contact requestedContact = repository.RetrieveContactById(contactID);

            if (requestedContact == null)
            {
                userInterface.ShowActionSuccess("Delete Contact");
            }
            else
            {
                userInterface.ShowActionFail("Delete Contact");
            }
        }
    }
}
