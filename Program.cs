using System.Net;

internal class Program
{
    static void EnterValues(int numberOfValues, out double num1, out double num2, out double num3, out double num4)
{
    num1 = 0;
    num2 = 0;
    num3 = 0;
    num4 = 0;

    Console.WriteLine($"Enter 1st value:");
    num1 = Convert.ToDouble(Console.ReadLine());

    for (int i = 2; i <= numberOfValues; i++)
    {
        Console.WriteLine($"Enter operator (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine($"Enter {i} value:");
        double value = Convert.ToDouble(Console.ReadLine());

        switch (i)
        {
            case 2:
                num2 = value;
                break;
            case 3:
                num3 = value;
                break;
            case 4:
                num4 = value;
                break;
            default:
                break;
        }
    }
}

    private static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;
        double num3 = 0;
        double num4 = 0;
        double result = 0;
        char operation1 = ' ';
        char operation2 = ' ';
        char operation3 = ' ';
       

        Console.WriteLine("Calculator Program");
        Console.WriteLine("--------------------");

        Console.WriteLine("How many value numbers do you want to use?" + " Note: 2 Values = 1 operator.");
        int numberOfValues = Convert.ToInt32(Console.ReadLine());

         if (numberOfValues == 2)
         {
             EnterValues(numberOfValues, out num1, out num2, out num3, out num4);
         }

    /*/     else if (numberOfValues == 3)
         {
            Console.WriteLine("Enter 1st value:");
            num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter operator (+, -, *, /): ");
             operation2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter 2nd value:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /): ");
            operation3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter 3rd value:");
            num3 = Convert.ToDouble(Console.ReadLine());
         }

         else if (numberOfValues == 4)
         {
            Console.WriteLine("Enter 1st value:");
            num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter operator (+, -, *, /): ");
             char operation4;
             Console.ReadLine();

            Console.WriteLine("Enter 2nd value:");
            num2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter operator (+, -, *, /): ");
              char operation5; 
             Console.ReadLine();

            Console.WriteLine("Enter 3rd value:");
            num3 = Convert.ToDouble(Console.ReadLine()); 

             Console.WriteLine("Enter operator (+, -, *, /): ");
             char operation6;
             Console.ReadLine();

            Console.WriteLine("Enter 4th value:");
            num4 = Convert.ToDouble(Console.ReadLine()); 
         } */


         switch (numberOfValues)
        {
            case 2:
                switch (operation1)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        break;
                }
                break;
         }



        switch (operation2)
         {
            case  '+':
                result = num1 + num2 + num3;

                break;

            case  '-':
                result = num1 - num2 - num3;
                break;

            case  '*':
                result = num1 * num2 * num3;
                break;

            case  '/':
                result = num1 / num2 / num3;
                break;

            default:
            break;
         }





        Console.WriteLine($"Your result: {num1} {operation1} {num2} = {result}");




        Console.ReadKey(); 
    }
}
