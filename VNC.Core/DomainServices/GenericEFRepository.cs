using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

#if NET481
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif

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

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            Context = context;
            _dbSet = context.Set<TEntity>();


            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);

        }

        #endregion Constructors

        #region Public Methods

        #region All

        public virtual IEnumerable<TEntity> All()
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);


            var result = _dbSet.AsNoTracking().ToList();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);


            return result;
        }

        public virtual async Task<List<TEntity>> AllAsync()
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);


            var result = await _dbSet.AsNoTracking().ToListAsync();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);


            return result;
        }

        public virtual IEnumerable<TEntity> AllInclude(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);


            var result = GetAllIncluding(includeProperties).ToList();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);


            return result;
        }

        public virtual async Task<IEnumerable<TEntity>> AllIncludeAsync(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);


            var result = await GetAllIncluding(includeProperties).ToListAsync();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);


            return result;
        }

        #endregion All

        #region Find

        public virtual TEntity FindById(Int32 entityId)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE($"Enter entityId:({entityId})", Common.LOG_CATEGORY);


            var result = _dbSet.Find(entityId);


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE($"Exit", Common.LOG_CATEGORY, startTicks);


            return result;
        }

        public virtual async Task<TEntity> FindByIdAsync(Int32 entityId)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE($"(GenericEFRepository) Enter entityId:({entityId})", Common.LOG_CATEGORY);


            var result = await _dbSet.FindAsync(entityId);


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);


            return result;
        }

        public virtual IEnumerable<TEntity> FindBy(
            Expression<Func<TEntity, Boolean>> predicate)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE($"Enter", Common.LOG_CATEGORY);


            var results = _dbSet.AsNoTracking().Where(predicate).ToList();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);


            return results;
        }

        public virtual async Task<IEnumerable<TEntity>> FindByAsync(
            Expression<Func<TEntity, Boolean>> predicate)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);


            var results = await _dbSet.AsNoTracking().Where(predicate).ToListAsync();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);


            return results;
        }

        public virtual IEnumerable<TEntity> FindByInclude(
            Expression<Func<TEntity, Boolean>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);


            var query = GetAllIncluding(includeProperties);
            var results = query.Where(predicate).ToList();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);


            return results;
        }

        public virtual async Task<IEnumerable<TEntity>> FindByIncludeAsync(
            Expression<Func<TEntity, Boolean>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);


            var query = GetAllIncluding(includeProperties);
            var results = await query.Where(predicate).ToListAsync();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);


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

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);

            _dbSet.Add(entity);


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);

        }

        public virtual void Remove(TEntity entity)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);

            _dbSet.Remove(entity);


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);

        }

        #endregion Insert

        #region Update

        public virtual Boolean HasChanges()
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);


            var result = Context.ChangeTracker.HasChanges();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE($"Exit ({result})", Common.LOG_CATEGORY, startTicks);


            return result;
        }

        public virtual void Update()
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);


            Context.SaveChanges();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);

        }

        public virtual async Task UpdateAsync()
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);


            await Context.SaveChangesAsync();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);

        }

        // NOTE(crhodes)
        // Not sure why these exist.  Causes problems if use Add and then call this with Entity

        //        public void Update(TEntity entity)
        //        {
        //
        //            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
        //
        //            _dbSet.Attach(entity);
        //            Context.Entry(entity).State = EntityState.Modified;
        //            Context.SaveChanges();

        //
        //            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
        //
        //        }

        //        public async Task UpdateAsync(TEntity entity)
        //        {
        //
        //            Int64 startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
        //
        //            _dbSet.Attach(entity);
        //            Context.Entry(entity).State = EntityState.Modified;
        //            await Context.SaveChangesAsync();

        //
        //            Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
        //
        //        }

        #endregion Update

        #endregion Public Methods

        #region Private Methods

        private IQueryable<TEntity> GetAllIncluding(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);

            IQueryable<TEntity> queryable = _dbSet.AsNoTracking();


            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);


            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }

        #endregion Private Methods
    }
}
