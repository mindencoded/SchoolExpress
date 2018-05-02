﻿using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SchoolExpress.Data.Repositories
{
    public interface IRoleRepository : IRepository<IdentityRole>
    {
        Task<IdentityResult> CreateAsync(IdentityRole entity);
    }
}