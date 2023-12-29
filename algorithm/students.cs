using System;

namespace ConsoleApplication
{
    class Student
    {
        public string fio;
        public int year;
        public string group;

        public Student(string fio, int year, string group)
        {
            this.fio = fio;
            this.year = year;
            this.group = group;
        }

        public void Data()
        {
            Console.WriteLine("ФИО: " + fio);
            Console.WriteLine("Год рождения: " + year);
            Console.WriteLine("Группа: " + group);
            
        }

        public void GroupSearch(string group)
        {
            if (this.group == group)
            {
                Data();
                Console.WriteLine("------------");
            }    
        }

        public void YearSearch(int year)
        {
            if (this.year == year)
            {
                Data();
                Console.WriteLine("------------");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student man = new Student("Фральцов Матвей", 2005, "ФИТ-231");
            Student man1 = new Student("Репин Артур", 2005, "ФИТ-231");

            Student woman = new Student("Романова Ангелина", 2004, "ФИТ-232");
            Student woman1 = new Student("Шумкова Римма", 2003, "МО-231");

            Student[] peoples = { man, man1, woman, woman1};

            Console.Write("Выберите критерий 1 или 2 (группа или год): ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");

            if (choice == 1)
            {
                Console.Write("Введите группу: ");
                string group = Console.ReadLine();
                Console.WriteLine("------------");
                foreach (Student student in peoples) { student.GroupSearch(group); } 
            }

            else if (choice == 2)
            {
                Console.Write("Введите год: ");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("------------");
                foreach (Student student in peoples) { student.YearSearch(year); }
            }
        }
    }    
}
