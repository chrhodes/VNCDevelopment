using System;
using System.Linq.Expressions;

namespace VNC.Core.DomainServices
{
    public static class Utilities
    {
        public static Expression<Func<TEntity, Boolean>> BuildLambdaForFindByKey<TEntity>(Int32 id)
        {
            var item = Expression.Parameter(typeof(TEntity), "entity");
            var prop = Expression.Property(item, typeof(TEntity).Name + "Id");
            var value = Expression.Constant(id);
            var equal = Expression.Equal(prop, value);
            var lambda = Expression.Lambda<Func<TEntity, Boolean>>(equal, item);

            return lambda;
        }
    }
}
