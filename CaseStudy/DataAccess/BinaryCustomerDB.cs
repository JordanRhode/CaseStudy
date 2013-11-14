using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.DataAccess
{
    public class BinaryCustomerDB
    {
        private const string path = @"..\..\DataAccess\CustomerData.dat";

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            BinaryReader binaryIn = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while (binaryIn.PeekChar() != -1)
            {
                Address address = new Address();
                Customer customer = new Customer();
                customer.CustomerID = long.Parse(binaryIn.ReadString());
                customer.PersonID = long.Parse(binaryIn.ReadString());
                customer.Type = (Customer.Types)Enum.Parse(typeof(Customer.Types), binaryIn.ReadString());
                customer.PersonType = (Person.PersonTypes)Enum.Parse(typeof(Person.PersonTypes), binaryIn.ReadString());
                customer.FirstName = binaryIn.ReadString();
                customer.LastName = binaryIn.ReadString();
                customer.DateOfBirth = DateTime.Parse(binaryIn.ReadString());
                address.AddressID = long.Parse(binaryIn.ReadString());
                address.Street = binaryIn.ReadString();
                address.City = binaryIn.ReadString();
                address.StateCode = binaryIn.ReadString();
                address.Zip = int.Parse(binaryIn.ReadString());
                customer.SetAddress(address);
                customers.Add(customer);
            }
            binaryIn.Close();
            return customers;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            BinaryWriter binaryOut = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach (Customer customer in customers)
            {
                binaryOut.Write(customer.CustomerID.ToString());
                binaryOut.Write(customer.PersonID.ToString());
                binaryOut.Write(customer.Type.ToString());
                binaryOut.Write(customer.PersonType.ToString());
                binaryOut.Write(customer.FirstName);
                binaryOut.Write(customer.LastName);
                binaryOut.Write(customer.DateOfBirth.ToString());
                binaryOut.Write(customer.Address.AddressID.ToString());
                binaryOut.Write(customer.Address.Street);
                binaryOut.Write(customer.Address.City);
                binaryOut.Write(customer.Address.StateCode);
                binaryOut.Write(customer.Address.Zip.ToString());
            }
            binaryOut.Close();
        }
    }
}
