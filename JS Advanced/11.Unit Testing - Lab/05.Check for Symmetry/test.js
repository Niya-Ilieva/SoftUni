    const {expect} = require('chai')
    const isSymmetric = require('./symmetric')

describe('Symmetric test', () => {
    it('Should return true for symmetric array', () => {
        expect(isSymmetric([1, 2, 3, 3, 2, 1,])).to.be.true;
    })
    it('Should return false for non-symmetric array', () => {
        expect(isSymmetric([1, 2, 3, 1,])).to.be.false;
    })
    it('Should return false for incorrect type', () => {
        expect(isSymmetric([1, 2, '1',])).to.be.false;
    })
    it('Should return false non-array', () => {
        expect(isSymmetric(20)).to.be.false;
    })
})