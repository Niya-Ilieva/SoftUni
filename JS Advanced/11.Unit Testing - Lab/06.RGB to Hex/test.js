    const {expect, assert} = require('chai')
    const rgbToHexColor = require('./rgbToHexColor')

    describe('Rgb to hex color', () => {
        it('Should return undefined for non-numbers', () => {
            expect(rgbToHexColor(1, 'aaa', 3)).to.be.undefined;
        })
        it('Should return undefined for out of range', () => {
            expect(rgbToHexColor(260, 260, 260)).to.be.undefined;
        })
        it('Should return undefined for out of range', () => {
            expect(rgbToHexColor(-260, -260, -260)).to.be.undefined;
        })
        it('Should return color in hexadecimal format', () => {
            expect(rgbToHexColor(255, 158, 170)).to.equal('#FF9EAA');
        })
        it('Should return undefined if array', () => {
            expect(rgbToHexColor([255, 158, 170])).to.be.undefined
        })
        it('Should return undefined with less parameters', () => {
            expect(rgbToHexColor(255, 158)).to.be.undefined
        })
        it('Should return undefined with string', () => {
            expect(rgbToHexColor('aaa')).to.be.undefined
        })
        it('Should return black color in hexadecimal format', () => {
            expect(rgbToHexColor(0, 0, 0)).to.equal('#000000');
        })
    })