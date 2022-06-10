using System.Collections.Generic;
using System.Linq;

namespace Cwiczenia11.Data
{
    public class StudentService : IStudentService
    {
        private List<Student> _students;

        public StudentService()
        {
            _students = new List<Student>()
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Jan",
                    LastName =  "Kowalski",
                    BirthDate = new System.DateTime(2000,1,1),
                    Studies = "IT",
                    Avatar = "https://img.freepik.com/free-photo/handsome-confident-smiling-man-with-hands-crossed-chest_176420-18743.jpg?w=2000"
                },

                new Student
                {
                    ID = 2,
                    FirstName = "Andrzej",
                    LastName =  "Jasinski",
                    BirthDate = new System.DateTime(2000,2,2),
                    Studies = "HR",
                    Avatar="https://img.freepik.com/darmowe-zdjecie/zblizenie-pewnosc-siebie-pracownika-plci-meskiej-w-bialej-koszuli-usmiechajac-sie-do-kamery-stojac-pewnosci-siebie-na-tle-studio_1258-26761.jpg?w=2000"
                },

                new Student
                {
                    ID = 3,
                    FirstName = "Michal",
                    LastName =  "Kapusta",
                    BirthDate = new System.DateTime(2000,4,5),
                    Studies = "MATHS",
                    Avatar="https://a.allegroimg.com/original/036640/a8c4d0194aba8847b0684823c5ea/Kapusta-glowiasta-biala-Slawa-z-Golebiewa-WARZYWA-Odmiana-Kapusta-biala"
                }
            };
        }
        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(s => s.ID == id);
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public bool Remove(int id)
        {
            return _students.Remove(_students.FirstOrDefault(s => s.ID == id));   
        }
    }
}
