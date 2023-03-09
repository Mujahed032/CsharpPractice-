
using LearningClassRelationsUsingConsole;

InsertUser();
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
    var StudentShafi = new Student() { Name = "Shafi", courses = new List<Course>() { CourseTelugu, CourseSocial,CoursePhysics } };
    var StudentSameer = new Student() { Name = "Sameer", courses = new List<Course>() { CourseMaths, CourseHindi, CourseEnglish } };


    var _context = new DataContext();
    _context.Add(StudentRafi);
    _context.AddRange(new List<Student>() {StudentZaki, StudentAzeem, StudentShafi, StudentSameer});
    _context.AddRange(new List<Teacher>() { TeacherKhizar, TeacherAhmed, TeacherAhsan, TeacherAzhar });
    _context.SaveChanges();

}
