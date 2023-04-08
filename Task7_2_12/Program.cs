using System;

// Задание 7.2.12

// Для класса Obj перегрузите операторы + и -, чтобы результатом работы оператора был новый экземпляр класса Obj, 
// а операции производились над полем Value.

namespace Task7_2_12
{
    class Obj
    {
        public int Value;

        public static Obj operator + (Obj x, Obj y)
        {
            return new Obj()
            {
                Value= x.Value + y.Value,
            };
        }
        public static Obj operator - (Obj x, Obj y)
        {
            return new Obj()
            {
                Value = x.Value - y.Value,
            };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
