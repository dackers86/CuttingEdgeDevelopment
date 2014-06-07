using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarCompairsonAPI.Models;
using CarCompairsonAPI.Repository;

namespace CarCompairsonAPI.Controllers
{
    public class SearchController : ApiController, ISearchController
    {
        public ISearchRepository searchRepository;

        public SearchController()
        {
            searchRepository = new SearchRepository();
        }

        public SearchController(ISearchRepository repository)
        {
            searchRepository = repository;
        }

        public HttpResponseMessage Get()
        {
            return searchRepository.GetSearchQuery();
        }
    }
}
