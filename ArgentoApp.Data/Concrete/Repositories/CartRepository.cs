using System;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Entity.Concrete;

namespace ArgentoApp.Data.Concrete.Repositories;

public class CartRepository : GenericRepository<Cart>, ICartRepository
{
    public CartRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
