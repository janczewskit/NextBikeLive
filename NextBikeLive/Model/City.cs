using Newtonsoft.Json;
using System.Collections.Generic;

namespace NextBikeLive.Model
{
    public class City
    {
        [JsonProperty("uid")]
        public int Id { get; set; }

        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lng")]
        public float Longitude { get; set; }

        [JsonProperty("zoom")]
        public int Zoom { get; set; }

        [JsonProperty("maps_icon")]
        public string MapIcon { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("_break")]
        public bool Break { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
            
        [JsonProperty("num_places")]
        public int NumPlaces { get; set; }

        [JsonProperty("refresh_rate")]
        public string RefreshRate { get; set; }

        [JsonProperty("bounds")]
        public IDictionary<string, MapPoint> Bounds { get; set; }

        [JsonProperty("booked_bikes")]
        public int BookedBikes { get; set; }

        [JsonProperty("set_point_bikes")]
        public int SetPointBikes { get; set; }

        [JsonProperty("available_bikes")]
        public int AvailableBikes { get; set; }

        [JsonProperty("return_to_official_only")]
        public bool ReturnToOfficialOnly { get; set; }

        [JsonProperty("bike_types")]
        public Dictionary<string,string> BikeTypes { get; set; }

        [JsonProperty("places")]
        public Place[] Places { get; set; }
    }
}
