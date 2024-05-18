namespace TestCalculator
{
    public class inputConverter
    {
        public static double[] ConvertInputToArray(string input)
        {
            string output = input.Trim(); //removing leading spaces.
            // Converting string into and array of double and returning.
            return output.Split(' ').Select(n =>
            {
                if (double.TryParse(n, out double result)) { 
                    return result;
                }
                else
                {
                    throw new FormatException("One or more inputs are not valid...");
                }
            }).ToArray();
        }
    }
}
