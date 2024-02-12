using System.Net;
using System.Numerics;

internal class Program
{

    static void EnterValues(int numberOfValues, out double[] values, out char[] operators)
    {
        values = new double[numberOfValues];
        operators = new char[numberOfValues - 1];

        Console.WriteLine($"Enter 1st value:");
        values[0] = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i < numberOfValues; i++)
        {
            Console.WriteLine($"Enter operator (+, -, *, /): ");
            operators[i - 1] = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Enter {i + 1} value:");
            values[i] = Convert.ToDouble(Console.ReadLine());

        }
    }

    //  static void StoreInMemory(double value)
    // {
    //     Memory = value;
    //     Console.WriteLine($"Value {value} stored in memory.");
    // }


    public static void Main(string[] args)
    {

        bool runProgram = true;

        Console.WriteLine("Calculator Program");
        Console.WriteLine("--------------------");

       do
        {

        double[] values;
        char[] operators;
        double result = 0;
      

        Console.WriteLine("How many value numbers do you want to use?" + " Note: Only 2 - 100 values.");
        int numberOfValues = Convert.ToInt32(Console.ReadLine());


        if (numberOfValues < 2 || numberOfValues > 100)
        {
            Console.WriteLine("Invalid number of values.");
            return;
        }

        EnterValues(numberOfValues, out values, out operators);

          result = values[0];

          for (int i = 0; i < numberOfValues - 1; i++)
        {
            switch (operators[i])
            {
                case '+':
                    result += values[i + 1];
                    break;
                case '-':
                    result -= values[i + 1];
                    break;
                case '*':
                    result *= values[i + 1];
                    break;
                case '/':
                    if (values[i + 1] != 0)
                    {
                        result /= values[i + 1];
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero will not execude.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }
        }
        Console.WriteLine($"Your result: = {result}");

          Console.WriteLine("Would you like to do another calculation? (Yes, No): ");

         if (Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase))
         {
            runProgram = true;
         }
         else
         {
           runProgram = false; 
           Console.WriteLine("Okay Bye!"); 
         }
            

        } while (runProgram);
             

        Console.ReadKey(); 
    }
}
