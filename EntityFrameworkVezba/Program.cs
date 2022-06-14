using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkVezba
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (var db = new LibraryContext())
            {
                Console.WriteLine("Adding some authors into database...");
                Author author1 = new Author("Roberto Bolano", Gender.MALE, new DateTime(1953, 4, 28), new DateTime(2003, 7, 15));
                Author author2 = new Author("J.K. Rowling", Gender.FEMALE, new DateTime(1965, 7, 31), null);

                db.Authors.Add(author1);
                db.Authors.Add(author2);
                db.SaveChanges();

                foreach(var author in db.Authors)
                {
                    Console.WriteLine(author);
                    Console.WriteLine("----------------------------");
                }

            }*/


            using (var db=new CompanyContext())
            {
                Console.WriteLine("Adding some workers into database...");
                Worker w1 = new Worker { Id="1",FirstName = "Alan", LastName = "Ford", Age = 33, BirthDay = new DateTime(1987, 1, 1), PhoneNumber = "063111222", Salary = 500 };
                Worker w2 = new Worker { Id="2",FirstName = "Bob", LastName = "Rock", Age = 42, BirthDay = new DateTime(1978, 3, 3), PhoneNumber = "063333444", Salary = 500 };
                db.Workers.Add(w1);
                db.Workers.Add(w2);
                db.SaveChanges();

                Console.WriteLine("Adding some projects into database...");
                Project p1 = new Project { Name = "Secret project 1", StartDate = DateTime.Now, FinishDate = null, LeaderId = w1.Id };
                Project p2 = new Project { Name = "Secret project 2", StartDate = DateTime.Now, FinishDate = null, LeaderId = w2.Id };
                db.Projects.Add(p1);
                db.Projects.Add(p2);
                db.SaveChanges();

                Console.WriteLine("Adding some workerProjects into database...");
                WorkerProject wp1 = new WorkerProject { WorkerId = w2.Id, ProjectId = p1.Id, WorkHours = 40 };
                WorkerProject wp2 = new WorkerProject { WorkerId = w1.Id, ProjectId = p2.Id, WorkHours = 42 };
                db.WorkerProjects.Add(wp1);
                db.WorkerProjects.Add(wp2);
                db.SaveChanges();
            }
        }
    }
}
