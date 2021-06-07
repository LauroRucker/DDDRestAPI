using System;
using System.Collections.Generic;
using System.Text;

namespace TruckRESTAPI.Application.Dtos
{
    public class TruckDto
    {
        public int Id { get; set; }
        public string TModel { get; set; }
        public int YearFab { get; set; }
        public int YearModel { get; set; }
    }
}
