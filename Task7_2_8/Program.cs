using System;

// Задание 7.2.8

// Используя схему классов, которую вы создали в прошлом задании, ответьте, какой результат будет выведен в консоль после работы следующего кода:

namespace Task7_2_8
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Класс: A");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("Класс: B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("Класс: C");
        }
    }
    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("Класс: D");
        }
    }
    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("Класс: E");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();

            // Ответ: DCBA
        }
    }
}
