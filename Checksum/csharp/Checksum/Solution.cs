// sorry it's just i was not prepared for this at all
// we can treate this as like a take home assesment

namespace Checksum
{
    public class Solution
    {
        public int CalculateChecksum(int[][] spreadsheet)
        {
            // initialize the actual total checksum to 0 (kept it the same)
            int total = 0;

            // iterate thru each row in the spreadsheet
            foreach (var row in spreadsheet) {

                // thought to try this to start with the smalles possible integer
                int max = int.MinValue;

                // continue with the largest possible integer
                int min = int.MaxValue;

                // iterate thru each value in the row
                foreach (var value in row) {
                    // here we can update the maximum if the value is larger
                    if (value > max) max = value;
                    
                    // here we can update the minimum if the value is smaller
                    if (value < min) min = value;
                }

                // add the difference between maximum and minimum to the total checksum
                total += (max - min);
            }

            // return the final final final checksum
            return total
        }
    }
}
