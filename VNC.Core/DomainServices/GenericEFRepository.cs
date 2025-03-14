using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace VNC.Core.DomainServices
{
    public class GenericEFRepository<TEntity,TContext> : IGenericRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly TContext Context;

        internal DbSet<TEntity> _dbSet;

        #region Constructors

        public GenericEFRepository(TContext context)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif
            Context = context;
            _dbSet = context.Set<TEntity>();

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion Constructors

        #region Public Methods

        #region All

        public virtual IEnumerable<TEntity> All()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            var result = _dbSet.AsNoTracking().ToList();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual async Task<List<TEntity>> AllAsync()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            var result = await _dbSet.AsNoTracking().ToListAsync();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual IEnumerable<TEntity> AllInclude(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            var result = GetAllIncluding(includeProperties).ToList();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual async Task<IEnumerable<TEntity>> AllIncludeAsync(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            var result = await GetAllIncluding(includeProperties).ToListAsync();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        #endregion All

        #region Find

        public virtual TEntity FindById(Int32 entityId)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE($"Enter entityId:({entityId})", Common.LOG_CATEGORY);
#endif

            var result = _dbSet.Find(entityId);

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE($"Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual async Task<TEntity> FindByIdAsync(Int32 entityId)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE($"(GenericEFRepository) Enter entityId:({entityId})", Common.LOG_CATEGORY);
#endif

            var result = await _dbSet.FindAsync(entityId);

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual IEnumerable<TEntity> FindBy(
            Expression<Func<TEntity, Boolean>> predicate)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE($"Enter", Common.LOG_CATEGORY);
#endif

            var results = _dbSet.AsNoTracking().Where(predicate).ToList();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return results;
        }

        public virtual async Task<IEnumerable<TEntity>> FindByAsync(
            Expression<Func<TEntity, Boolean>> predicate)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            var results = await _dbSet.AsNoTracking().Where(predicate).ToListAsync();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return results;
        }

        public virtual IEnumerable<TEntity> FindByInclude(
            Expression<Func<TEntity, Boolean>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            var query = GetAllIncluding(includeProperties);
            var results = query.Where(predicate).ToList();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return results;
        }

        public virtual async Task<IEnumerable<TEntity>> FindByIncludeAsync(
            Expression<Func<TEntity, Boolean>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            var query = GetAllIncluding(includeProperties);
            var results = await query.Where(predicate).ToListAsync();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return results;
        }

        // This is not part of the interface but left to show the technique

        //public TEntity FindByKey(Int32 id)
        //{
        //    return _dbSet.Find(id);
        //    // This handles <Entity>Id style keys, e.g. CustomerId
        //    //Expression<Func<TEntity, Boolean>> lambda = Utilities.BuildLambdaForFindByKey<TEntity>(id);
        //    //return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        //}

        #endregion

        #region Add/Remove

        public virtual void Add(TEntity entity)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif
            _dbSet.Add(entity);

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public virtual void Remove(TEntity entity)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif
            _dbSet.Remove(entity);

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion Insert

        #region Update

        public virtual Boolean HasChanges()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            var result = Context.ChangeTracker.HasChanges();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE($"Exit ({result})", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual void Update()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            Context.SaveChanges();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public virtual async Task UpdateAsync()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            await Context.SaveChangesAsync();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        // NOTE(crhodes)
        // Not sure why these exist.  Causes problems if use Add and then call this with Entity

        //        public void Update(TEntity entity)
        //        {
        //#if LOGGING
        //            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
        //#endif
        //            _dbSet.Attach(entity);
        //            Context.Entry(entity).State = EntityState.Modified;
        //            Context.SaveChanges();

        //#if LOGGING
        //            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
        //#endif
        //        }

        //        public async Task UpdateAsync(TEntity entity)
        //        {
        //#if LOGGING
        //            Int64 startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
        //#endif
        //            _dbSet.Attach(entity);
        //            Context.Entry(entity).State = EntityState.Modified;
        //            await Context.SaveChangesAsync();

        //#if LOGGING
        //            Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
        //#endif
        //        }

        #endregion Update

        #endregion Public Methods

        #region Private Methods

        private IQueryable<TEntity> GetAllIncluding(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif
            IQueryable<TEntity> queryable = _dbSet.AsNoTracking();

#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }

        #endregion Private Methods
    }
}
