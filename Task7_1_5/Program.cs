using System;

// Задание 7.1.5

// Для следующего списка объектов создайте схему классов (объявите нужные классы и установите связи между ними):

// Apple(яблоко);
// Banana(банан);
// Pear(груша);
// Potato(картофель);
// Carrot(морковь).

namespace Task7_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Food
    {
    }

    class fruits : Food
    {
    }

    class vegetables : Food
    {
    }

    class Apple : fruits
    {
    }

    class Banana : fruits
    {
    }

    class Pear : fruits
    {
    }

    class Potato : vegetables
    {
    }

    class Carrot : vegetables
    {
    }
}
