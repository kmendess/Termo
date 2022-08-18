using System.Linq.Expressions;
using Termo.Domain.Models;

namespace Termo.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> where);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Delete(Guid id);
    }
}
