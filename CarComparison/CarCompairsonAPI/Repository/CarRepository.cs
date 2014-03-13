using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCompairsonAPI.Models;

namespace CarCompairsonAPI.Repository
{
    public class CarRepository : ICarRepository
    {
        private CarComparisonContext context;

        public CarRepository()
        {
            this.context = new CarComparisonContext();
        }

        public CarRepository(CarComparisonContext context)
        {
            this.context = context;
        }

        public IList<Car> GetAllCars()
        {
            return context.Cars.ToList();
        }

        public Car AddCar(Car car)
        {
            var newCar = context.Cars.Add(car);
            context.SaveChanges();
            return newCar;
        }

        public Car GetCarById(int carId)
        {
            return context.Cars.Where(c => c.Id == carId).FirstOrDefault();
        }
    }
}