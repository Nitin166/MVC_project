using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public class StudentReposatory : IStudentReposatory
    {
       public static List<Student> lstStudent;
            static StudentReposatory()
        {
            lstStudent= new List<Student>();
            lstStudent.Add(new Student() { Id = 1, Name = "Nikki", Class = 1, FavouriteSub="maths" });
            lstStudent.Add(new Student() { Id = 2, Name = "Alisha", Class = 2, FavouriteSub="eng" });
            lstStudent.Add(new Student() { Id = 3, Name = "Nitin", Class = 3, FavouriteSub="sst" });
            lstStudent.Add(new Student() { Id = 4, Name = "Vishal", Class = 4, FavouriteSub="maths" });
            lstStudent.Add(new Student() { Id = 5, Name = "Mohan", Class = 5, FavouriteSub="hindi" });

            lstStudent.Add(new Student() { Id = 6, Name = "komal", Class = 6, FavouriteSub="IT" });


        }
        public void DeleteStudent(int Id)
        {
            var std = lstStudent.First(item => item.Id== Id);
            lstStudent.Remove(std);
        }

        public List<Student> GetAllStudent()
        {
            return lstStudent;
        }

        public Student GetById(int Id)
        {
            return lstStudent.First(item => item.Id==Id);
        }

        public void InsertStudent(Student student)
        {
            lstStudent.Add(student);
        }

        public void UpdateStudent(int Id, Student student)
        {
            var std = lstStudent.First(item => item.Id == Id);
            std.Id = student.Id;
            std.Name = student.Name;
            std.Class = student.Class;
            std.FavouriteSub = student.FavouriteSub;

        }
    }
}
