﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 3, DailyPrice= 500, ModelYear = 2018, Description = "Tüm muayneleri yapılmış ve sürüşe hazır."},
                new Car{Id = 2, BrandId = 2, ColorId = 2, DailyPrice= 1000, ModelYear = 2021, Description = "Tüm muayneleri yapılmış ve sürüşe hazır."},
                new Car{Id = 3, BrandId = 2, ColorId = 2, DailyPrice= 1200, ModelYear = 2021, Description = "Tüm muayneleri yapılmış ve sürüşe hazır."},
                new Car{Id = 4, BrandId = 1, ColorId = 1, DailyPrice= 800, ModelYear = 2020, Description = "Tüm muayneleri yapılmış ve sürüşe hazır."},
                new Car{Id = 5, BrandId = 3, ColorId = 3, DailyPrice= 680, ModelYear = 2019, Description = "Tüm muayneleri yapılmış ve sürüşe hazır."},
                new Car{Id = 6, BrandId = 2, ColorId = 2, DailyPrice= 900, ModelYear = 2019, Description = "Tüm muayneleri yapılmış ve sürüşe hazır."},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;  
        }
    }
}
