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
    public interface ICarController
    {
        IList<Car> Get();
        Car Get(int id);
        Car Post(Car car);
        void Put(int id, [FromBody]string value);
        void Delete(int id);

    }
}