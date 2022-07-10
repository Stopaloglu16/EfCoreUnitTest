using Application.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrasture.Repository
{
    public class EfCoreRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        //Data/EfCore

        private readonly TodoDbContext context;
        public EfCoreRepository(TodoDbContext context)
        {
            this.context = context;
        }


        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }



        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }



        public async Task<List<TEntity>> ListAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync(new CancellationToken());
            return entity;
        }

        public async Task<TEntity> DeleteAsync(Guid id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync(new CancellationToken());
            return entity;
        }

    }


}
