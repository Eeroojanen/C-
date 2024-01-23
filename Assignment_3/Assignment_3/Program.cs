using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList ConcertArray = new ArrayList();

            Concert concert1 = new Concert("Vasafest", "Vaasa", 2023,"17:00", 200);
            Concert concert2 = new Concert("Provinssirock", "Seinäjoki", 2022, "15.00", 200);
            Concert concert3 = new Concert("Weekend Festival", "Helsinki", 2018, "14.00", 900);
            Concert concert4 = new Concert("RuisRock", "Turku", 2016, "20:30", 400);
            Concert concert5 = new Concert("TampereFest", "Tampere", 2015, "13:00", 800);

            ConcertArray.Add(concert1);
            ConcertArray.Add(concert2);
            ConcertArray.Add(concert3);
            ConcertArray.Add(concert4);
            ConcertArray.Add(concert5);

            //Sorting array
            Concert.Sort(ConcertArray);
            //Printing the concent of array
            foreach (Concert concert in ConcertArray) 
            { 
                Console.WriteLine(concert);
            }

            Console.WriteLine("Are the concert1 and concert2 prices equal? " + concert1.Price().Equals(concert2.Price()));
            Console.WriteLine("Is concer 5 cheaper? " + (concert5 < concert4));
            Console.WriteLine("Is the concert 3 more expensive ?" + (concert3 > concert4));
            Console.WriteLine("Increase the concert4 price of by 5 units " + (++concert4));
            Console.WriteLine("Decrease the concert3 price of by 5 units " + (--concert3));

            
        }

    }
}
