using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TruckRESTAPI.Application.Dtos;
using TruckRESTAPI.Application.Interfaces.Mappers;
using TruckRESTAPI.Domain.Entitys;

namespace TruckRESTAPI.Application.Mappers
{
    public class MapperTruck : IMapperTruck
    {
        IEnumerable<TruckDto> truckDto = new List<TruckDto>();

        public Truck MapperDtoToEntity(TruckDto truckDto)
        {
            var truck = new Truck()
            {
                Id = truckDto.Id
                ,
                TModel = truckDto.TModel
                ,
                YearFab = truckDto.YearFab
                ,
                YearModel = truckDto.YearModel
            };

            return truck;
        }

        public TruckDto MapperEntityToDto(Truck truck)
        {
            var truckDto = new TruckDto()
            {
                Id = truck.Id
                ,
                TModel = truck.TModel
                ,
                YearFab = truck.YearFab
                ,
                YearModel = truck.YearModel
            };

            return truckDto;
        }

        public IEnumerable<TruckDto> MapperListTruckDto(IEnumerable<Truck> trucks)
        {
            var dto = trucks.Select(c => new TruckDto { Id = c.Id, TModel = c.TModel, YearFab = c.YearFab, YearModel = c.YearModel });
            return dto;
        }
    }
}
