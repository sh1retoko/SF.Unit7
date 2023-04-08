using System;

// Задание 7.6.6

// Реализуйте класс-обобщение Record, у которого будут два универсальных параметра: 
// один — для идентификатора записи (Id), другой — для значения записи (Value). Также в классе реализуйте поле Date типа DateTime.

namespace Task7_6_6
{
    internal class Program
    {
        class Record<T1, T2>
        {
            public T1 id;
            public T2 value;
            public DateTime Date;
        }

        static void Main(string[] args)
        {
        }
    }
}
