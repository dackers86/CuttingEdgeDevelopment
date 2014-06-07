using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCompairsonAPI.Models
{
    public class SearchResult
    {
        public List<Model> Models { get; set; }
        public int Total { get; set; }
    }
}