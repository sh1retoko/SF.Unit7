using System;

// Задание 7.5.9
// Для класса int создайте 2 метода расширения: GetNegative() и GetPositive().

// Метод GetNegative должен возвращать отрицательное значение переменной (если оно положительно), 
// либо саму переменную (если оно отрицательно или равно 0).

// Метод GetPositive должен, наоборот, возвращать положительное значение (если оно отрицательно), 
// либо саму переменную (если оно положительно или равно 0).

// Иными словами, для вашего метода должен будет корректно выполняться следующий код:

namespace Task7_5_9
{
    static class IntExtensions
    {
        public static int GetNegative(this int num)
        {
            if (num > 0)
            {
                return -num;
            }
            else
            {
                return num;
            }
        }

        public static int GetPositive(this int num)
        {
            if (num < 0)
            {
                return - num;
            }
            else
            {
                return num;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0
        }
    }
}
