using Dcs.Core.DbContexts;
using Dcs.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dcs.Core.Repositories
{
    public interface IBaseRepository<TEntity> 
        where TEntity: IBaseEntity
    {
        DcsDbContext localDbContext { get; set; }

        IQueryable<TEntity> FindAll(bool? active = true);

        IQueryable<TEntity> FindAllWithoutTracking(bool? active = true);

        Task<TEntity> FindByIdAsync(int id, bool? active = true);

        Task<TEntity> FindByIdWithoutTrackingAsync(int id, bool? active = true);

        Task<bool> CreateAsync(TEntity entity);

        Task<bool> UpdateAsync(int id, TEntity entity);

        Task<bool> RemoveAsync(int id);

        Task<bool> DeleteAsync(int id);

        Task<bool> UndeleteAsync(int id);
    }
}
