using System;

namespace ArgentoApp.Data.Abstact;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<TEntity> CreateAsync(TEntity entity);

    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task <TEntity> GetbyIdAsync(int id);
    Task <List<TEntity>> GetAllAsync(int id);
    Task  <int> GetCountAsync(int id);

}
