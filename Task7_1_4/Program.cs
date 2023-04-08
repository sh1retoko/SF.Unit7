using System;

// Задание 7.1.4

// Для следующего класса Employee создайте 2 наследника: ProjectManager и Developer.

namespace Task7_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager : Employee
    {
        public string ProjectName;
    }

    class Developer : Employee
    {
        private string ProgrammingLanguage;
    }
}
