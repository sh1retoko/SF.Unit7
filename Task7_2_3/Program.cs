using System;
using System.ComponentModel;

// Задание 7.2.3
// Реализуйте в классе BaseClass виртуальный метод Display с типом void и без параметров, который будет выводить сообщение "Метод класса BaseClass" в консоль, 
// а затем переопределите его в DerivedClass, чтобы он выводил сообщение "Метод класса DerivedClass".

namespace Task7_2_3
{
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Display();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Display();
        }
    }
}
