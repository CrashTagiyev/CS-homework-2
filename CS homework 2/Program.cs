

using System.Runtime.CompilerServices;

class program
{
    static decimal calculate(decimal num1, char op, decimal num2)
    {
        switch (op)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num1 / num2;
        }
        return 0;
    }
    static void calculator()
    {
        Console.Write("Num1:\n");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Operator:\n");
        char op = Console.ReadLine().ToString()[0];
        Console.Write("num2:\n");
        decimal num2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(calculate(num1, op, num2));
        calculator();
    }
    static void Main()
    {
        calculator();
    }
}
