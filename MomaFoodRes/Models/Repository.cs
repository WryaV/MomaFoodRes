﻿using Microsoft.EntityFrameworkCore;
using MomaFoodRes.Data;

namespace MomaFoodRes.Models
    {

    public class Repository<T> : IRepository<T> where T : class
        {
        protected ApplicationDbContext _context { get; set; }
        private DbSet<T> _dbSet { get; set; }
        public Repository(ApplicationDbContext context)
            {
            _context = context;
            _dbSet = context.Set<T>();
            }

        public Task<IEnumerable<T>> GetAllAsync()
            {
            throw new NotImplementedException();
            }

        public Task<IEnumerable<T>> GetAllByIdAsync<TKey>(TKey id, string propertyName, QueryOptions<T> options)
            {
            throw new NotImplementedException();
            }

        public Task<T> GetByIdAsync(int id, QueryOptions<T> options)
            {
            throw new NotImplementedException();
            }

        public Task AddAsync(T entity)
            {
            throw new NotImplementedException();
            }

        public Task UpdateAsync(T entity)
            {
            throw new NotImplementedException();
            }

        public Task DeleteAsync(int id)
            {
            throw new NotImplementedException();
            }
        }
    }
