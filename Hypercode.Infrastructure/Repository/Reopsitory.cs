using Hypercode.Application.Common.Interfaces;
using Hypercode.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        internal DbSet<T> Set;
        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            Set = context.Set<T>();
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperty = null, bool tracked = false)
        {
            IQueryable<T> query;
            if (tracked)
            {
                query = Set;
            }
            else
            {
                query = Set.AsNoTracking();
            }
            if (filter is not null)
            {
                query = query.Where(filter);
            }
            if (includeProperty is not null)
            {
                foreach (var include in includeProperty.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(include.Trim());
                }
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperty = null, bool tracked = false)
        {
            IQueryable<T> query;
            if (tracked)
            {
                query = Set;
            }
            else
            {
                query = Set.AsNoTracking();
            }

            if (filter is not null)
            {
                query = query.Where(filter);
            }
            if (includeProperty is not null)
            {
                foreach (var include in includeProperty.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(include.Trim());
                }
            }
            return query.ToList();
        }

        bool IRepository<T>.Add(T entity)
        {
            try
            {
                Set.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        bool IRepository<T>.Delete(T entity)
        {
            try
            {
                Set.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            return Set.Any(filter);
        }
    }
}
