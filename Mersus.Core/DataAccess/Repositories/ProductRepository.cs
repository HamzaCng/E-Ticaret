using Mersus.Core.Interfaces;
using Mersus.DataAccess;
using Mersus.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Core.DataAccess.Repositories
{
    public class ProductRepository : EntityRepositoryBase<Product>, IProductRepo
    {
        public ProductRepository(MersusContext context) : base(context) { }
    }
}
