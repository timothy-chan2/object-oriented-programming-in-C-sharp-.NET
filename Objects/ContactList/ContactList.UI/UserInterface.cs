using ContactList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.UI
{
    public class UserInterface
    {
        private UserIO userIO;

        public UserInterface()
        {
            userIO = new UserIO();
        }

        public int ShowMenuAndGetUserChoice()
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Show all contacts");
            Console.WriteLine("3. Look up contacts");
            Console.WriteLine("4. Edit contact");
            Console.WriteLine("5. Remove contact");
            Console.WriteLine("6. Exit program");
            int userChoice = userIO.ReadInt("Enter your choice as a number:", 1, 6);

            return userChoice;
        }

        public Contact GetNewContactInformation()
        {
            Contact contact = new Contact();

            contact.FirstName = userIO.ReadString("\nEnter the contact's first name: ");
            contact.LastName = userIO.ReadString("Enter the contact's last name: ");
            contact.PhoneNumber = userIO.ReadString("Enter the contact's phone number: ");
            contact.Email = userIO.ReadString("Enter the contact's email address: ");

            return contact;
        }

        public void DisplayContact(Contact contact)
        {
            Console.WriteLine($"\nContact ID: {contact.ContactID}");
            Console.WriteLine($"First name: {contact.FirstName}");
            Console.WriteLine($"Last name: {contact.LastName}");
            Console.WriteLine($"Phone number: {contact.PhoneNumber}");
            Console.WriteLine($"Email: {contact.Email}");
        }

        public void ShowActionSuccess(string actionName)
        {
            Console.WriteLine($"\n{actionName} executed successfully.");
        }

        public void ShowActionFail(string actionName)
        {
            Console.WriteLine($"\n{actionName} failed to execute.");
        }
    }
}
