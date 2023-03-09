using Microsoft.EntityFrameworkCore;

namespace LearningClassRelationsUsingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void InsertUSer()
            {
                var course = new Course();
                course.CourseName = "Physics";
                course.CourseName = "Maths";
                
                var course2 = new Course();
                course2.CourseName = "Chemistry";


                var Teacher = new Teacher();
                Teacher.Name = "Sami"; 
                Teacher.Courses = new List<Course>();
                Teacher.Courses.Add(course);
               
                Teacher.Name = "Rafi";
                Teacher.Courses = new List<Course>();
                Teacher.Courses.Add(course2);









                Teacher.Name = "zaki";
                


                var student = new Student();
                student.Name = "Ahsan";
                student.Name = "khizar";
                student.Name = "Ahmed";
            }
        }
    }
}