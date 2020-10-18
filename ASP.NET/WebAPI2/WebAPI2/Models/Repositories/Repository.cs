using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebAPI2.Models.DataModels;

namespace WebAPI2.Models.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        protected DRDbContext ctx;
        protected DbSet<T> tbl;
        public Repository()
        {
            ctx = new DRDbContext();
            tbl = ctx.Set<T>();
        }
        public void Add(T entity)
        {

            tbl.Add(entity);
            Save();
        }

        public void Edit(T entity)
        {
            ctx.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public IEnumerable<T> Get()
        {
            return tbl.AsEnumerable();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return tbl.Where(predicate).AsEnumerable();
        }

        public T Get(object id)
        {
            return tbl.Find(id);
        }

        public void Remove(object id)
        {
            tbl.Remove(Get(id));
            Save();
        }

        public void Save()
        {
            ctx.SaveChanges();
        }
    }
}