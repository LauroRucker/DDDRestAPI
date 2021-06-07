using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using AutoMapper;
using Moq;
using NUnit.Framework;
using TruckRESTAPI.Application;
using TruckRESTAPI.Application.Dtos;
using TruckRESTAPI.Domain.Core.Interfaces.Services;
using TruckRESTAPI.Domain.Entitys;
using TruckRESTAPI.Application.Interfaces.Mappers;

namespace TruckRESTAPI.Tests
{
    [TestFixture]
    public class ApplicationServiceTruckTests
    {
        private static Fixture _fixture;
        private Mock<IServiceTruck> _servicetruckMock;
        private Mock<IMapperTruck> _mapperMock;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
            _servicetruckMock = new Mock<IServiceTruck>();
            _mapperMock = new Mock<IMapperTruck>();
        }

        [Test]
        public void ApplicationServicetruck_GetAll_ShouldReturnFiveClients()
        {
            //Arrange
            var trucks = _fixture.Build<Truck>().CreateMany(5);
            var trucksDto = _fixture.Build<TruckDto>().CreateMany(5);

            _servicetruckMock.Setup(x => x.GetAll()).Returns(trucks);
            _mapperMock.Setup(x => x.MapperListTruckDto(trucks));

            var applicationServicetruck = new ApplicationServiceTruck(_servicetruckMock.Object, _mapperMock.Object);

            //Act
            var result = applicationServicetruck.GetAll();

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
            _servicetruckMock.VerifyAll();
            _mapperMock.VerifyAll();
        }

        [Test]
        public void ApplicationServicetruck_GetById_ShouldReturnClient()
        {
            //Arrange
            const int id = 10;

            var truck = _fixture.Build<Truck>()
                .With(c => c.Id, id)
                .With(c => c.TModel, "FM")
                .Create();

            var truckDto = _fixture.Build<TruckDto>()
                .With(c => c.Id, id)
                .With(c => c.TModel, "FM")
                .Create();

            _servicetruckMock.Setup(x => x.GetById(id)).Returns(truck);
            _mapperMock.Setup(x => x.MapperDtoToEntity(truckDto));

            var applicationServicetruck =
                new ApplicationServiceTruck(_servicetruckMock.Object, _mapperMock.Object);

            //Act
            var result = applicationServicetruck.GetById(id);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(123, result.YearModel);
            Assert.AreEqual(10, result.Id);
            _servicetruckMock.VerifyAll();
            _mapperMock.VerifyAll();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}