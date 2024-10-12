using System.Diagnostics.Metrics;

public class Adress
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    

    public Adress(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool isInUsa()
    {
        return _country.ToLower() == "usa";
    }

    public string fullAdress()
    {
        return $"{_street}, {_city}\n{_state}, {_country}";
    }

}