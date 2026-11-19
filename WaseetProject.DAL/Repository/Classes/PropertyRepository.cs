using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Contexts;
using WaseetProject.DAL.Repository.Interfaces;

namespace WaseetProject.DAL.Repository.Classes
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly WaseetDbContext dbContext;

        public PropertyRepository(WaseetDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IEnumerable<Entities.Property>> GetAll(bool IsTracked=false, CancellationToken ct=default)
        {
            var properties = IsTracked ? dbContext.Properties: dbContext.Properties.AsNoTracking();
            return await properties.ToListAsync();
        }

        public async Task<Entities.Property?> GetById(int id, CancellationToken ct)
        {
           var property=await dbContext.Properties.FirstOrDefaultAsync(p => p.Id == id);
            return property;
        }
        public void Add(Entities.Property property)
        {
            dbContext.Properties.Add(property);
        }
        public void Update(Entities.Property property)
        {
            dbContext.Properties.Update(property);
        }
        public void Delete(int id)
        {
            var property= dbContext.Properties.FirstOrDefault(p => p.Id == id);
            dbContext.Properties.Remove(property);
        }
        public async Task<int> CompleteAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        
    }
}
