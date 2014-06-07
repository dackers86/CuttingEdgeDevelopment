describe('carComparisonApp controllers', function () {
    beforeEach(module('carComparisonApp'));

    describe('SearchCtrl', function () {

        it('should create "searchResult" model with 2 models', inject(function ($controller) {
            var scope = {},
                ctrl = $controller('SearchCtrl', { $scope: scope });

            expect(scope.searchResult.length).toBe(2);
        }));
    });
});