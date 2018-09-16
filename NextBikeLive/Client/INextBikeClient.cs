namespace NextBikeLive.Client
{
    public interface INextBikeClient
    {
        string GetAll();

        string GetByCityId(long id);

        string GetByPlaceId(long id);
    }
}