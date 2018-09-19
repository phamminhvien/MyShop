﻿using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        //Truog hop co Phuong thuc can phai viet them
        //IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        //public IEnumerable<ProductCategory> GetByAlias(string alias)
        //{
        //    return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        //}
    }
}