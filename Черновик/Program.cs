using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Черновик
{
    class Student
    {
        public string sec_name;
        public string name;
        public Student(string a, string b)
        {
            sec_name = a;
            name = b;
        }
        public Student() { }
    }
    class Other_info
    {
        public DateTime dob;
        public string exam;
        public int points;
        public Other_info(string d, string e, int p)
        {
            dob = DateTime.Parse(d);
            exam = e;
            points = p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Student, Other_info> students = new Dictionary<Student, Other_info>()
            {
                {new Student("Саитов", "Марат"), new Other_info("21.05.2004", "Информатика", 236) },
                {new Student("Маратов", "Саид"), new Other_info("24.02.2005", "Английский", 231) },
                {new Student("Прохоров", "Прохор"), new Other_info("14.01.2004", "Физика", 225) },
                {new Student("Нагимов", "Нагим"), new Other_info("22.02.2003", "Физика", 276) },
                {new Student("Халакаев", "Лакух"), new Other_info("11.04.2004", "Информатика", 216) },
                {new Student("Преколов", "Цукош"), new Other_info("14.11.2005", "Информатика", 186) },
                {new Student("Мраков", "Долшан"), new Other_info("12.02.2004", "Информатика", 289) },
                {new Student("Жамранов", "Жабраил"), new Other_info("30.12.2004", "Физика", 256) },
                {new Student("Кратов", "Пилан"), new Other_info("11.09.2004", "Информатика", 283) },
                {new Student("Ладов", "Кирон"), new Other_info("17.03.2003", "Английский", 272) },
                {new Student("Йодаев", "Валан"), new Other_info("07.07.2004", "Информатика", 259) }
            };


            Console.WriteLine("Напиши <<Новый студент>>, если хочешь добавить студентов.");
            Console.WriteLine("Напиши <<Удалить>>, если хочешь удалить студента.");
            Console.WriteLine("Напиши <<Сортировать>>, если хочешь отсортировать студентов по баллам по возрастанию.");
            Console.WriteLine("Напиши <<Стоп>>, если хочешь остановиться.");
            int n = 1;
            while (n == 1)
            {
                string answer = Console.ReadLine();
                if (answer == "Новый студент")
                {
                    Console.WriteLine("Напиши информацию о нем по порядку: Фамилия, Имя, Дата Рождения, Экзамен, с которым он поступил и его общий балл по всем предметам");
                    string answ_sec_name = Console.ReadLine();
                    string answ_name = Console.ReadLine();
                    string aob = Console.ReadLine();
                    string exam_of_stud = Console.ReadLine();
                    int points_stud = int.Parse(Console.ReadLine());
                    students.Add();//(answ_sec_name, answ_name, aob, exam_of_stud, points_stud);
                }
                else if (answer == "Удалить")
                {
                    Console.WriteLine("Введи фамилию и Имя человека которого хочешь удалить");
                    string fam = Console.ReadLine();
                    string nam = Console.ReadLine();
                    students.Remove(); //();

                }
                else if (answer == "Сортировать")
                {
                    foreach (var numb in students.Values)
                    {

                    }
                }
                else if (answer == "Стоп")
                {
                    n--;
                }
            }
                
        }
    }
}
