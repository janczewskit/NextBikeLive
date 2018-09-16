using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextBikeLive;
using NextBikeLive.Client;
using NextBikeLive.Model;
using System.Linq;

namespace NextBikeLiveTests
{
    [TestClass]
    public class NextBikeDaoTests
    {
        private INextBikeDao nextBikeDao;

        [TestInitialize]
        public void SetUp()
        {
            nextBikeDao = new NextBikeDao(new NextBikeClient());
        }

        [TestMethod]
        public void GetAllTest()
        {
            NextBike data = nextBikeDao.GetAll();
        }

        [TestMethod]
        public void GetCityByIdTest()
        {
            long cityId = 545;
            City city = nextBikeDao.GetCityById(cityId);
        }

        [TestMethod]
        public void GetPlaceByIdTest()
        {
            long placeId = 4728239;
            Place place = nextBikeDao.GetPlaceById(placeId);
        }
    }
}
