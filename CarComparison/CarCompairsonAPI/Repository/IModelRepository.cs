using CarCompairsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CarCompairsonAPI.Repository
{
    public interface IModelRepository
    {
        HttpResponseMessage GetModelsBySearchQuery(SearchQuery searchQuery);
    }
}