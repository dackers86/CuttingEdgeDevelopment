using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CarCompairsonAPI.Models
{
    public class SearchQuery
    {
        public int count { get; set; }
        public List<Model> Model { get; set; }
        public List<Manufacturer> Manufacturer { get; set; }
    }
}