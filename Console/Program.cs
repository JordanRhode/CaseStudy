using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //For the purpose of having a 1..1 relationship, I made address and person a 1..1 relationship
            //even though it won't be in my final project

            //Address address1 = new Address(1234, "1234 Rocky Rd", "Stevens Point", "WI", 54481);
            //Customer customer1 = new Customer(12321, Customer.Types.ResponsibleParty, 11111, "Joe", "Bob", DateTime.Today, cu);
            //customer1.SetAddress(address1);

            //Address address2 = new Address(1122, "1231 Birch Rd", "Stevens Point", "WI", 54481);
            //Customer customer2 = new Customer(13453, Customer.Types.Customer, 12765, "Andrew", "Richards", DateTime.Today);
            //customer2.SetAddress(address2);

            //Address address3 = new Address(2356, "2499 Funny Rd", "Stevens Point", "WI", 54481);
            //Customer customer3 = new Customer(76543, Customer.Types.Customer, 45786, "Sally", "Smith", DateTime.Today);
            //customer3.SetAddress(address3);

            //Address address4 = new Address(6789, "1314 Steel Dr", "Stevens Point", "WI", 54481);
            //Customer customer4 = new Customer(6978, Customer.Types.Customer, 6789, "Andrew", "Davis", DateTime.Today);
            //customer4.SetAddress(address4);

            ////Example of 1..* relationship. customer1 has many dependants, each dependant is associated with customer1
            //customer1.AddDependant(customer2);
            //customer1.AddDependant(customer3);
            //customer1.AddDependant(customer4);

            //Console.WriteLine("1..1 Relationship");
            //Console.WriteLine(string.Format("Customer: {0} is associated with address: {1}",
            //                                customer1.FullName, customer1.Address.ToString()));
            //Console.WriteLine();
            //Console.WriteLine(string.Format("Address: {0} is associated with the customer: {1}",
            //                                address1.ToString(), address1.User.FullName));

            //Console.WriteLine();
            //Console.WriteLine("1..* Relationships");
            //Console.WriteLine(string.Format("{0} is associated with these customers: ", customer1.FullName));
            //foreach (Customer dependant in customer1.Dependants)
            //{
            //    Console.WriteLine(dependant.FullName);
            //}
            //Console.WriteLine();
            //Console.WriteLine("These dependants are shown with their responsible party");
            //Console.WriteLine(string.Format("Customer: {0}  Responsible Party: {1}",
            //                  customer2.FullName, customer2.ResponsibleParty.FullName));
            //Console.WriteLine();
            //Console.WriteLine(string.Format("Customer: {0}  Responsible Party: {1}",
            //                  customer3.FullName, customer3.ResponsibleParty.FullName));
            //Console.WriteLine();
            //Console.WriteLine(string.Format("Customer: {0}  Responsible Party: {1}",
            //                  customer4.FullName, customer4.ResponsibleParty.FullName));
            //Console.ReadLine();
        }
    }
}
