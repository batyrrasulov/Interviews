var Solution = require('../src/solution'),
  expect = require('chai').expect;

describe('Break the Chain', function() {
  describe('#solution', function() {

    it('should return the lowest cost to break the chain into three parts', function() {
      var chain = [5,2,4,6,3,7];

      var sut = new Solution();
      var result = sut.solution(chain);

      expect(result).to.equal(5);
    });

  });
});
