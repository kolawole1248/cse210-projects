using System;

public class LectureEvent : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string GetEventDetails()
    {
        return base.GetEventDetails() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity} attendees";
    }
}
