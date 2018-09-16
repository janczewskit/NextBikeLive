using System.Net;

namespace NextBikeLive.Client
{
    public class NextBikeClient : WebClient, INextBikeClient
    {
        private readonly string address;

        public NextBikeClient()
        {
            address = @"https://nextbike.net/maps/nextbike-live.json";
        }

        public string GetAll()
        {
            return DownloadString(address);
        }

        public string GetByCityId(long id)
        {
            string uri = $@"{address}?city={id}";
            return DownloadString(uri);
        }

        public string GetByPlaceId(long id)
        {
            string uri = $@"{address}?place={id}";
            return DownloadString(uri);
        }
    }
}