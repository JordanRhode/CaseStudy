using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.DataAccess
{
    public class TextCustomerDB
    {
        private const string path = @"..\..\DataAccess\CustomerData.txt";

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Address address = new Address();
                Customer customer = new Customer();
                customer.CustomerID = long.Parse(columns[0]);
                customer.PersonID = long.Parse(columns[1]);
                customer.Type = (Customer.Types)Enum.Parse(typeof(Customer.Types), columns[2]);
                customer.PersonType = (Person.PersonTypes)Enum.Parse(typeof(Person.PersonTypes), columns[3]);
                customer.FirstName = columns[4];
                customer.LastName = columns[5];
                customer.DateOfBirth = DateTime.Parse(columns[6]);
                address.AddressID = long.Parse(columns[7]);
                address.Street = columns[8];
                address.City = columns[9];
                address.StateCode = columns[10];
                address.Zip = int.Parse(columns[11]);
                customer.SetAddress(address);
                customers.Add(customer);
            }
            textIn.Close();
            return customers;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach (Customer customer in customers)
            {
                textOut.Write(string.Format("{0}|", customer.CustomerID));
                textOut.Write(string.Format("{0}|", customer.PersonID));
                textOut.Write(string.Format("{0}|", customer.Type));
                textOut.Write(string.Format("{0}|", customer.PersonType));
                textOut.Write(string.Format("{0}|", customer.FirstName));
                textOut.Write(string.Format("{0}|", customer.LastName));
                textOut.Write(string.Format("{0}|", customer.DateOfBirth));
                textOut.Write(string.Format("{0}|", customer.Address.AddressID));
                textOut.Write(string.Format("{0}|", customer.Address.Street));
                textOut.Write(string.Format("{0}|", customer.Address.City));
                textOut.Write(string.Format("{0}|", customer.Address.StateCode));
                textOut.WriteLine(customer.Address.Zip);
            }
            textOut.Close();
        }
    }
}
