using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Entities;

namespace WaseetProject.DAL.Repository.Interfaces
{
    public interface IGenaricRepository<TEntity> where TEntity : BaseEntity,new()
    {
        Task<IEnumerable<TEntity>> GetAllAsync(bool IsTracked=default,CancellationToken ct=default);
        Task<TEntity> GetByIdAsync(int id,CancellationToken ct);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        Task<int> CompleteAsync();
    }
}
