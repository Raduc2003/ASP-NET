using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace WebApplication3.Controllers
{ [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
       public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Year { get; set; }
            public string Domain { get; set; }
        }
        public static List<Student> students { get; set; } = new List<Student>()
            {


                new Student { FirstName = "John", LastName = "Doe", Year = 1, Domain = "Computer Science" },
                new Student { FirstName = "Jane", LastName = "Smith", Year = 2, Domain = "Mechanical Engineering" },
                new Student { FirstName = "Alice", LastName = "Johnson", Year = 3, Domain = "Electrical Engineering" },
                new Student { FirstName = "Bob", LastName = "Williams", Year = 4, Domain = "Civil Engineering" },
            };
        [HttpGet]
        public List <Student> GetStudents()
        {

            return students;
        }

        [HttpPost]
        public List<Student> PostStudent(Student student)
        {
            students.Add(student);
            return students;
        }
        [HttpPut]
        public void PutStudent(string name,string newFirstName, string newLastName)
        {
/*            students.Find(x => x.LastName==(name));
 *            
*/             for (int i = 0; i < students.Count; i++)
            {
                if (students[i].LastName == name)
                {
                    students[i].LastName = newLastName;
                    students[i].FirstName = newFirstName;
                }
            }


        }
        [HttpDelete] 
        public string DeleteStudent(string firstName, string lastName) 
        {
            int cnt = 0;
            for (int i = 0; i < students.Count; i++)
            {   
                if (students[i].LastName == lastName && students[i].FirstName==firstName)
                {
                    students.RemoveAt(i);
                    cnt += 1;
                }
            }
            if (cnt == 0) return "Student not found!";
            else return "succes";

        }
    }
}
