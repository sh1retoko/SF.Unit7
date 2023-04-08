using System;

// Задание 7.1.6

// Реализуйте конструктор, заполняющий поля для следующего класса:

namespace Task7_1_6
{
    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
