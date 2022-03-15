using App.Core.Repositories;
using App.Core.Services;
using App.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        //savechanges metotları tek bir elden olması için IUnitOfWork burada kullanıldı

        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public GenericService(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository=repository;
            _unitOfWork=unitOfWork;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
           return await _repository.AnyAsync(expression);   
        }

        public async Task DeleteAsync(T entity)
        {
            _repository.Delete(entity);
            await _unitOfWork.CommitAsync();    
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            _repository.DeleteById(id);
            await _unitOfWork.CommitAsync();    
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            _repository.DeleteRange(entities);
            await _unitOfWork.CommitAsync();
        }

       

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
           return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
           _repository.Update(entity);  
            await _unitOfWork.CommitAsync();    
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
