const { expect, assert } = require('chai')
const createCalculator = require('./calculator')


describe('create calculator', () => {
    let calculator = null;
    beforeEach(() => {
        calculator = createCalculator();
        calculator.add(10);
    })
    it('calculato should have methods', () => {
        expect(calculator).to.has.haveOwnProperty('add')
        expect(calculator).to.has.haveOwnProperty('subtract')
        expect(calculator).to.has.haveOwnProperty('get')
    })

    it('get function should return value', () => {
        expect(calculator.get()).to.equal(10)
    })

    it('add function should increase value', () => {
        calculator.add(10)
        expect(calculator.get()).to.equal(20)
    })

    it('subtract function should decrease value', () => {
        calculator.subtract(5)
        expect(calculator.get()).to.equal(5)
    })

    it('adding numbers as text should work', () => {
        calculator.add('5')
        expect(calculator.get()).to.equal(15)
    })

    it('adding text should return false', () => {       
        expect(calculator.add('sssss')).to.be.undefined
    })

    it('subtracting text should return false', () => {       
        expect(calculator.subtract('sssss')).to.be.undefined
    })
})