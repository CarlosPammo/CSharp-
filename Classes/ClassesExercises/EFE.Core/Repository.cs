using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFE.Core
{
    public class Repository<T>: IDisposable where T : class
    {
        public AbstractContext Context { get; set; }

        public Repository(AbstractContext abstractContext)
        {
            Context = abstractContext;
        }
        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }

        public IQueryable<T> Select(Expression<Func<T, bool>> lambda)
        {
            lambda.Compile();
            return Context.Set<T>().Where(lambda).AsQueryable();
        }

        public T Create(T entity)
        {
            var entry = Context.Set<T>().Add(entity);
            Context.SaveChanges();
            return entry;
        }

        public int Update(T entity)
        {
            var entry = Context.Entry(entity);
            Context.Set<T>().Attach(entity);
            entry.State = EntityState.Modified;
            return Context.SaveChanges();
        }

        public int Delete(Expression<Func<T, bool>> lambda)
        {
            var matches = Select(lambda);
            if (matches == null)
            {
                return 0;
            }
            foreach (var match in matches)
            {
                Context.Set<T>().Remove(match);
            }
            return matches.Count();
        }
    }
}
