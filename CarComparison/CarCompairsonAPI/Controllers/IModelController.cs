using CarCompairsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CarCompairsonAPI.Controllers
{
    public interface IModelController
    {
        HttpResponseMessage Get(SearchQuery searchQuery);
    }
}