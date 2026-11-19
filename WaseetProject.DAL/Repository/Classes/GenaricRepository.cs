using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Contexts;
using WaseetProject.DAL.Entities;
using WaseetProject.DAL.Repository.Interfaces;

namespace WaseetProject.DAL.Repository.Classes
{
    public class GenaricRepository<TEntity> : IGenaricRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly WaseetDbContext dbContext;

        public GenaricRepository(WaseetDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync(bool IsTracked=default, CancellationToken ct = default)
        {
            var items = IsTracked ? dbContext.Set<TEntity>() : dbContext.Set<TEntity>().AsNoTracking();
            return await items.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id,CancellationToken ct)
        {
            var item = await dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }
        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity);
        }
        public void Delete(int id)
        {
            var item = dbContext.Set<TEntity>().FirstOrDefault(x => x.Id == id);
            dbContext.Set<TEntity>().Remove(item);
        }
        public async Task<int> CompleteAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
 }
