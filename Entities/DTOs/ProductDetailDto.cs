using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto //bu bir imza
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string CarDescription { get; set; }
        public decimal DailyPrice { get; set; }
        
    }
}
