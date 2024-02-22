using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Event> events = new List<Event>();

        // Create instances of different event types
        Event lectureEvent = new LectureEvent
        {
            EventTitle = "Programming Lecture",
            Description = "Learn about programming",
            Date = DateTime.Now.AddDays(7),
            Time = "3:00 PM",
            Address = new Address("456 University Ave", "Tech City", "CA", "USA"),
            Speaker = "John Doe",
            Capacity = 100
        };

        Event receptionEvent = new ReceptionEvent
        {
            EventTitle = "Tech Meetup",
            Description = "Networking and discussions",
            Date = DateTime.Now.AddDays(14),
            Time = "6:00 PM",
            Address = new Address("789 Tech Blvd", "Innovation Town", "CA", "USA"),
            RsvpEmail = "techmeetup@example.com"
        };

        // Add events to the list
        events.Add(lectureEvent);
        events.Add(receptionEvent);

        // Display event details and marketing messages
        foreach (var evt in events)
        {
            Console.WriteLine(evt.GetEventDetails());
            Console.WriteLine(evt.GetMarketingMessage());
            Console.WriteLine();
        }
    }
}
