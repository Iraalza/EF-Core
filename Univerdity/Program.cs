using System;
using Univerdity.Data.Models;

namespace Univerdity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                var student = new Student();
                student.Name = "Вася";
                student.PhoneNumber = "999123456";
                student.RegistrationOn = DateTime.Now;

                context.Students.Add(student);

                context.Cources.Add(new Cource
                {
                    Name = "EF Core",
                    Price = 0,
                    Description = "Курс о разработке приложений работающих с БД",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(30)
                });

                context.SaveChanges();
            }
        }
    }
}
