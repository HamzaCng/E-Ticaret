
using Mersus.Core.DataAccess;
using Mersus.Core.Interfaces;
using Mersus.DataAccess;
using Mersus.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Core.Repositories
{
    public class CategoryRepository: EntityRepositoryBase<Category>,ICategoryRepo
    {
        public CategoryRepository(MersusContext context) : base(context) { }
    }
}
