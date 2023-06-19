using ACiS.Models;
using Microsoft.EntityFrameworkCore;

namespace ACiS.DBContext
{
    public class ApplicationDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //base.OnConfiguring(options);
            //options.UseSqlServer(@"Data Source=sqlsrv05;Initial Catalog=ACiS;Integrated Security=True;TrustServerCertificate=True;");
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;");
        }

        public DbSet<Authority> authorities { get; set; }
        
        public DbSet<City> citys { get; set; }

        public DbSet<Country> countrys { get; set; }

        public DbSet<Department> departments { get; set; }

        public DbSet<Division> divisions { get; set; }

        public DbSet<Faculity> faculities { get; set; }

        public DbSet<GradingCriteria> gradingCriterias { get; set; }

        public DbSet<GuestProfesor> guestProfesors { get; set; }

        public DbSet<Position> positions { get; set; }

        public DbSet<Professor> Professors { get; set; }

        public DbSet<SchoolYear> schoolYears { get; set; }

        public DbSet<Specialty> specialtys { get; set; }

        public DbSet<Stage> stages { get; set; }

        public DbSet<Status> status { get; set; }
        
        public DbSet<Student> students { get; set; }

        public DbSet<StudentData> studentsData { get; set; }

        public DbSet<StudentExamData> studentExams { get; set; }
        
        public DbSet<Subject> subjects { get; set; }

        public DbSet<SubjectData> subjectsdata { get; set; }

        public DbSet<SubjectProff> subjectProffs { get; set; }

        public DbSet<SubjectsMarks> subjectsMarks { get; set; }

        public DbSet<User> users { get; set; }




    }
}
