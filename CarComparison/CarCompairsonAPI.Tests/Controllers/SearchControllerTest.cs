using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarCompairsonAPI.Models;
using CarCompairsonAPI.Repository;
using CarCompairsonAPI.Controllers;
using Rhino.Mocks;

namespace CarCompairsonAPI.Tests.Controllers
{
    [TestFixture]
    public class SearchControllerTest
    {
        private ISearchRepository _mockSearchRepository;
        private SearchController searchController;

        [SetUp]
        public void Setup()
        {
            _mockSearchRepository = MockRepository.GenerateMock<ISearchRepository>();
            searchController = new SearchController();
        }

        [Test]
        public void GetSearch_Simple()
        {
            /*** Arrange ***/
            var searchResult = new SearchResult { Models = new List<Model>() };
            var SearchQuery = new SearchQuery { MaxResults = 10 };

            _mockSearchRepository.Stub(x => x.ExecuteSearch(SearchQuery))
                                 .Repeat.Once()
                                 .Return("");

            searchController.searchRepository = _mockSearchRepository;

            /*** Act ***/
            searchController.Get(SearchQuery);

            /*** Assert ***/
            _mockSearchRepository.VerifyAllExpectations();
        }

        [Test]
        public void GetSearchResult_DoesNotExceedMaximum()
        {
            /*** Arrange ***/
            var searchResult = new SearchResult { Models = new List<Model>() };
            var SearchQuery = new SearchQuery { MaxResults = 10 };

            _mockSearchRepository.Stub(x => x.ExecuteSearch(SearchQuery))
                                 .Repeat.Once()
                                 .Return("");

            searchController.searchRepository = _mockSearchRepository;

            /*** Act ***/
            searchController.Get(SearchQuery);

            /*** Assert ***/
            _mockSearchRepository.VerifyAllExpectations();
        }


        [Test]
        public void GetSearchResult_CanFilterWithMaxValue()
        {
            /*** Arrange ***/
            var maxResults = 1;
            var searchResult = new List<Model> 
            { 
                    new Model { Id = 1, Name="Car1" },
                    new Model { Id = 1, Name="Car2" }
            };

            var SearchQuery = new SearchQuery
            {
                MaxResults = maxResults
            };

            _mockSearchRepository.Expect(x => x.ExecuteSearch(SearchQuery))
                                 .Repeat.Once()
                                 .Return(searchResult);

            searchController.searchRepository = _mockSearchRepository;

            /*** Act ***/
            var result = searchController.Expect(x => x .Get() => () {
            
            
            })  Get(SearchQuery);

            /*** Assert ***/
            _mockSearchRepository.VerifyAllExpectations();
            //Assert.AreEqual(result.Models.Count, 1);
        }
    }
}
