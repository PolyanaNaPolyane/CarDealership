using CarDealership.Entities;

namespace CarDealership.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : Entity
    {
        public IEnumerable<TEntity> Entities { get; }
        public int NextId { get; }
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
    }
}
