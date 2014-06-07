namespace CarCompairsonAPI.Migrations
{
    using CarCompairsonAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarComparisonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CarComparisonContext context)
        {
            var ManufacturerReader = new StreamReader(File.OpenRead(@"C:\Code\GitHub\CarComparison\CarComparison\cars.csv"));

            #region Manufacturer Import

            while (!ManufacturerReader.EndOfStream)
            {
                context.Manufacturers.AddOrUpdate(m => m.Name,
                    new Manufacturer
                    {
                        Name = ManufacturerReader.ReadLine()
                                                 .Split(',')[0]
                    });

                context.SaveChanges();
            }
            


            #endregion


            #region Model Import

            var modelReader = new StreamReader(File.OpenRead(@"C:\Code\GitHub\CarComparison\CarComparison\cars.csv"));

            while (!modelReader.EndOfStream)
            {
                var record = modelReader.ReadLine()
                                   .Split(',');

                var manufacturerName = record[0];

                var manufacturer = context.Manufacturers
                                          .Where(m => m.Name == manufacturerName)
                                          .First() ?? new Manufacturer { Name = manufacturerName };

                context.Models.AddOrUpdate(m => m.Name,
                    new Model
                    {
                        Name = record[1],
                        Manufacturer = manufacturer,
                        NoughtToSixty = decimal.Parse(record[2].ToString())
                    });

                context.SaveChanges();
            }

            #endregion

        }
    }
}
