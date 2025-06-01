using Newtonsoft.Json;
using CarDealership.Entities;
using CarDealership.Interfaces;

namespace CarDealership.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        private readonly string _filePath;

        protected List<TEntity> _entities;

        public BaseRepository(string filePath)
        {
            _filePath = filePath;

            if (!File.Exists(_filePath))
            {
                _entities = new List<TEntity>();
                SaveAll(_entities);
            }

            _entities = GetAll();
        }

        public int NextId => _entities.Count + 1;

        public IEnumerable<TEntity> Entities => _entities;

        protected List<TEntity> GetAll()
        {
            var json = File.ReadAllText(_filePath);

            return JsonConvert.DeserializeObject<List<TEntity>>(json) ?? new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
            SaveAll(_entities);
        }

        public void Update(TEntity entity)
        {
            var index = _entities.FindIndex(e => e.Id == entity.Id);
            _entities[index] = entity;
            SaveAll(_entities);
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
            SaveAll(_entities);
        }

        private void SaveAll(IEnumerable<TEntity> entities)
        {
            var json = JsonConvert.SerializeObject(entities, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
