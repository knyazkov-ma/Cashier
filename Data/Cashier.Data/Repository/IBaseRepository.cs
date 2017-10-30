﻿using Cashier.Entity;
using System.Linq;
using System.Linq.Expressions;
using System;


namespace Cashier.Data.Repository
{
    /// <summary>
    /// Общий для всех репозиториев интерфейс
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetList();

        
        IQueryable<T> GetList(Expression<Func<T, bool>> predicate);

        void Delete(T entity);
        void Delete(long id);

        T Get(long id);
                
        T Get(Expression<Func<T, bool>> predicate);

        void Save(T entity);

        int Count(Expression<Func<T, bool>> predicate = null);
    }
}
