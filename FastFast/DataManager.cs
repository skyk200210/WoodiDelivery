using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FastFast
{
    class DataManager
    {
        //메뉴 및 고객 DataManager
        public static List<Product> Products = new List<Product>();
        public static List<Customer> Customers = new List<Customer>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                string productsOutput = File.ReadAllText(@"./Products.xml");
                XElement productXElement = XElement.Parse(productsOutput);
                Products = (from item in productXElement.Descendants("product")
                            select new Product()
                            {
                                Name = item.Element("name").Value,
                                Price = int.Parse(item.Element("price").Value),
                                Category = item.Element("category").Value
                            }).ToList<Product>();
                            
                string customerOutput = File.ReadAllText(@"./Customers.xml");
                XElement customerXElement = XElement.Parse(customerOutput);
                Customers = (from item in customerXElement.Descendants("customer")
                             select new Customer()
                             {
                                 Num = int.Parse(item.Element("num").Value),
                                 Name = item.Element("name").Value,
                                 Address = item.Element("address").Value,
                                 DetailAddress = item.Element("detailAddress").Value,
                                 Address2 = item.Element("address2").Value,
                                 DetailAddress2 = item.Element("detailAddress2").Value,
                                 PhoneNumber = item.Element("phoneNumber").Value,
                                 PhoneNumber2 = item.Element("phoneNumber2").Value,
                                 PhoneNumber3 = item.Element("phoneNumber3").Value
                             }).ToList<Customer>();
            }
            catch (FileNotFoundException exception)
            {
                Save();
            }
        }

        public static void Save()
        {
            string productsOutput = "";
            productsOutput += "<products>\n";
            foreach (var item in Products)
            {
                productsOutput += "<product>\n";
                productsOutput += " <name>" + item.Name + "</name>\n";
                productsOutput += " <price>" + item.Price + "</price>\n";
                productsOutput += " <category>" + item.Category + "</category>\n";
                productsOutput += "</product>\n";
            }
            productsOutput += "</products>";

            string customerOutput = "";
            customerOutput += "<customers>";
            foreach (var item in Customers)
            {
                customerOutput += "<customer>\n";
                customerOutput += " <num>" + item.Num + "</num>\n";
                customerOutput += " <name>" + item.Name + "</name>\n";
                customerOutput += " <address>" + item.Address + "</address>\n";
                customerOutput += " <detailAddress>" + item.DetailAddress + "</detailAddress>\n";
                customerOutput += " <address2>" + item.Address2 + "</address2>\n";
                customerOutput += " <detailAddress2>" + item.DetailAddress2 + "</detailAddress2>\n";
                customerOutput += " <phoneNumber>" + item.PhoneNumber + "</phoneNumber>\n";
                customerOutput += " <phoneNumber2>" + item.PhoneNumber2 + "</phoneNumber2>\n";
                customerOutput += " <phoneNumber3>" + item.PhoneNumber3 + "</phoneNumber3>\n";
                customerOutput += " <date>" + item.Date.ToLongDateString() + "</date>\n";
                customerOutput += "</customer>";
            }
            customerOutput += "</customers>";

            File.WriteAllText(@"./Products.xml", productsOutput);
            File.WriteAllText(@"./Customers.xml", customerOutput);
        }
    }
}
