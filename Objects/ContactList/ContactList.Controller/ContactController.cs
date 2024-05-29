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
            //Check if implemented correctly
            Contact[] allContacts = repository.RetreiveAllContacts();

            for (int i = 0; i < allContacts.Length; i++)
            {
                userInterface.DisplayContact(allContacts[i]);
            }
        }

        private void SearchContact()
        {
            //Remove this line when you start implementing action method
            Console.WriteLine("This action is not implemented yet.");
        }

        private void UpdateContact()
        {
            //Remove this line when you start implementing action method
            Console.WriteLine("This action is not implemented yet.");
        }

        private void DeleteContact()
        {
            //Remove this line when you start implementing action method
            Console.WriteLine("This action is not implemented yet.");
        }
    }
}
