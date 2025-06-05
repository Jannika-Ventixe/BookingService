using System.Linq.Expressions;
using Presentation.Models;

namespace Presentation.Data.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<RepositoryResult> AddAsync(TEntity entity);
        Task<RepositoryResult> AlreadyExistAsync(Expression<Func<TEntity, bool>> expression);
        Task<RepositoryResult<TResult>> DeleteAsync<TResult>(TEntity entity);
        Task<RepositoryResult<IEnumerable<TEntity>>> GetAllAsync(TEntity entity);
        Task<RepositoryResult<TEntity?>> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<RepositoryResult<TResult>> UpdateAsync<TResult>(TEntity entity);
    }
}