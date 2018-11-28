using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MyTime.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly MyTimeDbContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository(MyTimeDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Delete(T pItem)
        {
            _dbSet.Remove(pItem);
        }

        public T GetByCode(string pCode)
        {
            var parametro = Expression.Parameter(typeof(T), "p");
            var propriedade = Expression.Property(parametro, "Code");
            var constante = Expression.Constant(pCode, typeof(string));
            var igualdade = Expression.Equal(propriedade, constante);
            var final = Expression.Lambda(igualdade, parametro);

            return _context.Set<T>().AsNoTracking().Where((Expression<Func<T, bool>>)final).FirstOrDefault();
        }

        public T GetById(int pId)
        {
            var type = typeof(T);
            var prop = type.GetProperties().Where(x => Attribute.IsDefined(x, typeof(KeyAttribute))).FirstOrDefault();
            var parameter = Expression.Parameter(type, "p");
            var property = Expression.Property(parameter, prop);
            var constante = Expression.Constant(pId, typeof(int));
            var igualdade = Expression.Equal(property, constante);
            var final = Expression.Lambda(igualdade, parameter);

            return _context.Set<T>().AsNoTracking().Where((Expression<Func<T, bool>>)final).FirstOrDefault();
        }

        public T Insert(T pItem)
        {
            throw new System.NotImplementedException();
        }

        public IList<T> ListAll()
        {
            throw new System.NotImplementedException();
        }

        public T Update(T pItem)
        {
            throw new System.NotImplementedException();
        }
    }

}