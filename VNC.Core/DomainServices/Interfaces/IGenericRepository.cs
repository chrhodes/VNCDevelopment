using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VNC.Core.DomainServices
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        #region Query

        IEnumerable<TEntity> All();

        Task<List<TEntity>> AllAsync();

        IEnumerable<TEntity> AllInclude(params Expression<Func<TEntity, 
            object>>[] includeProperties);

        Task<IEnumerable<TEntity>> AllIncludeAsync(params Expression<Func<TEntity,
            object>>[] includeProperties);
 
        TEntity FindById(Int32 entityId);

        Task<TEntity> FindByIdAsync(Int32 entityId);

        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, Boolean>> predicate);

        Task<IEnumerable<TEntity>> FindByAsync(Expression<Func<TEntity, Boolean>> predicate);

        IEnumerable<TEntity> FindByInclude(Expression<Func<TEntity, Boolean>> predicate, 
            params Expression<Func<TEntity, object>>[] includeProperties);

        Task<IEnumerable<TEntity>> FindByIncludeAsync(Expression<Func<TEntity, Boolean>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties);

        #endregion

        #region Add/Remove

        void Add(TEntity entity);

        void Remove(TEntity entity);

        #endregion

        #region Update

        Boolean HasChanges();

        void Update();

        //void Update(TEntity entity);

        Task UpdateAsync();

        //Task UpdateAsync(TEntity entity);

        #endregion
    }
}
