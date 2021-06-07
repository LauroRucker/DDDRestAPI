using AutoMapper;
using NUnit.Framework;
using TruckRESTAPI.Application.Mappers;

namespace TruckRESTAPI.Tests
{
    [TestFixture]
    public class MapperTests
    {
        [Test]
        public void AutoMapperDtoToModeltruck_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MapperTruckMock>());
            config.AssertConfigurationIsValid();
        }

        [Test]
        public void AutoMapperModelToDtotruck_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MapperTruckMock>());
            config.AssertConfigurationIsValid();
        }
    }
}
