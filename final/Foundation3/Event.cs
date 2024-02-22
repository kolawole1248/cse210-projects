using System;

public class Event
{
    public string EventTitle { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    public virtual string GetEventDetails()
    {
        return $"Event Title: {EventTitle}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address.GetFullAddress()}";
    }

    public virtual string GetMarketingMessage()
    {
        return $"Short description: {GetType().Name} - {EventTitle} on {Date.ToShortDateString()}";
    }
}
