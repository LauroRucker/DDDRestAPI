using System;
using System.Collections.Generic;
using System.Text;
using TruckRESTAPI.Application.Dtos;
using TruckRESTAPI.Application.Interfaces;
using TruckRESTAPI.Application.Interfaces.Mappers;
using TruckRESTAPI.Domain.Core.Interfaces.Services;

namespace TruckRESTAPI.Application
{
    public class ApplicationServiceTruck : IApplicationServiceTruck
    {
        private readonly IServiceTruck serviceTruck;
        private readonly IMapperTruck mapperTruck;

        public ApplicationServiceTruck(IServiceTruck serviceTruck, IMapperTruck mapperTruck)
        {
            this.serviceTruck = serviceTruck;
            this.mapperTruck = mapperTruck;
        }

        public void Add(TruckDto truckDto)
        {
            var truck = mapperTruck.MapperDtoToEntity(truckDto);
            serviceTruck.Add(truck);
        }

        public IEnumerable<TruckDto> GetAll()
        {
            var trucks = serviceTruck.GetAll();
            return mapperTruck.MapperListTruckDto(trucks);
        }

        public TruckDto GetById(int id)
        {
            var truck = serviceTruck.GetById(id);
            return mapperTruck.MapperEntityToDto(truck);
        }

        public void Remove(TruckDto truckDto)
        {
            var truck = mapperTruck.MapperDtoToEntity(truckDto);
            serviceTruck.Remove(truck);
        }

        public void Update(TruckDto truckDto)
        {
            var truck = mapperTruck.MapperDtoToEntity(truckDto);
            serviceTruck.Update(truck);
        }
    }
}
