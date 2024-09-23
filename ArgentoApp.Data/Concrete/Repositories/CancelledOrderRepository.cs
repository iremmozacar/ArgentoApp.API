using System;
using System.Linq.Expressions;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Query;

namespace ArgentoApp.Data.Concrete.Repositories;

public class CancelledOrderRepository : GenericRepository<CancelledOrder>, ICancelledOrderRepository
{
    public CancelledOrderRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}


