using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TruckRESTAPI.Domain.Entitys
{
    public class Truck : Base
    {
        [Key]
        public string TModel { get; set; }
        public int YearFab { get; set; }
        public int YearModel { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
