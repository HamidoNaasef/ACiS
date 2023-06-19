using ACiS.DBContext;
using System.Linq;

namespace ACiS.Models.Repository
{
    public class SubjectRepo : IRepository<Subject>
    {
        ApplicationDBContext database;

        public SubjectRepo(ApplicationDBContext _database)
        {
            this.database = _database;
        }
        public void Add(Subject entity)
        {
            database.subjects.Add(entity);
            database.SaveChanges();
        }

        public void Delete(int id)
        {
            var sub = Find(id);
            database.subjects.Remove(sub);
            database.SaveChanges();
        }

        public void Update(Subject sub)
        {
            database.subjects.Update(sub);
            database.SaveChanges();
        }
        public Subject Find(int id)
        {
            var sub = database.subjects.SingleOrDefault(s => s.Id == id);
            return sub;
        }

        public IList<Subject> List()
        {
            var subjectList = database.subjects.ToList();
            return subjectList;
        }

        public IList<Subject> Search(string name)
        {
            var subjects = database.subjects.Where(s => s.ArabicName == name).ToList();
            return subjects;
        }
        public IList<Subject> SearchByAcademicCode(int code)
        {
            var subjects = database.subjects.Where(s => s.AcademicCode == code).ToList();
            return subjects;
        }
    }
}
