using System;


class Address {
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public Address (string StreetAddress, string City, string State, string Country) {
        _streetAddress = StreetAddress;
        _city = City;
        _state = State;
        _country = Country;
    }


    public bool IsInUSA(){
        return _country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }

}