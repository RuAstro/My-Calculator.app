using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
       double num1 = 0;
        double num2 = 0;
        double num3 = 0;
        double num4 = 0;
        double result = 0;
       

        Console.WriteLine("Calculator Program");
        Console.WriteLine("--------------------");

        Console.WriteLine("How many value numbers do you want to use?" + " Note: 2 Values = 1 operator.");
        int numberOfValues = Convert.ToInt32(Console.ReadLine());

         //if (numberOfValues == 2)
         {
             Console.WriteLine("Enter 1st value:");
             num1 = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("Enter operator (+, -, *, /): ");
              char operation1;
              Console.ReadLine();

            Console.WriteLine("Enter 2nd value:");
             num2 = Convert.ToDouble(Console.ReadLine());
         }
         enterValues();

        // if (numberOfValues == 3)
         {
            Console.WriteLine("Enter 1st value:");
            num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter operator (+, -, *, /): ");
             char operation1;
             Console.ReadLine();

            Console.WriteLine("Enter 2nd value:");
            num2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter operator (+, -, *, /): ");
             char operation2;
             Console.ReadLine(); 

            Console.WriteLine("Enter 3rd value:");
            num3 = Convert.ToDouble(Console.ReadLine());
         }

        // if (numberOfValues == 4)
         {
            Console.WriteLine("Enter 1st value:");
            num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter operator (+, -, *, /): ");
             char operation1;
             Console.ReadLine();

            Console.WriteLine("Enter 2nd value:");
            num2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter operator (+, -, *, /): ");
              char operation2; 
             Console.ReadLine();

            Console.WriteLine("Enter 3rd value:");
            num3 = Convert.ToDouble(Console.ReadLine()); 

             Console.WriteLine("Enter operator (+, -, *, /): ");
             char operation3;
             Console.ReadLine();

            Console.WriteLine("Enter 4th value:");
            num4 = Convert.ToDouble(Console.ReadLine()); 
         }


         switch (numberOfValues)
         {
            case  '+':
                result = num1 + num2;
                break;

            case  '-':
                result = num1 - num2;
                break;

            case  '*':
                result = num1 * num2;
                break;

            case  '/':
                result = num1 / num2;
                break;

            default:
            break;
         }

        Console.WriteLine($"Your result: {num1} {numberOfValues} {num2}");




        Console.ReadKey(); 
    }

    static void enterValues()
    {
        int numberOfValues = Convert.ToInt32(Console.ReadLine());
      if (numberOfValues == 2)  
         {
             Console.WriteLine("Enter 1st value:");
             num = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("Enter operator (+, -, *, /): ");
              char operation1;
              Console.ReadLine();

            Console.WriteLine("Enter 2nd value:");
             num = Convert.ToDouble(Console.ReadLine());
         }  
    }
}