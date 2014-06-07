using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarCompairsonAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public Model Model { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}