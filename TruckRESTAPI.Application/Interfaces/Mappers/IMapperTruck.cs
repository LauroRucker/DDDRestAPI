using System;
using System.Collections.Generic;
using System.Text;
using TruckRESTAPI.Application.Dtos;
using TruckRESTAPI.Domain.Entitys;

namespace TruckRESTAPI.Application.Interfaces.Mappers
{
    public interface IMapperTruck
    {
        Truck MapperDtoToEntity(TruckDto truckDto);
        IEnumerable<TruckDto> MapperListTruckDto(IEnumerable<Truck> trucks);
        TruckDto MapperEntityToDto(Truck truck);
    }
}
