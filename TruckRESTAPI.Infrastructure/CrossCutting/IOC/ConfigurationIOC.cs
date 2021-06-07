using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using TruckRESTAPI.Application;
using TruckRESTAPI.Application.Interfaces;
using TruckRESTAPI.Application.Interfaces.Mappers;
using TruckRESTAPI.Application.Mappers;
using TruckRESTAPI.Domain.Core.Interfaces.Repositorys;
using TruckRESTAPI.Domain.Core.Interfaces.Services;
using TruckRESTAPI.Domain.Services;
using TruckRESTAPI.Infrastructure.Data.Repositorys;

namespace TruckRESTAPI.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceTruck>().As<IApplicationServiceTruck>();
            builder.RegisterType<ServiceTruck>().As<IServiceTruck>();
            builder.RegisterType<RepositoryTruck>().As<IRepositoryTruck>();
            builder.RegisterType<MapperTruck>().As<IMapperTruck>();

            #endregion
        }
    }
}
