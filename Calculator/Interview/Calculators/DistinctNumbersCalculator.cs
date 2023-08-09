using System.Collections.Generic;

namespace Interview
{
    public class DistinctNumbersCalculator : ICalculator
    {
        public string Caption => "Distinct Numbers";

        public double Calculate(int[] inputs)
        {
            List<int> previouslySeenNumbers = new List<int>();
            int distinctNumbers = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (!previouslySeenNumbers.Contains(i))
                {
                    distinctNumbers++;
                    previouslySeenNumbers.Add(i);
                }
            }
            return distinctNumbers;
        }
    }
}
