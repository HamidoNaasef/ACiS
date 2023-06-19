using ACiS.DBContext;

namespace ACiS.Models.Repository
{
    public class AuthorietyRepo : IRepository<Authority>
    {
        ApplicationDBContext database;

        public AuthorietyRepo (ApplicationDBContext _database)
        {
            this.database = _database;
        }
        public void Add(Authority entity)
        {
            database.authorities.Add(entity);
            database.SaveChanges();
        }

        public void Delete(int id)
        {
            var auth = Find(id);
            database.authorities.Remove(auth);
            database.SaveChanges();
        }

        public void Update(Authority auth)
        {
            database.authorities.Update(auth);
            database.SaveChanges();
        }
        public Authority Find(int id)
        {
            var auth = database.authorities.SingleOrDefault(a => a.Id == id);
            return auth;
        }

        public IList<Authority> List()
        {
            var authoritiesList = database.authorities.ToList();
            return authoritiesList;
        }

        public IList<Authority> Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
