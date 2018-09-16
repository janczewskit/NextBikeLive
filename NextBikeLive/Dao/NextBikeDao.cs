using NextBikeLive.Client;
using NextBikeLive.Extensions;
using NextBikeLive.Model;
using System.Collections.Generic;
using System.Linq;

namespace NextBikeLive
{
    public class NextBikeDao : INextBikeDao
    {
        private readonly INextBikeClient client;

        public NextBikeDao(INextBikeClient client)
        {
            this.client = client;
        }

        public NextBike GetAll()
        {
            string data = client.GetAll();
            return this.Deserialize<NextBike>(data);
        }

        public City GetCityById(long id)
        {
            string data = client.GetByCityId(id);
            IEnumerable<City> cities = this.GetByPath<City>(data, $@"$.countries[*].cities[*]");
            return cities.SingleOrDefault();
        }

        public Place GetPlaceById(long id)
        {
            string data = client.GetByPlaceId(id);
            IEnumerable<Place> places = this.GetByPath<Place>(data, $@"$.countries[*].cities[*].places[*]");
            return places.SingleOrDefault();
        }
    }
}
