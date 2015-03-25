using System;
using System.Collections.Generic;

namespace TestAutofac.Models
{
    public static class PopulateDate
    {
        public static IEnumerable<Student> GetStudents()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    Address = "Bogor",
                    BirthDate = new DateTime(1988, 05, 21),
                    FirstName = "Muhammad",
                    LastName = "Fansuri",
                    Id = 1
                },
                new Student()
                {
                    Address = "Bandung",
                    BirthDate = new DateTime(1990, 02, 01),
                    FirstName = "Mike",
                    LastName = "Mangini",
                    Id = 2
                },
                new Student()
                {
                    Address = "New Orleans",
                    BirthDate = new DateTime(1968, 11, 11),
                    FirstName = "Roger",
                    LastName = "Taylor",
                    Id = 3
                },
                new Student()
                {
                    Address = "London",
                    BirthDate = new DateTime(1928, 05, 21),
                    FirstName = "Freddie",
                    LastName = "Mercury",
                    Id = 4
                },
                new Student()
                {
                    Address = "Bojong",
                    BirthDate = new DateTime(1918, 03, 21),
                    FirstName = "Udin",
                    LastName = "Din",
                    Id = 5
                }
            };

            return students;
        }
    }
}