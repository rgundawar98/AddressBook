using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        List<ContactDetails> contact = new List<ContactDetails>();
        public void Details()
        {
            ContactDetails details = new ContactDetails();
            Console.WriteLine("Enter the details of the person");
            Console.WriteLine("Enter the first name");
            details.FirstName= Console.ReadLine();
            Console.WriteLine("Enter the last name");
            details.LastName= Console.ReadLine();
            Console.WriteLine("Enter the address");
            details.Address= Console.ReadLine();
            Console.WriteLine("Enter the city");
            details.City= Console.ReadLine();
            Console.WriteLine("Enter the state");
            details.State= Console.ReadLine();
            Console.WriteLine("Enter the zipcode");
            details.ZipCode = Convert.ToInt64(Console.ReadLine());  
            Console.WriteLine("Enter the MobileNumber");
            details.MobileNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the email");
            details.Email= Console.ReadLine();
            contact.Add(details);
        }
        public void Display() //UC2
        {
            foreach(ContactDetails data in contact) //foreach loop to display fields
            {
                Console.WriteLine("Details of the person in addressbook");
                Console.WriteLine("FirstName:"+data.FirstName);
                Console.WriteLine("LastName:"+data.LastName);
                Console.WriteLine("Address:" + data.Address);
                Console.WriteLine("City:" + data.City);
                Console.WriteLine("State:" + data.State);
                Console.WriteLine("ZipCode:" + data.ZipCode);
                Console.WriteLine("MobileNumber:" + data.MobileNumber);
                Console.WriteLine("Email:" + data.Email);
            }
        }
        public void EditContact()
        {
            foreach(var Data in contact)
            {
                if(contact.Contains(Data))
                {
                    Console.WriteLine("1.FirstName:\n2.LastName:\n3.Address:\n4.City:\n5.State:\n6.ZipCode:\n7.MobileNumber:\n8.Email:");
                    Console.WriteLine("Update your option");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                            string Fname = Console.ReadLine();
                            Data.FirstName = Fname;
                            break;
                        case 2:
                            string Lname = Console.ReadLine();
                            Data.LastName = Lname;
                            break;
                        case 3:
                            string address = Console.ReadLine();
                            Data.Address = address;
                            break;
                        case 4:
                            string city = Console.ReadLine();
                            Data.City = city;
                            break;
                        case 5:
                            string state = Console.ReadLine();
                            Data.State = state;
                            break;
                        case 6:
                            long pinCode = Convert.ToInt64(Console.ReadLine());
                            Data.ZipCode = pinCode;
                            break;
                        case 7:
                            long MobileNo = Convert.ToInt64(Console.ReadLine());
                            Data.MobileNumber = MobileNo;
                            break;
                        case 8:
                            string email = Console.ReadLine();
                            Data.Email = email;
                            break;
                    }
                    Console.WriteLine("FirstName:{0}\nLastName:{1}\nAddress:{2}\nCity:{3}\nState:{4}\nZipCode:{5}\nMobileNumber:{6}\nEmail{7}",Data.FirstName,Data.LastName,
                        Data.Address,Data.City,Data.State,Data.ZipCode,Data.MobileNumber,Data.Email);
                }
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter the name to delete contact");
            string Fname = Console.ReadLine();
            foreach(var Data1 in contact)
            {
                if(Data1.FirstName == Fname)
                {
                    contact.Remove(Data1);
                    Console.WriteLine("Contact Successfully removed");
                }
                else
                {
                    Console.WriteLine("Contact not present");
                }
            }
        }
    }
}
