using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll(); //Car'in hepsini getir.
        List<Car> GetAllByColorId(int Id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
    }
}
