using ACiS.DBContext;
using System.Diagnostics;

namespace ACiS.Models.Repository
{
    public class GradingRepo: IRepository<GradingCriteria>
    {
        ApplicationDBContext database;

        public GradingRepo(ApplicationDBContext _database)
        {
            this.database = _database;
        }
        public void Add(GradingCriteria entity)
        {
            database.gradingCriterias.Add(entity);
            database.SaveChanges();
        }

        public void Delete(int id)
        {
            var grade = Find(id);
            database.gradingCriterias.Remove(grade);
            database.SaveChanges();
        }

        public void Update(GradingCriteria grade)
        {
            database.gradingCriterias.Update(grade);
            database.SaveChanges();
        }
        public GradingCriteria Find(int id)
        {
            var grade = database.gradingCriterias.SingleOrDefault(u => u.Id == id);
            return grade;
        }

        public IList<GradingCriteria> List()
        {
            var gradingList = database.gradingCriterias.ToList();
            return gradingList;
        }

        public IList<GradingCriteria> Search(string name)
        {
            var grade = database.gradingCriterias.Where(g => g.Name == name).ToList();
            return grade;
        }
    }
}
