using Newtonsoft.Json;

namespace NextBikeLive.Model
{
    public class NextBike
    {
        [JsonProperty("countries")]
        public Country[] Countries { get; set; }
    }
}
