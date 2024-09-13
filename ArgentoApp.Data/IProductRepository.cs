using System;
using ArgentoApp.Entity.Concrete.Abstact;

namespace ArgentoApp.Data.Abstact;

public interface IProductRepository:IGenericRepository<Product>
{
Task <List<Product>> GetProductsByCategoryIdAsync(int categoryId);
}
