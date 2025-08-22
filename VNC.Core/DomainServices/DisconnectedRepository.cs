using System;

#if NET481
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif

namespace VNC.Core.DomainServices
{
    public class DisconnectedRepository<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;

        public DisconnectedRepository(DbContext context)
        {

            Int64 startTicks = 0;
            if (Common.VNCLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);


            _context = context;
            _dbSet = context.Set<TEntity>();


            if (Common.VNCLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);

        }

        // TODO(crhodes)
        // Add stuff from Ninja or Claudius
        // This is for Web where there is not persistent context

    }
}
