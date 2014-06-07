using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarCompairsonAPI.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public List<Car> Cars { get; set; }
        public decimal NoughtToSixty { get; set; }
    }
}