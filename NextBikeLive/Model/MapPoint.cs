using Newtonsoft.Json;

namespace NextBikeLive.Model
{
    public class MapPoint
    {
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lng")]
        public float Longitude { get; set; }
    }
}
