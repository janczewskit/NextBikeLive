using Newtonsoft.Json;
using NextBikeLive.JsonConverters;

namespace NextBikeLive.Model
{
    public class Bike
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bike_type")]
        public int Type { get; set; }

        [JsonProperty("lock_types")]
        public string[] LockTypes { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonConverter(typeof(StateToBoolConverter))]
        public bool State { get; set; }

        [JsonProperty("electric_lock")]
        public bool HasElectricLock { get; set; }

        [JsonProperty("boardcomputer")]
        public long BoardComputer { get; set; }
    }
}
