using System;
using System.Collections.Generic;
using System.Text;
using TruckRESTAPI.Domain.Core.Interfaces.Repositorys;
using TruckRESTAPI.Domain.Core.Interfaces.Services;
using TruckRESTAPI.Domain.Entitys;

namespace TruckRESTAPI.Domain.Services
{
    public class ServiceTruck : ServiceBase<Truck> , IServiceTruck
    {
        private readonly IRepositoryTruck repositoryTruck;

        public ServiceTruck(IRepositoryTruck repositoryTruck): base(repositoryTruck)
        {
            this.repositoryTruck = repositoryTruck;
        }
    }
}
