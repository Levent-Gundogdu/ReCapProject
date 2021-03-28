using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    //IEntity'i car icin yapilandirdin.
    {
        List<CarDetailDto> GetCarDetails();

    }
}
