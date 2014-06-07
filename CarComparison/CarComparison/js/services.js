angular.module('carComparisonApp.Services', ['ngResource'])
  .factory('carServices', ['$resource', function($resource)
  {
  	return $resource('Api/Model', {}, {
  		query: {
  			method: 'GET',

  			isArray: true
  		}
  	})
  }])

  .factory('searchServices', ['$resource', function($resource)
  {
  	return $resource('Api/Search', {}, {
  		query: {
  			method: 'GET',
  			isArray: false
  		}
  	})
  }])


