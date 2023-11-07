using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public interface IStudentReposatory
    {
        public List<Student> GetAllStudent();
        public Student GetById(int Id);
        public void InsertStudent(Student student);
        public void UpdateStudent( int Id,Student student);
        public void DeleteStudent(int Id);
        

    }
}
