const chai = require('chai')
const expect = chai.expect
const FizzBuzz = require('../lib/FizzBuzz')


describe('FizzBuzz', function() {
  it('handles simple numbers', function() {
    const fizzbuzz = new FizzBuzz();
    expect(fizzbuzz.play(1)).to.equal(1);
  });
});
