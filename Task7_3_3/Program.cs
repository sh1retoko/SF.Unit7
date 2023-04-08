using System;

//Задание 7.3.3

//Создайте классы для следующих объектов компьютера: процессор(Processor), материнская карта(MotherBoard), видеокарта(GraphicCard).Унаследуйте их от класса ComputerPart.

//Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.

namespace Task7_3_3
{
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {
     
        }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work()
        {

        }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work()
        {

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
