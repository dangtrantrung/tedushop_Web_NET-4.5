﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository: RepositoryBase<ProductCategory>, IProductCategoryRepository

    {
        

        public ProductCategoryRepository(IDbFactory dbFactory)
            :base (dbFactory)
        {
                   
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            //throw new NotImplementedException();
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
