using System;

namespace BuggyCalculator
{
    class BuggyCalculator
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            string isContinue = "yes";

            while (isContinue == "yes")
            {
                Console.WriteLine("Выберите операцию: +, -, *, /");
                char operation = char.Parse(Console.ReadLine());

                Console.WriteLine("Введите первое число:");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                int number2 = int.Parse(Console.ReadLine());

                double result;

                if (operation == '+')
                {
                    result = calculator.Sum(number1, number2);
                }
                else if (operation == '-')
                {
                    result = calculator.Sub(number1, number2);
                }
                else if (operation == '*')
                {
                    result = calculator.Multi(number1, number2);
                }
                else
                {
                    result = calculator.Div(number1, number2);
                }

                Console.WriteLine("Ваш результат: " + result);

                Console.WriteLine("Продолжить?: yes/no");

                isContinue = Console.ReadLine();
            }
        }
    }
}
