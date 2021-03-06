﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public bool Add(Car car)
        {
            if (car.CarDescription.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return true;
            }
            else
            {
                Console.WriteLine("A car description length must be higher than 2 words and the daily price must be stated.");
                return false;
            }
        }

        public List<Car> GetAll()
        {
           //Business codes
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(p => p.ColorId == Id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(p => p.BrandId == Id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
