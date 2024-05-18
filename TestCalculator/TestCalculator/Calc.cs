namespace TestCalculator
{
    public class Calc
    {
        //public Calc() { }
        //------------------------ Addition ----------------------//
        public double add(double[] numbers)
        {
            return numbers.Sum();
        }
        
        //------------------------ Subtraction --------------------//
        public double subtract(double[] numbers)
        {
            double difference = numbers[0];
            // subtacting all value from the first value,
            for (int i = 1; i<numbers.Length; i++)
                difference -= numbers[i];

            return difference;
        }

        //------------------- Multiplication ------------------//
        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        //------------------ Division -----------------//
        public double divide(double dividend, double divisor)
        {
            if(divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return dividend / divisor;
        }
    }
}
