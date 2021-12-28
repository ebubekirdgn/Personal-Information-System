using Microsoft.EntityFrameworkCore;
using PersonelInformationSystem.Data.Contracts;
using PersonelInformationSystem.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelInformationSystem.Data.Implementation
{
    internal class Repository<T> : IRepositoryBase<T> where T : class, new()
    {

        private readonly PersonelInformationContext _context;
        internal DbSet<T> dbSet;

        public Repository(PersonelInformationContext context)
        {
            _context = context;
            this.dbSet = context.Set<T>();    
        }


        /// <summary>
        /// Add To T type entity/Gelen Tipte veriyi Kayıt eder.
        /// </summary>
        public void Add(T entity)
        {
            dbSet.Add(entity); 
        }

        public T Get(int id)
        {
          return dbSet.Find(id);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            
            
            return query;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
          dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
          dbSet.Update(entity);
        }
    }
}
