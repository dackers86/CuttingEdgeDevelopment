describe('carComparisonApp', function () {

	describe('Search Result view', function () {

		beforeEach(function () {
			browser().navigateTo('/CarComparison');
		});


		it('should filter the search result as user types into the search box', function () {
			expect(repeater('.searchResults li').count()).toBe(2);

			input('searchQuery').enter('370');
			expect(repeater('.searchResults li').count()).toBe(1);

			input('query').enter('Nissan');
			expect(repeater('.searchResults li').count()).toBe(2);
		});
	});
});