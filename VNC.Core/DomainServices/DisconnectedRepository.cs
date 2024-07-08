using System;
using System.Data.Entity;

namespace VNC.Core.DomainServices
{
    public class DisconnectedRepository<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;

        public DisconnectedRepository(DbContext context)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif

            _context = context;
            _dbSet = context.Set<TEntity>();

#if LOGGING
            if (Common.VNCLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        // TODO(crhodes)
        // Add stuff from Ninja or Claudius
        // This is for Web where there is not persistent context

    }
}
