using System;
using System.Collections.Generic;

namespace WoffuKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("START!");

            IList<Allocation> allocations = new List<Allocation>{
                new Allocation { Name = "FreeDisposal", DaysToExpiration = 20, Availability = 19 },
                new Allocation { Name = "HomeWork", DaysToExpiration = 12, Availability = 1 },
                new Allocation { Name = "Vacation", DaysToExpiration = 15, Availability = 7 },
                new Allocation { Name = "Sickness", DaysToExpiration = 0, Availability = 25 },
                new Allocation { Name = "RemoteWork", DaysToExpiration = 15, Availability = 2 },
				// this compensated allocation does not work properly yet
				new Allocation { Name = "Compensated FreeDisposal", DaysToExpiration = 20, Availability = 18 }
            };

            var app = new Woffu(allocations);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, expiration, availability");
                for (var j = 0; j < allocations.Count; j++)
                {
                    System.Console.WriteLine(allocations[j].Name + ", " + allocations[j].DaysToExpiration + ", " + allocations[j].Availability);
                }
                Console.WriteLine("");
                app.UpdateAvailability();
            }
        }
    }
}
