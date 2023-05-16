namespace Application.Common
{
    public interface IRepository<TEntity>
    {

        IQueryable<TEntity> GetAll();


        Task<List<TEntity>> ListAllAsync();

        Task<TEntity> GetByIdAsync(Guid id);


        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(Guid id);

    }
}
