using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_V
{
    internal class CustomEventHandler
    {
        private SortedList<CustomEvent, string> Events = new SortedList<CustomEvent, string>();
        private static StringBuilder log = new StringBuilder("Log: " + DateTime.Now.ToString() + "\n");

        // Method to handle events using a delegate
        public string HandleEvent(EventDelegate newEvents, string name, string type, string location, DateTime date, double price)
        {
            return newEvents(name, type, location, date, price);
        }

        // Method to add a new event to the list
        public string AddEvent(string name, string type, string location, DateTime date, double price)
        {
            CustomEvent newEvent = new CustomEvent(name, type, location, date, price);
            Events.Add(newEvent, newEvent.Name);
            log.Append($"New event {name} added at {DateTime.Now}");
            string message = $"New event added {name} to list. All events now {Events.Count}";
            return message;
        }

        // Method to search for an event based on specified criteria
        public string SearchEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach(var event1 in Events.Keys)
            {
                if (event1.Name.Equals(name) || event1.Type().Equals(type) || event1.Location().Equals(location) || event1.Date().Equals(date) || event1.Price() == price)
                {
                    log.AppendLine("Searched for an event.");
                    return event1.ToString();
                }
            }
            return null;
        }

        // Method to update an existing event
        public string UpdateEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach(var event1 in Events.Keys)
            {
                if (event1.Name.Equals(name))
                {
                    CustomEvent UpdatedEvents = new CustomEvent(name, type, location, date, price);
                    Events.Remove(event1);
                    Events[UpdatedEvents] = UpdatedEvents.Name;
                    string UpdateMessage = $"\nEvent's old information has been updated: \n{event1}\n";
                    log.AppendLine($"The event {name} was updated.");
                    return UpdateMessage;
                }
            }
            return null;
        }

        // Method to delete an event based on specified criteria
        public string DeleteEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach (var DeleteEvent in Events.Keys)
            {
                if (DeleteEvent.Name.Equals(name) || DeleteEvent.Type().Equals(type) || DeleteEvent.Location().Equals(location) || DeleteEvent.Date().Equals(date) || DeleteEvent.Price() == price)
                {
                    Events.Remove(DeleteEvent);
                    string RemovedMessage = "\n Matching event has been removed from list";
                    log.AppendLine("Event deleted");
                    return RemovedMessage;
                }
            }
            return null;
        }

        // Method to print the list of events
        public string PrintList()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var EventList  in Events)
            {
                sb.AppendLine($"{EventList.Key}");
            }
            log.AppendLine("Events has been listed");
            return sb.ToString();
        }

        // Static method to get the log
        public static string GetLog()
        {
            return log.ToString();
        }
    }
}
