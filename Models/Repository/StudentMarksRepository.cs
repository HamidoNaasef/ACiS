using ACiS.DBContext;

namespace ACiS.Models.Repository
{
    public class StudentMarksRepository : IRepository<SubjectsMarks>
    {
        ApplicationDBContext database;

        public StudentMarksRepository(ApplicationDBContext _database)
        {
            this.database = _database;
        }
        public void Add(SubjectsMarks entity)
        {
            database.subjectsMarks.Add(entity);
            database.SaveChanges();
        }

        public void Delete(int id)
        {
            var auth = Find(id);
            database.subjectsMarks.Remove(auth);
            database.SaveChanges();
        }

        public void Update(SubjectsMarks auth)
        {
            database.subjectsMarks.Update(auth);
            database.SaveChanges();
        }
        public SubjectsMarks Find(int id)
        {
            var auth = database.subjectsMarks.SingleOrDefault(a => a.Id == id);
            return auth;
        }

        public IList<SubjectsMarks> List()
        {
            var authoritiesList = database.subjectsMarks.ToList();
            return authoritiesList;
        }

        public IList<SubjectsMarks> Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
