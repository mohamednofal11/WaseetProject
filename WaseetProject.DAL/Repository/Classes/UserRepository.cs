using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Contexts;
using WaseetProject.DAL.Entities;
using WaseetProject.DAL.Repository.Interfaces;

namespace WaseetProject.DAL.Repository.Classes
{
    public class UserRepository:GenaricRepository<User>,IUserRepository
    {
        private readonly WaseetDbContext dbContext;

        public UserRepository(WaseetDbContext _dbContext):base(_dbContext)
        {
            dbContext = _dbContext;
        }
    }
}
