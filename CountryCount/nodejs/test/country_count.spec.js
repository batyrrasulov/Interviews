var CountryCount = require('../src/country_count'),
  expect = require('chai').expect;

describe('Country Count', function() {
  describe('#solution', function() {

    it('should return the correct number of countries', function() {
      var A = [
        [5,4,4],
        [4,3,4],
        [3,2,4],
        [2,2,2],
        [3,3,4],
        [1,4,4],
        [4,1,1]
      ];

      var sut = new CountryCount();
      var result = sut.solution(A);

      expect(result).to.equal(11);
    });

  });
});
