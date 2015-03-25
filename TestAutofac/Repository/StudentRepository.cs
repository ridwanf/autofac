using System.Collections.Generic;
using TestAutofac.Models;

namespace TestAutofac.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetStudents()
        {
            return PopulateDate.GetStudents();
        }
    }
}