using static System.Console;
namespace TestCalculator
{
    public class program
    {
        static void Main(string[] args)
        {
            //---------- Creating an instance of calculator -----------//
            Calc calculator = new Calc(); 

            bool exitCalculator = true;
            //-------- Giving options To user for selection -------- //
            static void selectOption()
            {
                WriteLine("\n--------------------Calculator--------------------");
                WriteLine("Enter the Selection you want Todo\n\n");
                WriteLine("Press 1 for Addition");
                WriteLine("Press 2 for Subtraction");
                WriteLine("Press 3 for Multiplication");
                WriteLine("Press 4 for Division\n");
                WriteLine("Press 9 for Exit the calculator\n");

            }
            //------------ Calculator On ----------//
            while (exitCalculator)
            {
                selectOption(); //option Shown
                try
                {
                    int option = Convert.ToInt32(ReadLine()); //---Taking input for option
                    WriteLine("\n");

                    if (option == 1 || option == 2)
                    {
                        WriteLine("Enter numbers seperated by a single space: ");
                        string input = ReadLine();
                        //----- Converting input to Array -----------//
                        double[] numbers = inputConverter.ConvertInputToArray(input);
                        //double[] numbers = ConvertInput(input);
                        try //------ To check wrong input 
                        {
                            if (option == 1)
                            {
                                double sum = calculator.add(numbers);
                                WriteLine($"The sum is: {sum}");
                            }
                            else
                            {
                                double difference = calculator.subtract(numbers);
                                WriteLine($"The difference is: {difference}");
                            }
                        }
                        catch (Exception e) { WriteLine(e.Message); }
                        

                    }//if for 1 and 2 closed
                    else if (option == 3 || option == 4)
                    {
                        try
                        {
                            WriteLine("Enter First number: ");
                            double num1 = Convert.ToDouble(ReadLine());
                            WriteLine("Enter second number: ");
                            double num2 = Convert.ToDouble(ReadLine());
                            
                            if (option == 3)
                            {
                                double result = calculator.multiply(num1, num2);
                                WriteLine($"The multiplication is: {result}");
                            }
                            else
                            {
                                double quotient = calculator.divide(num1, num2);
                                WriteLine($"The quotient is: {quotient}");
                            }
                        }
                        catch(Exception e) { WriteLine(e.Message);}

                    } // else if for 3 and 4 closed
                    else if (option == 9)
                        exitCalculator = false;
                    else
                    {
                        WriteLine("Invalid Selection!\n");
                        WriteLine("Please! Select from the given options.\n\n");
                    }
                } // try block closed
                catch (Exception ex) { 
                    WriteLine("\n" + ex.Message); 
                    WriteLine("Please! Enter number."); 
                }
            }

        }
//----------------------- Method to convert Input in to an Array -------------//

  /*     static double[] ConvertInput(string str)
            {
                string newStr = str.Trim();
                string[] stringArray = newStr.Split(' ');
                double[] numbers = new double[stringArray.Length];
                for(int i = 0; i < stringArray.Length; i++)
                {
                    if (double.TryParse(stringArray[i], out double result))
                    {
                        numbers[i] = Convert.ToDouble(stringArray[i]);
                    }
                    else
                    {
                        throw new FormatException($"{stringArray[i]} is not a valid number..");
                    }

                }
                return numbers;
            }
  */
    } 
}

