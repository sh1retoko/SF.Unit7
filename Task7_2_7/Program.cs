using System;

// Задание 7.2.7

// Создайте схему классов A, B, C, D и E таким образом, чтобы B наследовался от A, С от A, D от B и E от C. А также:

// Добавьте в класс A виртуальный метод Display (void тип, без параметров), который будет выводить в консоль "A".
// В классе B скройте этот метод и сделайте так, чтобы в консоль выводилось "B".
// Для класса C переопределите метод Display, чтобы в консоли было "C".
// Для D снова скройте метод.
// В классе E также скройте метод.

namespace Task7_2_7
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Клаcc: A");
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
            Console.WriteLine("Класс: С");
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

            a.Display();
            b.Display();
            c.Display();
            d.Display();
            e.Display();       
        }
    }
}
