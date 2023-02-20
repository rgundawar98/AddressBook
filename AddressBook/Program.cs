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
                Console.WriteLine("1.CreateContact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        addressBook.Details();
                        break;
                }
                break;
            }
        }
    }
}
