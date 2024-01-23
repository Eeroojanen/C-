using Assignment_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class FlightCompany
    {
        // Constructor for the FlightCompany class.
        public FlightCompany()
        {

        }


        private SortedList<Flight, double> flights = new SortedList<Flight, double>();

        // Read-only property to store the airline name.
        private readonly string airlineName;

        // Indexer to access Flight objects by their ID.
        public Flight this[int id]
        {
            get
            {
                return FindFlight(id);

            }
            set
            {
                flights.Add(value, value.Price); // Add a Flight to the SortedList with its price.
            }
        }


        // Method to print the list of flights.
        public void PrintFlights()
        {
            foreach (var flight in flights.Keys)
            {
                Console.WriteLine(flight.ToString());
            }
        }

        //// Method to find a flight by its ID.
        public Flight FindFlight(int id)
        {
            foreach (var f in flights)
            {
                if (f.Key.ID == id)
                {
                    return f.Key;
                }
            }
            return null;
            }

            // Method to find the cheapest flight in the list.
            public Flight CheapestFlight()
        {
            return flights.Keys[0];
        }

        // Method to find the most expensive flight in the list.
        public Flight MostExpensiveFlight()
        {
            return flights.Keys[flights.Count() - 1];
        }
    }
}
