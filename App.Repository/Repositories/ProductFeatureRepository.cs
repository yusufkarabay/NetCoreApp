using App.Core.Entities;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Repositories
{
    public class ProductFeatureRepository : GenericRepository<ProductFeature>, IProductFeatureRepository
    {
        public ProductFeatureRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
