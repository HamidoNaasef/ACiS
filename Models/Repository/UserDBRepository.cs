
using ACiS.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ACiS.Models.Repository
{
    public class UserDBRepository : IRepository<User>
    {
        ApplicationDBContext database;

        public UserDBRepository(ApplicationDBContext _database)
        {
            this.database = _database;
        }

        public void Add(User entity)
        {
            database.users.Add(entity);
            database.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = Find(id);
            database.users.Remove(user);
            database.SaveChanges();
        }

        public void Update(User user)
        {
            database.users.Update(user);
            database.SaveChanges();
        }
        public User Find(int id)
        {
            var user = database.users.SingleOrDefault(u => u.Id == id);

            int authId = database.users.Where(u=> u.Id == user.Id).Select(u => u.authority.Id).SingleOrDefault();

            user.authority = database.authorities.SingleOrDefault(a=> a.Id == authId);

            return user;
        }
        public int FindByUserName(string userName)
        {
            var user = database.users.SingleOrDefault(u => u.Username == userName);

            int authId = database.users.Where(u=> u.Id == user.Id).Select(u => u.authority.Id).SingleOrDefault();

            user.authority = database.authorities.SingleOrDefault(a=> a.Id == authId);

            return user.Id;
        }

        public IList<User> List()
        {
            var usersList = database.users.ToList();
            return usersList;
        }

        public IList<User> Search(string name)
        {
            return database.users.ToList();
        }

        //login properties
        public bool Login(string _username, string _password) 
        {
            var user = database.users.SingleOrDefault(u => u.Username == _username);
            if ((user != null))
            {
                if (user.Password == _password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { 
                return false;
            }
        }
    }
}
