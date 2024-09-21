using System;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Entity.Concrete;

namespace ArgentoApp.Data.Concrete.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
