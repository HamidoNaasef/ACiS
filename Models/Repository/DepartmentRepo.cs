using ACiS.DBContext;

namespace ACiS.Models.Repository
{
    public class DepartmentRepo : IRepository<Department>
    {
        ApplicationDBContext database;

        public DepartmentRepo(ApplicationDBContext _database)
        {
            this.database = _database;
        }
        public void Add(Department entity)
        {
            database.departments.Add(entity);
            database.SaveChanges();
        }

        public void Delete(int id)
        {
            var dep = Find(id);
            database.departments.Remove(dep);
            database.SaveChanges();
        }

        public void Update(Department dep)
        {
            database.departments.Update(dep);
            database.SaveChanges();
        }
        public Department Find(int id)
        {
            var dep = database.departments.SingleOrDefault(u => u.Id == id);
            return dep;
        }

        public IList<Department> List()
        {
            var deparmentList = database.departments.ToList();
            return deparmentList;
        }

        public IList<Department> Search(string name)
        {
            var deps = database.departments.Where(d=> d.ArabicName == name).ToList();
            return deps;
        }
        public IList<Department> SearchByAcademicCode(int code)
        {
            var deps = database.departments.Where(d=> d.AcademicCode == code).ToList();
            return deps;
        }
    }
}
