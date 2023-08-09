namespace Interview
{
    public class MeanCalculator : ICalculator
    {
        public string Caption => "Mean";

        public double Calculate(int[] inputs)
        {
            int sum = 0;
            foreach (int i in inputs)
            {
                sum += i;
            }
            return sum / inputs.Length;
        }
    }
}
