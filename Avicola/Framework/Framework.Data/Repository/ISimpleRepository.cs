using System;
using System.Linq;
using System.Linq.Expressions;
using Framework.Data.Helpers;
using Framework.Data.Interfaces;

namespace Framework.Data.Repository
{
    public interface ISimpleRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> whereClause,params Expression<Func<T, object>>[] includes);
        PagedResultList<T> GetAll(PagingCriteria paging, params Expression<Func<T, object>>[] includes);
        PagedResultList<T> GetAll(PagingCriteria paging, Expression<Func<T, bool>> whereClause, params Expression<Func<T, object>>[] includes);
        T Get(Expression<Func<T, bool>> whereClause, params Expression<Func<T, object>>[] includes);
        void Add(T entity);
        void Edit(T entity);
        bool Commit();
    }
}
