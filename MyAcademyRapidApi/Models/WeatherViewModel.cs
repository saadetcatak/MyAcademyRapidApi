namespace MyAcademyRapidApi.Models
{
    public class WeatherViewModel
    {
        public class Rootobject
        {
            public Location location { get; set; }
           
        }

        public class Location
        {
            public string city { get; set; }
            public int woeid { get; set; }
            public string country { get; set; }
            public float lat { get; set; }
            public float _long { get; set; }
            public string timezone_id { get; set; }
        }


    }
}
