using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StateApp.Models.ViewModel;

namespace StateApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<FacultyEmployer> FacultyEmployers { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StatementDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student[]
                {
                new Student { StudentId = 1, Name = "Дмитрий", LastName = "Хлебов", MiddleName = "Иванович", GroupId = 1, Email = "q1@uni.com", PhoneNumber = "85655264655", Adress = "Партизанова, 3, 76", Password = "" },
                new Student { StudentId = 2, Name = "Василий", LastName = "Пивоваров", MiddleName = "Васильевич", GroupId = 1, Email = "qds@uni.com", PhoneNumber = "85367456655", Adress = "Гоголя, 235, 45", Password = "" },
                new Student { StudentId = 3, Name = "Ирина", LastName = "Носова", MiddleName = "Павловна", GroupId = 1, Email = "ee1@uni.com", PhoneNumber = "85656534655", Adress = "Некрасова, 87, 3", Password = "" },
                new Student { StudentId = 4, Name = "Мария", LastName = "Мастишева", MiddleName = "Александровна", GroupId = 1, Email = "q2d2@uni.com", PhoneNumber = "85656634655", Adress = "Гагарина, 43, 34", Password = "" },
                new Student { StudentId = 5, Name = "Иван", LastName = "Некрасов", MiddleName = "Викторович", GroupId = 1, Email = "dsad3@uni.com", PhoneNumber = "85776334655", Adress = "Чевапина, 12, 1", Password = "" },

                new Student { StudentId = 6, Name = "Игнат", LastName = "Иванов", MiddleName = "Николаевич", GroupId = 2, Email = "rere3@uni.com", PhoneNumber = "85656334455", Adress = "Серебренова, 10, 1", Password = "" },
                new Student { StudentId = 7, Name = "Александр", LastName = "Дажницев", MiddleName = "Александров", GroupId = 2, Email = "22a@uni.com", PhoneNumber = "85656566655", Adress = "Иванова, 75, 43", Password = "" },
                new Student { StudentId = 8, Name = "Юлия", LastName = "Кулишева", MiddleName = "Ивановна", GroupId = 2, Email = "dsdd344@uni.com", PhoneNumber = "85736334655", Adress = "Летчиков, 1, 12", Password = "" },
                new Student { StudentId = 9, Name = "Николай", LastName = "Киселев", MiddleName = "Васильевич", GroupId = 2, Email = "6a@uni.com", PhoneNumber = "85656654655", Adress = "Пупыркина, 64, 2", Password = "" },
                new Student { StudentId = 10, Name = "Василий", LastName = "Лебедев", MiddleName = "Вадимович", GroupId = 2, Email = "s6d@uni.com", PhoneNumber = "85435334655", Adress = "Музыкантов, 30, 4", Password = "" },

                new Student { StudentId = 11, Name = "Андрей", LastName = "Малахов", MiddleName = "Андреевич", GroupId = 3, Email = "snhj@uni.com", PhoneNumber = "85656765655", Adress = "Ляшкина, 95, 134", Password = "" },
                new Student { StudentId = 12, Name = "Александр", LastName = "Кирилкин", MiddleName = "Петрович", GroupId = 3, Email = "ikh@uni.com", PhoneNumber = "85656300655", Adress = "Музыкантов, 30, 5", Password = "" },
                new Student { StudentId = 13, Name = "Екатерина", LastName = "Крюкова", MiddleName = "Владиславовна", GroupId = 3, Email = "oth6@uni.com", PhoneNumber = "80006334655", Adress = "Зайцева, 263, 144", Password = "" },
                new Student { StudentId = 14, Name = "Дарья", LastName = "Нажмычкина", MiddleName = "Александровна", GroupId = 3, Email = "pp9h@uni.com", PhoneNumber = "85656383055", Adress = "Мелодичная, 57, 5", Password = "" },
                new Student { StudentId = 15, Name = "Анастасия", LastName = "Темная", MiddleName = "Алексеевна", GroupId = 3, Email = "bbgt5@uni.com", PhoneNumber = "85606034655", Adress = "Васильева, 52, 1", Password = "" }
                });
            modelBuilder.Entity<Group>().HasData(
                new Group[]
                {
                    new Group { GroupId = 1, Name = "Г01" },
                    new Group { GroupId = 2, Name = "Г02" },
                    new Group { GroupId = 3, Name = "Г03" }
                });
            modelBuilder.Entity<Discipline>().HasData(
                new Discipline[]
                {
                    new Discipline { DisciplineId = 1, Name = "Линейная алгебра", Groups = null, Professors = null },
                    new Discipline { DisciplineId = 2, Name = "Математический анализ", Groups = null, Professors = null },
                    new Discipline { DisciplineId = 3, Name = "Философия", Groups = null, Professors = null },
                    new Discipline { DisciplineId = 4, Name = "Физическая культура", Groups = null, Professors = null },
                    new Discipline { DisciplineId = 5, Name = "Экономика", Groups = null, Professors = null },
                    new Discipline { DisciplineId = 6, Name = "Социология", Groups = null, Professors = null },
                    new Discipline { DisciplineId = 7, Name = "Дискретная математика", Groups = null, Professors = null },
                    new Discipline { DisciplineId = 8, Name = "История", Groups = null, Professors = null },
                    new Discipline { DisciplineId = 9, Name = "Иностранный язык", Groups = null, Professors = null }
                });
            modelBuilder.Entity<Professor>().HasData(
                new Professor[]
                {
                    new Professor { ProfessorId = 1, LastName = "Павлов", Name = "Сергей", MiddleName = "Павлович", Disciplines = null, Lessons = null, Adress = "Кожевина, 3, 12", Email = "kir3@uni.com", PhoneNumber = "85233495942", Password = "" },
                    new Professor { ProfessorId = 2, LastName = "Кучкин", Name = "Виталий", MiddleName = "Сергеевич", Disciplines = null, Lessons = null, Adress = "Ленина, 56, 51", Email = "fp3@uni.com", PhoneNumber = "86368759673", Password = "" },
                    new Professor { ProfessorId = 3, LastName = "Утехин", Name = "Валерий", MiddleName = "Михайлович", Disciplines = null, Lessons = null, Adress = "Булгакова, 1, 1", Email = "kpf@uni.com", PhoneNumber = "895775874932", Password = "" },
                    new Professor { ProfessorId = 4, LastName = "Пушинская", Name = "Ирина", MiddleName = "Эльдаровна", Disciplines = null, Lessons = null, Adress = "Гагарина, 164, 34", Email = "pczx2@uni.com", PhoneNumber = "89587493746", Password = "" }
                });
            modelBuilder.Entity<FacultyEmployer>().HasData(
                new FacultyEmployer[]
                {
                    new FacultyEmployer { FacultyEmployerId = 1, Email = "admin1@uni.com", Password = "admin1", LastName = "Иванов", Name = "Иван", MiddleName = "Иванович", Adress = "Центральная, 1, 12", PhoneNumber = "89477382211" },
                    new FacultyEmployer { FacultyEmployerId = 2, Email = "admin2@uni.com", Password = "admin2", LastName = "Михаилов", Name = "Михаил", MiddleName = "Михайлович", Adress = "Центральная, 2, 21", PhoneNumber = "89478887732" }
                }
                );
        }
    }

}
