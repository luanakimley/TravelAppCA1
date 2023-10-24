﻿
public class AirportRootobject
{
    public Request request { get; set; }
    public Airport[] response { get; set; }
    public string terms { get; set; }
}

public class Request
{
    public string lang { get; set; }
    public string currency { get; set; }
    public int time { get; set; }
    public string id { get; set; }
    public string server { get; set; }
    public string host { get; set; }
    public int pid { get; set; }
    public Key key { get; set; }
    public Params _params { get; set; }
    public int version { get; set; }
    public string method { get; set; }
    public Client client { get; set; }
}

public class Key
{
    public int id { get; set; }
    public string api_key { get; set; }
    public string type { get; set; }
    public DateTime expired { get; set; }
    public DateTime registered { get; set; }
    public int limits_by_hour { get; set; }
    public int limits_by_minute { get; set; }
    public int limits_by_month { get; set; }
    public int limits_total { get; set; }
}

public class Params
{
    public string iata_code { get; set; }
    public string _fields { get; set; }
    public string lang { get; set; }
}

public class Client
{
    public string ip { get; set; }
    public Geo geo { get; set; }
    public Connection connection { get; set; }
    public Device device { get; set; }
    public Agent agent { get; set; }
    public Karma karma { get; set; }
}

public class Geo
{
    public string country_code { get; set; }
    public string country { get; set; }
    public string continent { get; set; }
    public string city { get; set; }
    public float lat { get; set; }
    public float lng { get; set; }
    public string timezone { get; set; }
}

public class Connection
{
    public string type { get; set; }
    public int isp_code { get; set; }
    public string isp_name { get; set; }
}

public class Device
{
}

public class Agent
{
}

public class Karma
{
    public bool is_blocked { get; set; }
    public bool is_crawler { get; set; }
    public bool is_bot { get; set; }
    public bool is_friend { get; set; }
    public bool is_regular { get; set; }
}

public class Airport
{
    public string name { get; set; }
    public string iata_code { get; set; }
    public string icao_code { get; set; }
    public float lat { get; set; }
    public float lng { get; set; }
    public string country_code { get; set; }
    public string city { get; set; }
}
