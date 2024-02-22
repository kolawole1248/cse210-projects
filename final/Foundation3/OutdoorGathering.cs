using System;

public class OutdoorEvent : Event
{
    public string WeatherForecast { get; set; }

    public override string GetEventDetails()
    {
        return base.GetEventDetails() + $"\nWeather Forecast: {WeatherForecast}";
    }
}
