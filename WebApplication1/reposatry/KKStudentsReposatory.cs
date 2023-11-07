using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public class KKStudentsReposatory : IKKStudents
    {
        static List<KKStudents> studentslist;
       static KKStudentsReposatory()
        {
            studentslist = new List<KKStudents> ();

            studentslist.Add(new KKStudents() { RollNumber=1, StudentName="Nikki", Position=1, FavouriteSubject="maths", FavouriteTeacher="nitin" });
            studentslist.Add(new KKStudents() { RollNumber=2, StudentName="Nitin", Position=2, FavouriteSubject="Hindi", FavouriteTeacher="Aanchal" });
            studentslist.Add(new KKStudents() { RollNumber=3, StudentName="Vishal", Position=3, FavouriteSubject="Eng", FavouriteTeacher="sarite" });
            studentslist.Add(new KKStudents() { RollNumber=4, StudentName="Monu", Position=4, FavouriteSubject="Eng", FavouriteTeacher="tanuj" });

        }

        public void DeleteKKStudent(int RollNumber)
        {
            studentslist.First(item => item.RollNumber==RollNumber);
        }

        public KKStudents GetById(int RollNumber)
        {
            var student = studentslist.First(item => item.RollNumber==RollNumber);
            return student;
        }

        public List<KKStudents> GetKKStudents()
        {
            return studentslist;
        }

        public void InsertKKStudent(KKStudents KKstudent)
        {
            studentslist.Add(KKstudent);
        }

        public void UpdateKKStudent(int RollNumber, KKStudents KKstudent)
        {
          var std=  studentslist.First(item => item.RollNumber==RollNumber);
            std.RollNumber= KKstudent.RollNumber;
            std.StudentName= KKstudent.StudentName;
            std.Position= KKstudent.Position;
            std.FavouriteSubject= KKstudent.FavouriteSubject;
            std.FavouriteTeacher= KKstudent.FavouriteTeacher;
        }
    }
}
