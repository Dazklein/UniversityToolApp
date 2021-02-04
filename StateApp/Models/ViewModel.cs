using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StateApp.Models
{
    public class ViewModel
    {
        public class Person
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public string MiddleName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Adress { get; set; }
            public virtual string Password { get; set; }

            public string GetFullName()
            {
                return this.LastName + ' ' + this.Name + ' ' + this.MiddleName;
            }
        }

        public class Student : Person
        {
            public int StudentId { get; set; }
            public int GroupId { get; set; }
            public virtual Group Group { get; set; }
        }

        public class Group
        {
            public int GroupId { get; set; }
            public string Name { get; set; }
        }

        public class Discipline
        {
            public int DisciplineId { get; set; }
            public string Name { get; set; }
            public IEnumerable<Group> Groups { get; set; }
            public IEnumerable<Professor> Professors { get; set; }
        }

        public class Lesson
        {
            public int LessonId { get; set; }
            public DateTime LessonDate { get; set; }
            public IEnumerable<Group> Groups { get; set; }
            public Discipline Discipline { get; set; }
            public Professor Professor { get; set; }
        }

        public class Mark
        {
            public int MarkId { get; set; }
            public int LessonId { get; set; }
            public int StudentId { get; set; }
        }

        public class Professor : Person
        {
            public int ProfessorId { get; set; }
            public int MyProperty { get; set; }
            public override string Password { get; set; }
            public IEnumerable<Discipline> Disciplines { get; set; }
            public IEnumerable<Lesson> Lessons { get; set; }
        }

        public class FacultyEmployer : Person
        {
            public int FacultyEmployerId { get; set; }
            public override string Password { get; set; }
        }
    }
}
