using System;

// Задание 7.6.9

// Установите ограничения на универсальные типы в классе Car. 
// Такие, чтобы поле Engine могло принимать тип ElectricEngine и GasEngine, 
// а параметр newPart метода ChangePart мог бы принимать только типы частей машины (Battery, Differential, Wheel).

// Для этого вам может понадобиться использовать один из ранее изученных принципов ООП.

namespace Task7_6_9
{
    class Car<T1> where T1 : Engine
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart
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
