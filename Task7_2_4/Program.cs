using System;

// Задание 7.2.4

// Измените свойство Counter так, чтобы его можно было переопределить в классе DerivedClass. 
// Переопределите данное свойство, ограничив занесения в него чисел меньше 0.

namespace Task7_2_4
{
    class BaseClass
    {

        public virtual int Counter
        {
            get;
            set;
        }

        public void CounterNum()
        {
            Console.WriteLine($"Число счетчика: {Counter}");
        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value >= 0)
                {
                    counter = value;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.CounterNum();
        }
    }
}
