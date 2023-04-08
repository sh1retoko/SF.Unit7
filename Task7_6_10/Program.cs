using System;

// Задание 7.6.10

// Переименуйте универсальные параметры в более читаемые, например, TEngine и TPart.

namespace Task7_6_10
{
    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }
    class Engine
    {

    }

    class ElectricEngine : Engine
    {

    }

    class GasEngine : Engine
    {

    }

    class CarPart
    {

    }

    class Battert : CarPart
    {

    }
    class Differential : CarPart
    {

    }
    class Wheel : CarPart
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
