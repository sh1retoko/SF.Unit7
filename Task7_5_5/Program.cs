﻿using System;

// Задание 7.5.5

// Измените класс Obj так, чтобы статические поля инициализировались в статическом конструкторе:

namespace Task7_5_5
{
    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
