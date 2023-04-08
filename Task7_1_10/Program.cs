using System;

// Задание 7.1.10

// Для класса DerivedClass создайте 2 конструктора: один, принимающий 2 параметра — name и description, второй — принимающий 3 параметра name, description и counter.

// Старайтесь написать оптимальный вариант с учетом полученных знаний.

namespace Task7_1_10
{
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }
        public DerivedClass(string name, string description, int counter) : base(name)
        {
            Description= description;
            Counter = counter;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
