﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using Common.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.DataAccess.EFCore
{
    public abstract class BaseUserRoleRepository<TUserRole, TContext> : IUserRoleRepository<TUserRole>
        where TUserRole : BaseUserRole, new()
        where TContext : CommonDataContext
    {
        private readonly TContext _dbContext;

        public BaseUserRoleRepository(TContext context)
        {
            _dbContext = context;
        }

        protected TContext GetContext(ContextSession session)
        {
            _dbContext.Session = session;
            return _dbContext;
        }

        public async Task<TUserRole> Add(TUserRole userRole, ContextSession session)
        {
            var context = GetContext(session);
            context.Entry(userRole).State = EntityState.Added;
            await context.SaveChangesAsync();
            await context.Entry(userRole).Reference(ur => ur.Role).LoadAsync();
            return userRole;
        }

        public async Task Delete(int userId, int roleId, ContextSession session)
        {
            var context = GetContext(session);
            var itemToDelete = new TUserRole {UserId = userId, RoleId = roleId};
            context.Entry(itemToDelete).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

        public async Task<TUserRole> Get(int userId, int roleId, ContextSession session)
        {
            var context = GetContext(session);
            return await context.Set<TUserRole>()
                .AsNoTracking()
                .Where(obj => obj.RoleId == roleId && obj.UserId == userId)
                .FirstOrDefaultAsync();
        }

        public async Task<IList<string>> GetByUserId(int userId, ContextSession session)
        {
            var context = GetContext(session);
            return await context.Set<TUserRole>()
                .AsNoTracking()
                .Where(obj => obj.UserId == userId)
                .Include(obj => obj.Role)
                .Select(obj => obj.Role.Name)
                .ToListAsync();
        }
    }
}