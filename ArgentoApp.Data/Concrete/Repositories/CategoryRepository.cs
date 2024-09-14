using System;
using ArgentoApp.Entity.Concrete;

namespace ArgentoApp.Data.Concrete.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
