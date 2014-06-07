angular.module('carComparisonApp.controllers', [])
	.controller('searchCtrl', ['$scope', 'carServices', 'searchServices', function ($scope, carServices, searchServices) 
	{
			carServices.query(function(data)
		  	{
		  		$scope.searchResult = data;
		  	});


			searchServices.query(function(data)
		  	{
		  		$scope.searchQuery = data;  
		  	});

		  	$scope.selectedManufacturers = function selectedManufacturers() {
			   return filterFilter($scope.manufacturer.isSelected, { selected: true });
			};

			$scope.$watch('manufacturer.isSelected|filter:{selected:true}', function (nv) {
			    $scope.selectedManufacturers = nv.map(function (manufacturer) {
			      return manufacturer.Name;
			    });
			}, true);
	}
]);	
