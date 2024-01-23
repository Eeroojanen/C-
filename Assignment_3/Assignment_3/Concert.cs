using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3
{
    internal class Concert
    {
        string title;
        string location;
        int date;
        string time;
        double price;


        //Constructor for concert class
        public Concert(string title, string location, int date, string time, double price)
        {
            this.title = title;
            this.location = location;
            this.date = date;
            this.time = time;
            this.price = price;

        }

        //Return value of title field
        public string Title()
        {
            return this.title;
        }

        //Return value of price field
        public double Price()
        {
            return this.price;
        }

        public static void Sort(ArrayList concertArray)
        {
            // Loop through the elements in the concertArray
            for (int i = 0; i < concertArray.Count - 1; i++)
            {
                // Loop through the remaining unsorted elements
                for (int j = 0; j < concertArray.Count - i - 1; j++)
                {
                    // Compare two concerts by their price
                    Concert concertA = (Concert)concertArray[j];
                    Concert concertB = (Concert)concertArray[j + 1];

                    if (concertA.Price() > concertB.Price())
                    {
                        // Swap the concerts if they are out of order
                        concertArray[j] = concertB;
                        concertArray[j + 1] = concertA;
                    }
                }
            }
        }

        //Operator where we chech if prices are equal
        public static bool operator ==(Concert concert1, Concert concert2)
        {
            if (concert1.price.Equals(concert2.price) && concert1.price == concert2.price)
                return true;
            return false;
        }

        // Operator that checks if prices of two Concert objects are not equal
        public static bool operator !=(Concert concert1, Concert concert2)
        {
            if (!(concert1.price.Equals(concert2.price) && concert1.price == concert2.price))
                return true;
            return false;
        }


        //Operator where if check if the price is cheaper
        public static bool operator <(Concert concert5, Concert concert4)
        {
            if (concert5.price < concert4.price)
                return true;
            return false;
        }

        //Operator where if check if the price is higher
        public static bool operator >(Concert concert3, Concert concert4)
        {
            if (concert3.price > concert4.price)
                return true;
            return false;
        }

        //Operator where we add +5 unit to the price
        public static Concert operator ++(Concert concert)
          {
              concert.price += 5;
            return concert;
          }

        //Operator where we decrease -5 unit to the price
        public static Concert operator --(Concert concert)
          {
              concert.price -= 5;
            if (concert.price < 0)
                concert.price = 0;

            return concert;
          }

        public override string ToString()
        {
            return Title() + " " + location + " " + date + " " + time + " " + Price();
        }

    }
}
