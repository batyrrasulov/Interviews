
namespace Interview
{
    public class RangeCalculator : ICalculator
    {
        public string Caption => "Range";

        public double Calculate(int[] inputs)
        {
            int minimum = 0;
            int maximum = 0;
            foreach (int i in inputs)
            {
                if (i < minimum)
                    minimum = i;
                else if (i > maximum)
                    maximum = i;
            }
            return maximum - minimum;
        }
    }
}
