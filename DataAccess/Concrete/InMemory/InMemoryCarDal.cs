using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1, ColorId=1, ModelYear=2001, DailyPrice=180000, Description="Gasoline" },
                new Car {CarId=2, ColorId=2, ModelYear=2010, DailyPrice=1800000, Description="Diesel" },
                new Car {CarId=3, ColorId=3, ModelYear=2001, DailyPrice=240000, Description="Hybrid" },
                new Car {CarId=4, ColorId=3, ModelYear=1999, DailyPrice=80000, Description="Electric" },
                new Car {CarId=5, ColorId=1, ModelYear=2018, DailyPrice=460000, Description="Diesel" }
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;


        }
    }
}
