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
        public CarRepository carRepository;

        public CarController()
        {
        }

        public CarController(CarRepository CarRepository)
        {
            carRepository = CarRepository;
        }

        // GET api/values
        public IList<Car> Get()
        {
            return carRepository.GetAllCars();
        }

        // GET api/values/5
        public Car Get(int id)
        {
            return carRepository.GetCarById(id);
        }

        // POST api/values
        public Car Post(Car car)
        {
            return new Car { };
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}