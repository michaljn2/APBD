using System.Collections.Generic;

namespace Cwiczenia11.Data
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public bool Remove(int id);
    }
}
