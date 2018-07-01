using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RailWaveTrack.Modal
{

    public class PNRRootobject
    {
        public To_Station to_station { get; set; }
        public int response_code { get; set; }
        public Reservation_Upto reservation_upto { get; set; }
        public From_Station from_station { get; set; }
        public object doj { get; set; }
        public int total_passengers { get; set; }
        public int debit { get; set; }
        public Journey_Class journey_class { get; set; }
        public Train train { get; set; }
        public Boarding_Point boarding_point { get; set; }
        public bool chart_prepared { get; set; }
        //public object[] passengers { get; set; }
        public List<Passenger> passengers { get; set; }

    }

    public class To_Station
    {
        public object name { get; set; }
        public object code { get; set; }
        public object lat { get; set; }
        public object lng { get; set; }
    }
    public class Passenger
    {
        public int no { get; set; }
        public string current_status { get; set; }
        public string booking_status { get; set; }
    }

    public class Reservation_Upto
    {
        public object name { get; set; }
        public object code { get; set; }
        public object lat { get; set; }
        public object lng { get; set; }
    }

    public class From_Station
    {
        public object name { get; set; }
        public object code { get; set; }
        public object lat { get; set; }
        public object lng { get; set; }
    }

    public class Journey_Class
    {
        public object name { get; set; }
        public object code { get; set; }
    }

    public class Train
    {
        public object name { get; set; }
        public object number { get; set; }
        public object[] classes { get; set; }
        public object[] days { get; set; }
    }

    public class Boarding_Point
    {
        public object name { get; set; }
        public object code { get; set; }
        public object lat { get; set; }
        public object lng { get; set; }
    }

}

 


