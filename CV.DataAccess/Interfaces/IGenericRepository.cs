using System.Collections.Generic;
using System.Threading.Tasks;
using CV.Entities.Interfaces;

namespace CV.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}