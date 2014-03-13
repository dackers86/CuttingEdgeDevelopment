using CarCompairsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCompairsonAPI.Repository
{
    public interface ICarRepository
    {
        IList<Car> GetAllCars();
        Car AddCar(Car car);
        Car GetCarById(int carId);
    }
}