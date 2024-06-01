public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public void SetAddress(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //bool????
    public bool CitizenStatus()
    {
        return _country == "USA" ? true : false;
    }

    public string SetAddress()
    {
        string address = _street + " " + _city + " " + _state + " " + _country;
        return address;
    }
}