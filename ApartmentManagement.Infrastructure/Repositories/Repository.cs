using ApartmentManagement.Domain.Interfaces;
using ApartmentManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ApartmentDbContext _context;
        private DbSet<TEntity> _entity;
        public Repository(ApartmentDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
          await _entity.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {

            _entity.Remove(entity);
        }

        public async Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
           return await _entity.Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public async Task<int> TotalCount()
        {
            return await _entity.CountAsync();
        }

        public void Update(TEntity entity)
        {
            _entity.Update(entity);

        }
    }
}
