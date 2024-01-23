using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_V
{
    internal class CustomEvent : IComparable<CustomEvent>
    {
        private readonly string name;
        private string type;
        private string location;
        private DateTime date;
        private double price;

        public CustomEvent() {

        }

        public CustomEvent(string name, string type, string location, DateTime date, double price)
        {
            this.name = name;
            this.type = type;
            this.location = location;
            this.date = date;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
        }

        public string Type()
        {
             return type; 
        }

        public string Location()
        { 
            return location;
        }
        public DateTime Date()
        {
            return date;
        }

        public double Price()
        { 
             return price;
        }

        // Override ToString method to provide a string representation of the object
        public override string ToString()
        {
            return "Name: " + name + "\nType: " + type + "\nLocation: " + location + "\nDate: " + date + "\nPrice: " + price + "\n";
        }

        // Implementation of the IComparable interface to compare events based on their names
        public int CompareTo(CustomEvent obj)
        {
            if (obj == null)
            {
                return 0;
            }
            if (obj is CustomEvent)
            {
                CustomEvent temp = (CustomEvent)obj;
                return Name.CompareTo(temp.Name);
            }
            else
            {
                return 0;
            }
        }
    }
}
