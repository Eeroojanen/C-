using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Program
    {
        static bool parsing;
        static int choose;
        static void Main(string[] args)
        {
            FlightCompany flightCompany = new FlightCompany();

            flightCompany[0] = new Flight(100, "Helsinki", "Oslo", "12.10.2023", 250.00);
            flightCompany[1] = new Flight(153, "Helsinki", "Stockholm", "19.9.2024", 100.00);
            flightCompany[2] = new Flight(176, "Helsinki", "Italy", "6.6.2024", 550.00);
            flightCompany[3] = new Flight(254, "Helsinki", "Madrid", "1.1.2025", 50.00);

            //flightCompany.SortFlightsByPrice();

            while (true)
            {
                Console.WriteLine("Select option");
                Console.WriteLine(" 0) Display fligths \n 1) Search flight's ID \n 2) Find cheapest flight \n 3) Find most expensive flight \n 4) Exit program");
                parsing = int.TryParse(Console.ReadLine(), out choose);
                if (parsing)
                {
                    switch (choose)
                    {
                        case 0:
                            flightCompany.PrintFlights();
                            Console.WriteLine("\n");
                            break;
                        case 1:
                            Console.WriteLine("Give fligth id ");
                            int FoundFlightId = Convert.ToInt32(Console.ReadLine());
                            Flight FindFligth = flightCompany[FoundFlightId];
                            Console.WriteLine(FindFligth.ToString());
                            break;
                        case 2:
                            Console.WriteLine("Cheapest flight ");
                            Flight cheapestFlight = flightCompany.CheapestFlight();
                            Console.WriteLine(cheapestFlight);
                            Console.WriteLine("\n");
                            break;
                        case 3:
                            Console.WriteLine("Most expensive flight ");
                            Flight MostExpensiveFlight = flightCompany.MostExpensiveFlight();
                            Console.WriteLine(MostExpensiveFlight);
                            Console.WriteLine("\n");
                            break;
                        case 4:
                            Console.WriteLine("Close program");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}
