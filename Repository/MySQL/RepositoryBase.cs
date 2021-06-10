using Microsoft.EntityFrameworkCore;
using MovieRatingSystem.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Repository.MySQL
{
    public abstract class RepositoryBase<T, Entity> : IRepositoryBase<T> where T : class where Entity : DbContext
    {
        protected Entity context { get; set; }

        public RepositoryBase(Entity context)
        {
            this.context = context;
        }

        public IQueryable<T> SelectAll()
        {
            return this.context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> expression)
        {
            return this.context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Insert(T entity)
        {
            this.context.Set<T>().Add(entity);
        }

        public async Task InsertAsync(T entity, bool save = true)
        {
            await this.context.Set<T>().AddAsync(entity);
            if (save)
            {
                await this.context.SaveChangesAsync();
            }
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }

        public async Task UpdateAsync(T entity, bool save = true)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            if (save)
            {
                await this.context.SaveChangesAsync();
            }
        }


        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public async Task DeleteAsync(T entity, bool save = true)
        {
            this.context.Entry(entity).State = EntityState.Deleted;
            if (save)
            {
                await this.context.SaveChangesAsync();
            }
        }
    }
}
