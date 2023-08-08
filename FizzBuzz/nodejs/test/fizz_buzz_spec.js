var FizzBuzz = require('../src/fizz_buzz'),
  expect = require('chai').expect;

describe('FizzBuzz', function() {
  describe('#solution', function() {

    it('should return the correct result', function() {
      int n = 15;

      var sut = new FizzBuzz();
      var result = sut.solution(n);

      expect(result[0]).to.equal('1');
      expect(result[1]).to.equal('2');
      expect(result[2]).to.equal('Fizz');
      expect(result[3]).to.equal('4');
      expect(result[4]).to.equal('Buzz');
      // ...
      expect(result[14]).to.equal('FizzBuz');
    });

  });
});
