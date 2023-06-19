using ACiS.DBContext;

namespace ACiS.Models.Repository
{
    public class DivisionRepo : IRepository<Division>
    {
        ApplicationDBContext database;

        public DivisionRepo(ApplicationDBContext _database)
        {
            this.database = _database;
        }
        
        public void Add(Division entity)
        {
            database.divisions.Add(entity);
            database.SaveChanges();
        }

        public void Delete(int id)
        {
            var div = Find(id);
            database.divisions.Remove(div);
            database.SaveChanges();
        }

        public void Update(Division div)
        {
            database.divisions.Update(div);
            database.SaveChanges();
        }
        public Division Find(int id)
        {
            var div = database.divisions.SingleOrDefault(d => d.Id == id);
            
            var depId = database.divisions.Where(d => d.Id == id).
                Select(d => d.department.Id).SingleOrDefault();
            
            var newDep = database.departments.Find(depId);

            div.department = newDep;

            return div;
        }

        public IList<Division> List()
        {
            var divisionsList = database.divisions.ToList();

            IList<Division> list = new List<Division>();
            
            foreach(var division in divisionsList)
            {
               list.Add(Find(division.Id));
            }

            return list;
        }

        public IList<Division> Search(string name)
        {
            var divs = database.divisions.Where(d => d.ArabicName == name).ToList();
            return divs;
        }
        public IList<Division> SearchByAcademicCode(int code)
        {
            var divs = database.divisions.Where(d => d.AcademicCode == code).ToList();
            return divs;
        }
    }
}
