const {mathEnforcer} = require('./mathEnforcer');
const {expect} = require('chai');

describe('math enforcer tests', () => {
    describe('add function', () => {
        it('should return correct result', () => {
            expect(mathEnforcer.addFive(10)).to.equals(15)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.addFive(4.99)).to.be.closeTo(9.99, 0.01)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.addFive(2.5)).to.equals(7.5)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.addFive(-10)).to.equals(-5)
        })
        it('should return undefined', () => {
            expect(mathEnforcer.addFive('2')).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.addFive(undefined)).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.addFive({})).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.addFive([])).to.be.undefined
        })
    })
    describe('subtractTen function', () => {
        it('should return correct result', () => {
            expect(mathEnforcer.subtractTen(20)).to.equals(10)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.subtractTen(19.99)).to.be.closeTo(9.99, 0.01)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.subtractTen(14.5)).to.equals(4.5)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.subtractTen(-13)).to.equals(-23)
        })
        it('should return undefined', () => {
            expect(mathEnforcer.subtractTen('2')).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.subtractTen(undefined)).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.subtractTen({})).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.subtractTen([])).to.be.undefined
        })
    })
    describe('sum function', () => {
        it('should return correct result', () => {
            expect(mathEnforcer.sum(1, 1)).to.equals(2)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.sum(1.2, 3.3)).to.equals(4.5)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.sum(3.33, 6.66)).to.be.closeTo(9.99, 0.01)
        })
        it('should return correct result', () => {
            expect(mathEnforcer.sum(-1, -2)).to.equals(-3)
        })
        it('should return undefined', () => {
            expect(mathEnforcer.sum('2', '2')).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.sum(undefined, undefined)).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.sum({}, {})).to.be.undefined
        })
        it('should return undefined', () => {
            expect(mathEnforcer.sum([], [])).to.be.undefined
        })
    })
})