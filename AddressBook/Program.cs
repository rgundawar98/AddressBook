using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AddressBook System");
            AddressBook addressBook = new AddressBook();
            while(true)
            {
                Console.WriteLine("Choose the option from below");
                Console.WriteLine("1.Create Contact\n2.Display Contact\n3.Edit Contact\n4.Delete Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        addressBook.Details(); //UC1_CreateContact
                        break;
                    case 2:
                        addressBook.Display(); //AddNewContact
                        break;
                    case 3:
                        addressBook.EditContact(); //EditExistingContact
                        break;
                    case 4:
                        addressBook.Delete(); //DeleteContact
                        break;
                }   
            }
        }
    }
}
