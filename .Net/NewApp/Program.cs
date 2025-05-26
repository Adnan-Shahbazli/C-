// void Proceed(out double result,in double first,in double second)
//     {
//         System.Console.WriteLine("What kind of action do you want?(1 - +, 2 - -, 3 - *, 4 - /)");
//         string? choice = Console.ReadLine();

//         if (choice == "1")
//             result = first + second;
//         else if (choice == "2")
//             result = first - second;
//         else if (choice == "3")
//             result = first * second;
//         else if (choice == "4")
//             result = first / second;
//         else
//             result = 0;
//     }

//         System.Console.Write("Enter first number: ");
//         string? firstStringNUmber = Console.ReadLine();
//         double firstNumber = Convert.ToDouble(firstStringNUmber);
//         System.Console.Write("Enter second number: ");
//         string? secondStringNUmber = Console.ReadLine();
//         double secondNumber = Convert.ToDouble(secondStringNUmber);
//         Proceed(out double result, firstNumber, secondNumber);
//         System.Console.WriteLine(result);

enum OperationTypes : int
{
    plus,
    minus,
    divide,
    multiply,
    empty
}
class Program()
{
    static void Proceed(out double result, in double first, in double second)
    {
        System.Console.WriteLine("What kind of action do you want?(1 - +, 2 - -, 3 - *, 4 - /)");
        string? choice = Console.ReadLine();
        OperationTypes operationType = OperationTypes.empty;
        if (choice == "1")
            operationType = OperationTypes.plus;
        else if (choice == "2")
            operationType = OperationTypes.minus;
        else if (choice == "3")
            operationType = OperationTypes.divide;
        else if (choice == "4")
            operationType = OperationTypes.multiply;
        else
            System.Console.WriteLine("I don't understand you");

        if (operationType == OperationTypes.plus)
            result = first + second;
        else if (operationType == OperationTypes.minus)
            result = first - second;
        else if (operationType == OperationTypes.multiply)
            result = first * second;
        else if (operationType == OperationTypes.divide)
            result = first / second;
        else
            result = 0;
    }
    public static void Main()
    {
        System.Console.Write("Enter first number: ");
        string? firstStringNUmber = Console.ReadLine();
        double firstNumber = Convert.ToDouble(firstStringNUmber);
        System.Console.Write("Enter second number: ");
        string? secondStringNUmber = Console.ReadLine();
        double secondNumber = Convert.ToDouble(secondStringNUmber);
        Proceed(out double result, firstNumber, secondNumber);
        System.Console.WriteLine(result);
    }
}