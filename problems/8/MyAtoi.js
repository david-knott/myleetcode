/// leading whitespace
/// check for either - or +, if neither is present assume +
/// read in next characters until next non digit character or end of input
/// convert digits to number
/// clamp to integer range

/**
 * @param {string} s
 * @return {number}
 */
var myAtoi = function (s) {
    var isDigit = function (s) {
        return s.match(/[0-9]/);
    };
    var buffer = 0;
    var sign = 1;
    var i = 0;
    //skip leading whitespace
    for (; i < s.length && s[i] === ' '; ++i);
    // get sign
    if (i < s.length && (s[i] === '-' || s[i] === '+')) {
        sign = s[i++] === '-' ? -1 : 1;
    }
    // expect digits
    if (i < s.length && isDigit(s[i])) {
        do {
            buffer = buffer * 10 + sign * parseInt(s[i]);
            i++;
        } while (i < s.length && isDigit(s[i]));
    }
    if (buffer > 0x7fffffff) {
        return 0x7fffffff;
    }
    if (buffer < -0x80000000) {
        return -0x80000000;
    }
    return buffer;
};

myAtoi('-');
myAtoi('42');
myAtoi('  -42');
myAtoi('a');
myAtoi('a1234');
myAtoi('123a');
myAtoi('  123a');
myAtoi('+1');
myAtoi('-1');
myAtoi('0');
myAtoi(' 0');
myAtoi('  0');
myAtoi('4193 with words');

myAtoi('words and 987');
myAtoi('+912+342');
myAtoi('-91283472332');
myAtoi('91283472332');
