var Solution = require('./src/checksum');

var A = new Array();

A[0] = [5,4,4];
A[1] = [4,3,4];
A[2] = [3,2,4];
A[3] = [2,2,2];
A[4] = [3,3,4];
A[5] = [1,4,4];
A[6] = [4,1,1];

var sut = new Solution();
var result = sut.solution(A);

console.log(result);
