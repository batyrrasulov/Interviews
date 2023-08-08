
namespace Interview
{
    public interface ICalculator
    {
        string Caption { get; }
        double Calculate(int[] inputs);
    }

    public class MedianCalculator : ICalculator
    {
        public string Caption => "Median";

        public double Calculate(int[] inputs)
        {
            return inputs[inputs.Length / 2];
        }
    }
}
