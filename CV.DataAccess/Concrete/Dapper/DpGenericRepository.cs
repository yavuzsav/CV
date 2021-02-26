using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CV.DataAccess.Interfaces;
using CV.Entities.Interfaces;
using Dapper.Contrib.Extensions;

namespace CV.DataAccess.Concrete.Dapper
{
    public class DpGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IDbConnection _dbConnection;

        public DpGenericRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
            _dbConnection.Open();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbConnection.GetAllAsync<TEntity>() as List<TEntity>;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbConnection.GetAsync<TEntity>(id: id);
        }

        public List<TEntity> GetAll()
        {
            return _dbConnection.GetAll<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbConnection.Get<TEntity>(id: id);
        }

        public void Insert(TEntity entity)
        {
            _dbConnection.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _dbConnection.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbConnection.Delete(entity);
        }
    }
}