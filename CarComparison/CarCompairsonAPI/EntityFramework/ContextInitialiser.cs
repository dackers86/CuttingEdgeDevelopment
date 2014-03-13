using CarCompairsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarCompairsonAPI.EntityFramework
{
    public class ContextInitialiser : DropCreateDatabaseAlways<CarComparisonContext>
    {
        protected override void Seed(CarComparisonContext context)
        {
            base.Seed(context);
            context.Cars.Add(new Car() { Id = 1 });
            context.SaveChanges();
        }
    }
}