using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_V
{
    internal class Program
    {
        private static string name;
        private static string type;
        private static string location;
        private static double price;
        private static DateTime date;

        private static int options;
        private static bool parseAttempt;

        static void Main(string[] args)
        {

        // Create an instance of CustomEventHandler to manage events
        CustomEventHandler EventList = new CustomEventHandler();

        Console.WriteLine(EventList.HandleEvent(EventList.AddEvent, "Marathon", "Running", "Florida", DateTime.Parse("2022-02-12"), 70));
        Console.WriteLine(EventList.HandleEvent(EventList.AddEvent, "Super bowl", "Football", "Miami", DateTime.Parse("2020-02-2"), 500));
        Console.WriteLine(EventList.HandleEvent(EventList.AddEvent, "Wimbledon", "Tennis", "France", DateTime.Parse("2019-08-19"), 150));

            while(true)
            {
                Console.WriteLine("Select option: \n 0) Eventlist \n 1) Display logs from events \n 2) Search event \n 3) Update eventlist \n 4) Delete event \n 5) Close program");
                parseAttempt = int.TryParse(Console.ReadLine(), out options);
                if(parseAttempt)
                {
                    switch(options)
                    {
                        case 0:
                            Console.WriteLine("\nListing all events:");
                            Console.WriteLine(EventList.PrintList());
                            break;
                        case 1:
                            Console.WriteLine("\nLog of events:\n" + CustomEventHandler.GetLog());
                            break;
                        case 2:
                            Console.WriteLine("\nEnter event details (minimum of 1 detail needed): ");
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Type: ");
                            type = Console.ReadLine();
                            Console.Write("Location: ");
                            location = Console.ReadLine();
                            Console.Write("Date (yyyy-MM-dd): ");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime SearchedTime))
                            {
                                date = SearchedTime;
                            }
                            Console.Write("Price:");
                            if (double.TryParse(Console.ReadLine(), out double SearchedPrice))
                            {
                                price = SearchedPrice;
                            }
                            string searchResult = EventList.HandleEvent(EventList.SearchEvent, name, type, location, date, price);
                            Console.WriteLine("\nresult: ");
                            Console.WriteLine(searchResult);
                            break;
                        case 3:
                            Console.WriteLine("Name of the event to be updated");
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("\nEnter details to update (minimum of 1 detail needed)");
                            Console.Write("Type: ");
                            type = Console.ReadLine();
                            Console.Write("Location: ");
                            location = Console.ReadLine();
                            Console.Write("Date (yyyy-MM-dd): ");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime UpdateTime))
                            {
                                date = UpdateTime;
                            }
                            Console.Write("Price: ");
                            if (double.TryParse(Console.ReadLine(), out double UpdatePrice))
                            {
                                price = UpdatePrice;
                            }
                            string UpdateResult = EventList.HandleEvent(EventList.UpdateEvent, name, type, location, date, price);
                            Console.WriteLine(UpdateResult);
                            break;
                        case 4:
                            Console.WriteLine("\nEnter event details to remove the matching event (minimum of 1 detail needed)");
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Type: ");
                            type = Console.ReadLine();
                            Console.Write("Location: ");
                            location = Console.ReadLine();
                            Console.Write("Date (yyyy-MM-dd): ");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime DeleteTime))
                            {
                                date = DeleteTime;
                            }
                            Console.Write("Price: ");
                            if (double.TryParse(Console.ReadLine(), out double DeletePrice))
                            {
                                price = DeletePrice;
                            }
                            string DeleteResult = EventList.HandleEvent(EventList.DeleteEvent, name, type, location, date, price);

                            Console.WriteLine(DeleteResult);
                            break;
                        case 5:
                            Console.WriteLine("Exiting...");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input. Give a one of the given options");
                            break;
                    }       
                }
                else
                {
                    Console.WriteLine("Invalid input. Give another input");
                }

            }
        }
    }
}
