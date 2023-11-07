using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public interface IKKStudents
    {
        public List<KKStudents> GetKKStudents();
        public KKStudents GetById(int RollNumber);
        public void InsertKKStudent(KKStudents KKstudent);
        public void DeleteKKStudent(int RollNumber);
        public void UpdateKKStudent(int RollNumber, KKStudents KKstudent);
    }
}
