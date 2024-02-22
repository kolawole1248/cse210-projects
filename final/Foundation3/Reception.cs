using System;

public class ReceptionEvent : Event
{
    public string RsvpEmail { get; set; }
    
    public override string GetEventDetails()
    {
        return base.GetEventDetails() + $"\nRSVP Email: {RsvpEmail}";
    }
}
