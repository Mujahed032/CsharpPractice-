
using LearningClassRelationsUsingConsole;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

var _context = new DataContext();

var studentsWhoTookPhysicsCourse = GetAllStudentsByCourseName("physics");
ICollection<Student> GetAllStudentsByCourseName(string CourseName)
{
    var course = _context.courses.Include(c => c.students).Where(c => c.CourseName == CourseName).FirstOrDefault();
    return course.students;

    //One more way
    //var courses = _context.courses.Include(c => c.students);
    //foreach (var oneCourse in courses)
    //{
    //    if (oneCourse.CourseName == CourseName)
    //  {
    //        return oneCourse.students;
    //    }
    //}

}
var GetSameerCourses = GetAllCoursesByStudentName("Sameer");

ICollection<Course> GetAllCoursesByStudentName(string StudentName)
{
    var student = _context.students.Include(c => c.courses).Where(c => c.Name == StudentName).FirstOrDefault();
    return student.courses;
}

//InsertUser();

var teachersWhoTeachMoreThanOneCourse = GetTeachersWhoTeachMoreThanOneCourse();
ICollection<Teacher> GetTeachersWhoTeachMoreThanOneCourse()
{
    var Teachers = _context.teachers.Include(t => t.Courses).Where(th => th.Courses.Count > 1).ToList();
    return Teachers;
}

var studentsWhoTakeMoreThanOneCourse = GetStudentsWhoTakeMoreThanOneCourse();
ICollection<Student> GetStudentsWhoTakeMoreThanOneCourse()
{
    var students = _context.students.Include(s => s.courses).Where(sh => sh.courses.Count > 1).ToList();
    return students;

}





void InsertUser()
{
    var CoursePhysics = new Course() { CourseName = "physics" };
    var CourseMaths = new Course() { CourseName = "Maths" };
    var CourseEnglish = new Course() { CourseName = "English" };
    var CourseSocial = new Course() { CourseName = "Social" };
    var CourseHindi = new Course() { CourseName = "Hindi" };
    var CourseTelugu = new Course() { CourseName = "Telugu" };
    var CourseChemistry = new Course() { CourseName = "Chemistry" };



    var TeacherKhizar = new Teacher() { Name = "Khizar", Courses = new List<Course>() { CoursePhysics } };
    var TeacherAhmed = new Teacher() { Name = "Ahmed", Courses = new List<Course>() { CourseMaths } };
    var TeacherAhsan = new Teacher() { Name = "Ahsan", Courses = new List<Course>() { CourseEnglish, CourseChemistry } };
    var TeacherAzhar = new Teacher() { Name = "Azhar", Courses = new List<Course>() { CourseSocial, CourseHindi, CourseTelugu } };


    var StudentRafi = new Student() { Name = "Rafi", courses = new List<Course>() { CoursePhysics } };
    var StudentZaki = new Student() { Name = "Zaki", courses = new List<Course>() { CourseMaths, CourseEnglish, CourseChemistry } };
    var StudentAzeem = new Student() { Name = "Azeem", courses = new List<Course>() { CourseHindi, CourseChemistry, CourseEnglish } };
    var StudentShafi = new Student() { Name = "Shafi", courses = new List<Course>() { CourseTelugu, CourseSocial, CoursePhysics } };
    var StudentSameer = new Student() { Name = "Sameer", courses = new List<Course>() { CourseMaths, CourseHindi, CourseEnglish } };



    _context.Add(StudentRafi);
    _context.AddRange(new List<Student>() { StudentZaki, StudentAzeem, StudentShafi, StudentSameer });
    _context.AddRange(new List<Teacher>() { TeacherKhizar, TeacherAhmed, TeacherAhsan, TeacherAzhar });
    _context.SaveChanges();


}
