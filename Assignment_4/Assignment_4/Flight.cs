using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{

    internal class Flight : IComparable
    {

        private int id;
        private string origin;
        private string destination;
        private string date;
        private double price;

        
        public Flight()
        {

        }


        public Flight(int id, string origin, string destination, string date, double price)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.price = price;
        }

        // Properties to provide read-only access to the private fields.
        public int ID
        {
            get { return id; }
        }

        public string Origin
        {
            get { return origin; }
        }

        public string Destination
        {
            get { return destination; }
        }

        public string Date
        {
            get { return date; }
        }

        public double Price
        {
            get { return price; }
        }

        // Override ToString method to provide a string representation of the Flight object.
        public override string ToString()
        {
            return id + " " + origin + " " + destination + " " + date + " " + price;
        }

        // Implement the CompareTo method from the IComparable interface to compare Flight objects based on their prices.
        public int CompareTo(object obj)
        {
            if (obj == null) return 0;

            if (obj is Flight)
            {
                Flight temp = (Flight)obj;
                if (this.price > temp.price) return 1;          // Current Flight object has a higher price.
                else if (this.price < temp.price) return -1;    // Current Flight object has a lower price.
                return 0;                                       // Prices are equal.
            }
            return 0;                                           // If the object is not a Flight.
        }
    }
}
