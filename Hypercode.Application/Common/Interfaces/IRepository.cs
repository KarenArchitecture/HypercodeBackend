using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperty = null, bool tracked = false);
        T Get(Expression<Func<T, bool>> filter, string? includeProperty = null, bool tracked = false);
        bool Any(Expression<Func<T, bool>> filter);
        bool Add(T entity);
        bool Delete(T entity);
    }
}
