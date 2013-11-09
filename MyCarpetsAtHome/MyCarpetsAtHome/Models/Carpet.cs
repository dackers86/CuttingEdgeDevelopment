using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCarpetsAtHome.MyCarpetsService;
using StructureMap;

namespace MyCarpetsAtHome.Models
{
    public class Carpet
    {
        #region Primitive Properties

        public int Id { get; set; }

        public int TypeId { get; set; }

        public Nullable<int> RangeId { get; set; }

        public Nullable<int> ManufacturerId { get; set; }

        public int ColourId { get; set; }

        public int MaterialId { get; set; }

        public int StyleId { get; set; }

        public decimal Price { get; set; }

        public List<Width> Widths { get; set; }


        #endregion

        #region Implicit Operator

        public static implicit operator Carpet(MyCarpetsService.Product product)
        {
            if (product == null)
                return null;

            return new Carpet
            {
                ColourId = product.ColourId,
                Id = product.Id,
                ManufacturerId = product.ManufacturerId,
                MaterialId = product.MaterialId,
                Price = product.Price,
                RangeId = product.RangeId,
                StyleId = product.StyleId,
                TypeId = product.TypeId,
                Widths = product.Widths.Select(w => (Width)w).ToList()
            };
        }

        public static implicit operator MyCarpetsService.Product(Carpet carpet)
        {
            if (carpet == null)
                return null;

            return new MyCarpetsService.Product
            {
                ColourId = carpet.ColourId,
                Id = carpet.Id,
                ManufacturerId = carpet.Id,
                MaterialId = carpet.Id,
                Price = carpet.Id,
                RangeId = carpet.Id,
                StyleId = carpet.Id,
                TypeId = carpet.Id
            };
        }


        #endregion

        #region Methods

        public static List<Carpet> GetAllCarpets()
        {
            var service = ObjectFactory.GetInstance<IService>();
            return service.ReturnAllProducts().Select(p => (Carpet)p).ToList(); ;
        }

        #endregion
    }
}