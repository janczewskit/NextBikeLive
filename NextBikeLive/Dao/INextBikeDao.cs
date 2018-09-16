using NextBikeLive.Model;

namespace NextBikeLive
{
    public interface INextBikeDao
    {
        NextBike GetAll();

        City GetCityById(long id);

        Place GetPlaceById(long id);
    }
}