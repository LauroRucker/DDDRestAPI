using System;
using System.Collections.Generic;
using System.Text;
using TruckRESTAPI.Application.Dtos;

namespace TruckRESTAPI.Application.Interfaces
{
    public interface IApplicationServiceTruck
    {
        void Add(TruckDto truckDto);
        void Update(TruckDto truckDto);
        void Remove(TruckDto truckDto);
        IEnumerable<TruckDto> GetAll();
        TruckDto GetById(int id);
    }
}
