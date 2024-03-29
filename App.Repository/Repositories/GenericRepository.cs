﻿using App.Core.Entities;
using App.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
            _dbSet=_context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {

            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public void Delete(T entity)
        {
          _dbSet.Remove(entity);
        }

        public void DeleteById(Guid id)
        {
            _context.Remove(id);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
           _dbSet.RemoveRange(entities);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);  
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public  IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
          return _dbSet.Where(expression);  
        }
    }
}
