var Solution = require('../src/solution'),
  expect = require('chai').expect;

describe('Frog Pond', function() {
  describe('#solution', function() {

    it('should return the correct timing', function() {
      var A = [1,3,1,4,2,5];
      var X = 7;
      var D = 3;

      var sut = new Solution();
      var result = sut.solution(A, X, D);

      expect(result).to.equal(3);
    });

  });
});
