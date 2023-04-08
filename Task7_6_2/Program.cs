using System;

// Задание 7.6.2

// Создайте класс-обобщение Car для автомобиля. Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый). 
// Для типов двигателей также создайте классы — ElectricEngine и GasEngine.

// В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.

namespace Task7_6_2
{
    class Car<T>
    {
        public T engine;
    }
    class ElectricEngine
    {

    }

    class GasEngine
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
