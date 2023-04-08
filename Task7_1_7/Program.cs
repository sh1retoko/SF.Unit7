using System;

// Задание 7.1.7

// Впишите пропущенный код для параметров в Console.WriteLine вместо ??? так, чтобы в консоли выводилось "Привет, Грег, я интеллектуальный помощник Олег":

namespace Task7_1_7
{
    class SmartHelper
    {
        private string name;

        public SmartHelper(string name)
        {
            this.name = name;
        }

        public void Greetings(string name)
        {
            Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHelper helper = new SmartHelper("Олег");
            helper.Greetings("Грег");

            Console.ReadKey();
        }       
    }
}
