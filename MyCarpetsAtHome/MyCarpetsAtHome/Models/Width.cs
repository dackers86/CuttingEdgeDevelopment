using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCarpetsAtHome.Models;
using MyCarpetsAtHome.MyCarpetsService;

namespace MyCarpetsAtHome.Models
{


    public class Width
    {

        #region Primitive Properties
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TypeId { get; set; }


        #endregion


        #region Implicit Operator

        public static implicit operator Width(MyCarpetsService.Width width)
        {
            if (width == null)
                return null;


            return new Width
            {
                Id = width.Id,
                ProductId = width.ProductId,
                TypeId = width.TypeId
            };

        }

        #endregion

    }

}