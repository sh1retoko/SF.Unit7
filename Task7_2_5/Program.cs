using System;

// Задание 7.2.5

// Вернитесь к заданию 7.2.3 и дополните его код так, чтобы для вызова следующего следующего кода в консоль выводилось 2 сообщения 
// (сначала "Метод класса BaseClass", а затем "Метод класса DerivedClass"):

namespace Task7_2_5
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
            base.Display();
            Console.WriteLine("Вызван метод DerivedClass");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Display();
        }
    }
}
