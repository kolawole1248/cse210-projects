public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public bool IsInUSA()
    {
        return Country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{StreetAddress}, {City}, {StateProvince}, {Country}";
    }
}
