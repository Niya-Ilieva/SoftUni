const {expect, equal} = require('chai');
const {isOddOrEven} = require('./module');

describe('is odd or even', () => {
    it('sould return undefined if input is not string', () => {
        expect(isOddOrEven(3)).to.be.undefined
        expect(isOddOrEven({})).to.be.undefined
        expect(isOddOrEven([])).to.be.undefined
        expect(isOddOrEven()).to.be.undefined
    })
    it('sould return even', () => {
        expect(isOddOrEven('even')).to.equals('even')
    })
    it('should return odd', () => {
        expect(isOddOrEven('odd')).to.equals('odd')
    })

})