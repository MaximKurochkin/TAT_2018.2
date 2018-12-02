using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DEV_8
{ 
    /// <summary>
    /// Class XMLParser
    /// parses xml-file
    /// and returns list of objects
    /// </summary>
    class XMLParser
    {
        /// <summary>
        /// Method ToParseXMLWithCars
        /// parses xml-file
        /// and returns list of cars
        /// </summary>
        /// <param name="address">address of xml-file with data about cars</param>
        /// <returns>list of cars</returns>
        
        public List<Car> ToParseXMLWithCars(string address)
        {
            List<Car> cars = new List<Car>();
            string brand = String.Empty, model = String.Empty;
            int cost = 0, count = 0;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(address);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Brand")
                        brand = childnode.InnerText;

                    if (childnode.Name == "Model")
                        model = childnode.InnerText;

                    if (childnode.Name == "Count")
                        count = Int32.Parse(childnode.InnerText);

                    if (childnode.Name == "Cost")
                        cost = Int32.Parse(childnode.InnerText);
                }
                Car car = new Car(brand, model,count,cost);
                cars.Add(car);
            }   
            return cars;
        }

        /// <summary>
        /// Method ToParseXMLWithTrucks
        /// parses xml-file
        /// and returns list of trucks
        /// </summary>
        /// <param name="address">address of xml-file with data about trucks</param>
        /// <returns>list of trucks</returns>

        public List<Truck> ToPareXMLWithTrucks(string address)
        {
            List<Truck> trucks = new List<Truck>();
            string brand = String.Empty, model = String.Empty;
            int cost = 0, count = 0;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(address);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Brand")
                        brand = childnode.InnerText;

                    if (childnode.Name == "Model")
                        model = childnode.InnerText;

                    if (childnode.Name == "Count")
                        count = Int32.Parse(childnode.InnerText);

                    if (childnode.Name == "Cost")
                        cost = Int32.Parse(childnode.InnerText);
                }
                Truck truck = new Truck(brand, model, count, cost);
                trucks.Add(truck);
            }
            return trucks;
        }
    }
}

