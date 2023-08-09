var Solution = require('../src/solution'),
  expect = require('chai').expect;

describe('Reverse Polish Notation Calculator', function() {
  describe('#solution', function() {

    it('should be able to parse reverse polish notation', function() {
      var str = "13+62*7+*";

      var sut = new Solution();
      var result = sut.solution(str);

      expect(result).to.equal(76);
    });

  });
});
