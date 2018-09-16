using Newtonsoft.Json;

namespace NextBikeLive.Model
{
    public class Country
    {
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lng")]
        public float Longitude { get; set; }

        [JsonProperty("zoom")]
        public int Zoom { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hotline")]
        public string Hotline { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("country_calling_code")]
        public string CountryCallingCode { get; set; }

        [JsonProperty("system_operator_address")]
        public string SystemOperatorAddress { get; set; }

        [JsonProperty("country")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("policy")]
        public string Policy { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("show_bike_types")]
        public bool ShowBikeTypes { get; set; }

        [JsonProperty("show_bike_type_groups")]
        public bool ShowBikeTypeGroups { get; set; }

        [JsonProperty("show_free_racks")]
        public bool ShowFreeRacks { get; set; }

        [JsonProperty("booked_bikes")]
        public int BookedBikes { get; set; }

        [JsonProperty("set_point_bikes")]
        public int SetPointBikes { get; set; }

        [JsonProperty("available_bikes")]
        public int AvailableBikes { get; set; }

        [JsonProperty("capped_available_bikes")]
        public bool CappedAvailableBikes { get; set; }

        [JsonProperty("pricing")]
        public string Pricing { get; set; }

        [JsonProperty("cities")]
        public City[] Cities { get; set; }
    }
}
