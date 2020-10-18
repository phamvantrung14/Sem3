using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI2.Models.Repositories
{
    interface IRepository<T> where T : class, new()
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>>predicate);
        T Get(object id);
        void Add(T entity);
        void Edit(T entity);
        void Remove(object id);
        void Save();
    }
}
