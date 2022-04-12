using System;
using System.Linq;
using ForBD.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ForBD
{
    class Program
    {
        static void CreateTeacher(string name)
        {
            var context = new MethodicalWorksContext();
            context.Teachers.Add(new Teacher() {Name = name});
            context.SaveChanges();
        }

        static void RemoveTeacherById(int id)
        {
            var context = new MethodicalWorksContext();
            Teacher teacher = context.Teachers.FirstOrDefault(t => t.Id == id);
            context.Teachers.Remove(teacher);
            context.SaveChanges();
        }

        static void UpdateTeacherById(int id, string name)
        {
            var context = new MethodicalWorksContext();
            Teacher teacher = context.Teachers.FirstOrDefault(t => t.Id == id);
            teacher.Name = name;
            context.SaveChanges();
        }


        static void CreateDiscipline(string name, string speciality, int course)
        {
            var context = new MethodicalWorksContext();
            context.Disciplines.Add(new Discipline() {Name = name, Specialty = speciality, Course = course});
            context.SaveChanges();
        }

        static void RemoveDisciplineByName(string name)
        {
            var context = new MethodicalWorksContext();
            Discipline discipline = context.Disciplines.FirstOrDefault(d => d.Name.Equals(name));
            context.Disciplines.Remove(discipline);
            context.SaveChanges();
        }

        static void UpdateDisciplineById(int id, string name)
        {
            var context = new MethodicalWorksContext();
            Discipline discipline = context.Disciplines.FirstOrDefault(d => d.Id == id);
            discipline.Name = name;
            context.SaveChanges();
        }


        static void ShowTeachers()
        {
            var context = new MethodicalWorksContext();
            var teachers = context.Teachers.ToList();
            foreach (var item in teachers)
            {
                Console.WriteLine($"Id={item.Id}, Name={item.Name}");
            }
        }

        static void ShowDisciplines()
        {
            var context = new MethodicalWorksContext();
            var discplines = context.Disciplines.ToList();
            foreach (var item in discplines)
            {
                Console.WriteLine($"Id={item.Id}, Name={item.Name}, Speciality={item.Specialty}, Course={item.Course}");
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("1.Добавить учителя.");
            Console.WriteLine("2.Удалить учителя по ID.");
            Console.WriteLine("3.Обновить информацию об учителе по Id");
            Console.WriteLine("4.Показать всех учителей.");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("5.Добавить дисциплину.");
            Console.WriteLine("6.Удалить дисциплину по ее названию.");
            Console.WriteLine("7.Обновить информацию о дисциплине по ее id.");
            Console.WriteLine("8.Показать все дисциплины.");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("10.Выйти.");
        }


        static void Main(string[] args)
        {
            PrintMenu();
            int key = Int32.Parse(Console.ReadLine());
            do
            {
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Введите имя учителя:");
                        string createNameT = Console.ReadLine();
                        CreateTeacher(createNameT);
                        break;
                    case 2:
                        Console.WriteLine("Введите Id учителя:");
                        int deleteIdT = Int32.Parse(Console.ReadLine());
                        RemoveTeacherById(deleteIdT);
                        break;
                    case 3:
                        Console.WriteLine("Введите Id учителя:");
                        int updateIdT = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новое имя учителя:");
                        string updateNameT = Console.ReadLine();
                        UpdateTeacherById(updateIdT, updateNameT);
                        break;
                    case 4:
                        ShowTeachers();
                        break;
                    case 5:
                        Console.WriteLine("Введите название дисципилины:");
                        string createNameD = Console.ReadLine();
                        Console.WriteLine("Введите название специальности:");
                        string createSpecialityD = Console.ReadLine();
                        Console.WriteLine("Введите курс:");
                        int createCourseD = Int32.Parse(Console.ReadLine());
                        CreateDiscipline(createNameD, createSpecialityD, createCourseD);
                        break;
                    case 6:
                        Console.WriteLine("Введите название дисципилины:");
                        string removeNameD = Console.ReadLine();
                        RemoveDisciplineByName(removeNameD);
                        break;
                    case 7:
                        Console.WriteLine("Введите Id дисциплины:");
                        int updateIdD = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новое название дисциплины:");
                        string updateNameD = Console.ReadLine();
                        UpdateDisciplineById(updateIdD, updateNameD);
                        break;
                    case 8:
                        ShowDisciplines();
                        break;
                }

                PrintMenu();
                key = Int32.Parse(Console.ReadLine());
            } while (key != 10);
        }
    }
}