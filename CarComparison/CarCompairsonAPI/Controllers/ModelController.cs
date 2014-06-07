using CarCompairsonAPI.Models;
using CarCompairsonAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CarCompairsonAPI.Controllers
{
    public class ModelController : ApiController, IModelController
    {
        public IModelRepository modelRepository;

        public ModelController()
        {
            modelRepository = new ModelRepository();
        }

        public ModelController(IModelRepository repository)
        {
            modelRepository = repository;
        }

        public HttpResponseMessage Get(SearchQuery searchQuery)
        {
            return modelRepository.GetModelsBySearchQuery(searchQuery);
        }
    }
}