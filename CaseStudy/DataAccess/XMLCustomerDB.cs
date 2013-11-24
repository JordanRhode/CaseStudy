using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.Xml;

namespace CaseStudy.DataAccess
{
    public class XMLCustomerDB
    {
        private const string path = @"..\..\DataAccess\CustomerData.xml";

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            
            XmlTextReader reader = new XmlTextReader(path);
            while (reader.Read())
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);
                XmlNodeList xmlCustomers = xmlDoc.GetElementsByTagName("customer");
                for (int i = 0; i < xmlCustomers.Count; i++)
                {
                    long? customerID = null;
                    long? personID = null;
                    Customer.Types customerType = Customer.Types.Unknown;
                    Customer.PersonTypes personType = Person.PersonTypes.Customer;
                    string firstName = "";
                    string lastName = "";
                    DateTime? dob = null;
                    long? addressID = null;
                    string street = "";
                    string city = "";
                    string state = "";
                    int? zip = null;
                    foreach (XmlAttribute attribute in xmlCustomers[i].Attributes)
                    {
                        switch (attribute.Name)
                        {
                            case "id":
                                customerID = long.Parse(attribute.Value);
                                break;
                            case "personID":
                                personID = long.Parse(attribute.Value);
                                break;
                            case "customerType":
                                customerType = (Customer.Types)Enum.Parse(typeof(Customer.Types), attribute.Value);
                                break;
                            case "personType":
                                personType = (Person.PersonTypes)Enum.Parse(typeof(Person.PersonTypes), attribute.Value);
                                break;
                            default:
                                break;
                        }
                    }

                    foreach(XmlNode node in xmlCustomers[i].ChildNodes)
                    {
                        switch (node.Name)
                        {
                            case "name":
                                foreach(XmlNode childNode in node.ChildNodes)
                                {
                                    if (childNode.Name == "firstname")
                                    {
                                        firstName = childNode.InnerText;
                                    }
                                    else
                                    {
                                        lastName = childNode.InnerText;
                                    }
                                }
                                break;
                            case "dob":
                                dob = DateTime.Parse(node.InnerText);
                                break;
                            case "address":
                                XmlAttribute attribute = node.Attributes[0];
                                addressID = long.Parse(attribute.Value);
                                foreach (XmlNode childNode in node.ChildNodes)
                                {
                                    switch (childNode.Name)
                                    {
                                        case "street":
                                            street = childNode.InnerText;
                                            break;
                                        case "city":
                                            city = childNode.InnerText;
                                            break;
                                        case "state":
                                            state = childNode.InnerText;
                                            break;
                                        case "zipcode":
                                            zip = int.Parse(childNode.InnerText);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    Address address = new Address(addressID, street, city, state, zip);
                    Customer customer = new Customer(customerID, customerType, personID, firstName, lastName, dob, personType);
                    customer.SetAddress(address);
                    customers.Add(customer);
                }
            }
            reader.Close();
            return customers;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create(path, settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("products");
            foreach (Customer customer in customers)
            {
                xmlOut.WriteStartElement("customer");
                xmlOut.WriteAttributeString("id", customer.CustomerID.Value.ToString());
                xmlOut.WriteAttributeString("personID", customer.PersonID.Value.ToString());
                xmlOut.WriteAttributeString("personType", customer.Type.ToString());
                xmlOut.WriteAttributeString("customerType", customer.PersonType.ToString());
                xmlOut.WriteStartElement("name");
                xmlOut.WriteElementString("firstname", customer.FirstName);
                xmlOut.WriteElementString("lastname", customer.LastName);
                xmlOut.WriteEndElement();
                xmlOut.WriteElementString("dob", customer.DateOfBirth.Value.ToString());
                xmlOut.WriteStartElement("address");
                xmlOut.WriteAttributeString("id", customer.Address.AddressID.Value.ToString());
                xmlOut.WriteElementString("street", customer.Address.Street);
                xmlOut.WriteElementString("city", customer.Address.City);
                xmlOut.WriteElementString("state", customer.Address.State);
                xmlOut.WriteElementString("zipcode", customer.Address.Zip.Value.ToString());
                xmlOut.WriteEndElement();
                xmlOut.WriteEndElement();
            }
            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();
            xmlOut.Close();
        }
    }
}
