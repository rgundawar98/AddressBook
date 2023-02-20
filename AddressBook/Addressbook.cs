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
        }
    }
}
