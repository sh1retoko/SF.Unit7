using System;

// Задание 7.2.14

// Для следующего класса напишите индексатор, для типа параметра используйте int:

namespace Task7_2_14
{
    class Index
    {

    }

    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {                           
                 return array[index];              
            }
            set
            {
                array[index] = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
