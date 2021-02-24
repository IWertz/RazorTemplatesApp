using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class StudentList
    {
        public List<Student> setList()
        {
            Student Isaiah = new Student();
            Isaiah.FirstName = "Isaiah";
            Isaiah.LastName = "Wertz";
            Isaiah.Grade = "A-";

            Student John = new Student();
            John.FirstName = "John";
            John.LastName = "Doe";
            John.Grade = "C";

            Student Adam = new Student();
            Adam.FirstName = "Adam";
            Adam.LastName = "Smith";
            Adam.Grade = "B+";

            var students = new List<Student>().ToList();
            students.Add(Isaiah);
            students.Add(John);
            students.Add(Adam);
            return students;
        }
    }
}
