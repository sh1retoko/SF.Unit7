using System;

// Задание 7.6.12

// С учётом полученных знаний по наследованию обобщений, дополните схему классов автомобиля, добавив классы для электромобиля и бензинового — ElectricCar и GasCar.

// Подумайте, какой класс или классы можно сделать абстрактными. Сделайте абстрактными их и их члены (по возможности).

namespace Task7_6_12
{
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;   
    }
    abstract class Engine
    {

    }

    class ElectricEngine : Engine
    {

    }

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    

    class GasEngine : Engine
    {

    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    abstract class CarPart
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
