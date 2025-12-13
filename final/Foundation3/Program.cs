using System;
using System.Collections.Generic;

// CSE 210 – Programming with Classes
// Final Project: Foundation 4 Option
// This project uses the Foundation 4 final project option, which consists of
// four separate programs demonstrating the core principles of object oriented
// programming: Abstraction, Encapsulation, Inheritance, and Polymorphism.

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Event> eventsList = new List<Event>();

            Address address1 = new Address("1 Thousand Sunny Dock", "Water 7", "Grand Line", "Japan");
            Lecture lecture = new Lecture(
                "Haki Basics Training",
                "Rayleigh teaches the fundamentals of Haki.",
                "12/02/2025",
                "6:00 PM",
                address1,
                "Silvers Rayleigh",
                120
            );

            Address address2 = new Address("99 Baratie Pier", "Baratie", "East Blue", "USA");
            Reception reception = new Reception(
                "Straw Hat Crew Reception",
                "Food, music, and crew introductions.",
                "12/05/2025",
                "7:30 PM",
                address2,
                "rsvp@baratie.com"
            );

            Address address3 = new Address("777 Wano Field", "Wano", "New World", "Japan");
            OutdoorGathering outdoor = new OutdoorGathering(
                "Wano Night Festival",
                "Outdoor festival with lanterns and fireworks.",
                "12/10/2025",
                "8:00 PM",
                address3,
                "Clear skies with cold wind"
            );

            eventsList.Add(lecture);
            eventsList.Add(reception);
            eventsList.Add(outdoor);

            for (int i = 0; i < eventsList.Count; i++)
            {
                Event e = eventsList[i];

                Console.WriteLine("STANDARD DETAILS");
                Console.WriteLine(e.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("FULL DETAILS");
                Console.WriteLine(e.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("SHORT DESCRIPTION");
                Console.WriteLine(e.GetShortDescription());
                Console.WriteLine("\n---------------------------------\n");
            }
        }
    }
}
