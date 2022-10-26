using Ex_03_Project_Repo_Method.Models;
using Ex_03_Project_Repo_Method.Repoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Project_Repo_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepoCreator creator = new RepoCreator();
            var cr = creator.GetRepo<Course>();
            var c1 = new Course(1, "C#", 7000.00M);
            var c2 = new Course(2, "SQL", 6000.00M);
            var c3 = new Course(3, "UML", 4000.00M);
            cr.Add(c1);
            cr.Add(c2);
            cr.Add(c3);
            Console.WriteLine("Read");
            cr.Get()
                .ToList()
                .ForEach(x=> Console.WriteLine(x));
            Console.WriteLine("Update");
            c3.Fee = 4500.00M;
            cr.Update(c3);
            cr.Get()
               .ToList()
               .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Delete");
            cr.Delete(3);
            cr.Get()
              .ToList()
              .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("##########################################");
            var sr = creator.GetRepo<Student>();
            var s1 = new Student(1, "AA", 1);
            var s2 = new Student(2, "BB", 1);
            var s3 = new Student(3, "CC",2);
            sr.Add(s1);
            sr.Add(s2);
            sr.Add(s3);
            Console.WriteLine("Read");
            sr.Get()
                .ToList()
                .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Update");
            s2.CourseId = 2;
            sr.Update(s2);
            sr.Get()
               .ToList()
               .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Delete");
            sr.Delete(2);
            sr.Get()
              .ToList()
              .ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
