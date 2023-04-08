using System;

// Задание 7.5.3

// Создайте класс Helper и определите в нем статический метод Swap типа void, который принимает 2 переменные типа int и меняет их значения местами.

// Иными словами, для вашего метода должен будет корректно выполняться следующий код:

namespace Task7_5_3
{
    class Helper
    {
        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 58;

            Helper.Swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
