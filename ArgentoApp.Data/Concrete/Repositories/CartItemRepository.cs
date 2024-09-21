using System;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Entity.Concrete;

namespace ArgentoApp.Data.Concrete.Repositories;

public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
{
    public CartItemRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
