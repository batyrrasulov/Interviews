Spreadsheet Checksum Problem
============================

A spreadsheet consists of rows of apparently-random numbers. To verify the 
validity of the spreadsheet's contents, you need you to calculate the 
spreadsheet's checksum. For each row, determine the difference between the 
largest value and the smallest value; the checksum is the sum of all of these
differences.

For example, given the following spreadsheet:
5 1 9 5
7 5 3
2 4 6 8

* The first row's largest and smallest values are 9 and 1, and their difference is 8.
* The second row's largest and smallest values are 7 and 3, and their difference is 4.
* The third row's difference is 6.

In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18.

Write a function that, given a zero-indexed matrix consisting of N rows and M 
columns of integers returns the checksum value of the spreadsheet that the 
matrix represents.