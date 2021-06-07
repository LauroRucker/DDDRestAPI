using System;
using System.Collections.Generic;
using System.Text;
using TruckRESTAPI.Domain.Core.Interfaces.Repositorys;
using TruckRESTAPI.Domain.Entitys;

namespace TruckRESTAPI.Infrastructure.Data.Repositorys
{
    public class RepositoryTruck: RepositoryBase<Truck>, IRepositoryTruck
    {
        private readonly SqlContext sqlcontext;

        public RepositoryTruck(SqlContext sqlcontext): base(sqlcontext)
        {
            this.sqlcontext = sqlcontext;
        }
    }
}
