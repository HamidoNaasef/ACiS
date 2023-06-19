namespace ACiS.Models.Repository
{
    public interface IRepository<TEntity>
    {

        public IList<TEntity> List();

        public TEntity Find(int id);

        public void Add(TEntity entity);

        public void Update(TEntity entity);

        public void Delete(int id);

        public IList<TEntity> Search(string term);

    }
}
