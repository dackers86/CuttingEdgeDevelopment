using CarCompairsonAPI.Models;
using CarCompairsonAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarCompairsonAPI.Controllers
{
    public class CarController : ApiController, ICarController
    {
        public ICarRepository carRepository;

        public CarController()
        {
            carRepository = new CarRepository();
        }

        public CarController(ICarRepository CarRepository)
        {
            carRepository = CarRepository;
        }

        public IList<Car> Get()
        {
            return carRepository.GetAllCars();
        }

        public Car Get(int id)
        {
            return carRepository.GetCarById(id);
        }

        public Car Post(Car car)
        {
            return carRepository.AddCar(car);
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}