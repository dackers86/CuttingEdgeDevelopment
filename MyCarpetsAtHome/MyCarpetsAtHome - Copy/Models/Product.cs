using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using StructureMap;
using MyCarpetsAtHome.MyCarpetsService;

namespace MyCarpetsAtHome.Models
{
    public class Product
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


        #endregion

        #region Implicit Operator

        public static implicit operator Product(MyCarpetsService.Product product)
        {
            if (product == null)
                return null;

            return new Product
            {
                ColourId = product.ColourId,
                Id = product.Id,
                ManufacturerId = product.Id,
                MaterialId = product.Id,
                Price = product.Id,
                RangeId = product.Id,
                StyleId = product.Id,
                TypeId = product.Id
            };
        }

        public static implicit operator MyCarpetsService.Product(Product product)
        {
            if (product == null)
                return null;

            return new MyCarpetsService.Product
            {
                ColourId = product.ColourId,
                Id = product.Id,
                ManufacturerId = product.Id,
                MaterialId = product.Id,
                Price = product.Id,
                RangeId = product.Id,
                StyleId = product.Id,
                TypeId = product.Id
            };
        }
                               

        #endregion

        #region Methods

        public static List<Product> GetAllProducts()
        {
            var service = ObjectFactory.GetInstance<IService>();
            return service.ReturnAllProducts().Select(p => (Product)p).ToList(); ;
        }

        #endregion
    }
}