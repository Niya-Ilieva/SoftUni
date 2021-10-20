const {lookupChar} = require('./lookup')
const {expect} = require('chai')

describe('char lookup tests', () => {
    it('invalid parameters should return undefined', () => {
        expect(lookupChar(5, 'A')).to.be.undefined
        expect(lookupChar({}, {})).to.be.undefined
        expect(lookupChar([], [])).to.be.undefined
        expect(lookupChar()).to.be.undefined
        expect(lookupChar('A', 3.4)).to.be.undefined
    })
    it('invalid index should return msg', () => {
        expect(lookupChar('A', 5)).to.be.equal('Incorrect index')
        expect(lookupChar('A', -5)).to.be.equal('Incorrect index')
    })
    it('should return correct', () => {
        expect(lookupChar('SAS', 1)).to.be.equal('A')
        expect(lookupChar('SAS', 2)).to.be.equal('S')
    })
})