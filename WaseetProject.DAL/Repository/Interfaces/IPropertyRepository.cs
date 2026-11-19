using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using WaseetProject.DAL.Entities;

namespace WaseetProject.DAL.Repository.Interfaces
{
    public interface IPropertyRepository
    {
        Task<IEnumerable<Entities.Property>> GetAll(bool IsTracked=false, CancellationToken ct=default);
        Task<Entities.Property?> GetById(int id, CancellationToken ct);
        void Add(Entities.Property property);
        void Update(Entities.Property property);
        void Delete(int id);
        Task<int> CompleteAsync();
    }
}
