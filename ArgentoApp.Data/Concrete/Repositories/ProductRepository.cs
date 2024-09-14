using System;
using ArgentoApp.Data.Abstact;
using ArgentoApp.Entity.Concrete.Abstact;

namespace ArgentoApp.Data.Concrete.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
    {
        throw new NotImplementedException();
    }
}
