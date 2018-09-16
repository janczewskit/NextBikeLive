using Newtonsoft.Json;
using System.Collections.Generic;

namespace NextBikeLive.Model
{
    public class Place
    {
        [JsonProperty("uid")]
        public int Id { get; set; }

        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lng")]
        public float Longitude { get; set; }

        [JsonProperty("bike")]
        public bool Bike { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("spot")]
        public bool Spot { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("bikes")]
        public int BikesCount { get; set; }

        [JsonProperty("bike_racks")]
        public int BikeRacks { get; set; }

        [JsonProperty("free_racks")]
        public int FreeRacks { get; set; }

        [JsonProperty("maintenance")]
        public bool Maintenance { get; set; }

        [JsonProperty("terminal_type")]
        public string TerminalType { get; set; }

        [JsonProperty("bike_list")]
        public Bike[] Bikes { get; set; }

        [JsonProperty("bike_numbers")]
        public string[] BikeNumbers { get; set; }

        [JsonProperty("bike_types")]
        public Dictionary<string,string> BikeTypes { get; set; }

        [JsonProperty("place_type")]
        public string Type { get; set; }

        [JsonProperty("rack_locks")]
        public bool RackLocks { get; set; }

        [JsonProperty("no_registration")]
        public bool NoRegistration { get; set; }
    }
}
