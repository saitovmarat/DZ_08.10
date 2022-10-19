﻿using System;
using System.Collections;
using System.Collections.Generic;


namespace Черновик1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student( "Петров", "Петр", "10.10.2000", 100, 150) },
                { 2, new Student( "Иванов", "Иван", "12.09.2003", 120, 80) },
                { 3, new Student( "Сидоров", "Сидор", "14.05.2001", 155, 165) }

            };

            foreach (KeyValuePair<int, Student> p in students)
            {
                Console.WriteLine($"Студент Id: {p.Key} " +
                                    $"\n   Фамилия: {p.Value.Family} " +
                                    $"\n   Имя: {p.Value.Name} " +
                                    $"\n   Год рождения: {p.Value.DOB.ToShortDateString()} " +
                                    $"\n   Входной балл: {p.Value.EntranceMark} " +
                                    $"\n   Баллы: {p.Value.Mark}");
            }

            Console.Read();
        }

        class Student
        {
            public string Family { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public int EntranceMark { get; set; }
            public int Mark { get; set; }


            public Student(string f, string n, string d, int e = 0, int m = 0)
            {
                Family = f;
                Name = n;
                DOB = DateTime.Parse(d);
                EntranceMark = e;
                Mark = m;
            }
        }
    }
}
