using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Project_Repo_Factory.Models
{
    public interface IModelBase
    {
        int Id { get; set; }
    }
    public class Course : IModelBase
    {
        public Course() { }
        public Course(int id, string name, decimal fee)
        {
            this.Id = id;
            this.Name = name;
            this.Fee = fee;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Fee: {Fee:0.00}";
        }
    }
    public class Student : IModelBase
    {
        public Student() { }
        public Student(int id, string name, int courseId)
        {
            this.Id = id;
            this.Name = name;
            this.CourseId = courseId;
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
       
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Course Id: {CourseId}";
        }
    }
}
