using Mersus.Core.Interfaces;
using Mersus.DataAccess;
using Mersus.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Core.DataAccess.Repositories
{
    public class BasketRepository : EntityRepositoryBase<Basket>, IBasketRepo
    {
        public BasketRepository(MersusContext context) : base(context) { }
    }
}
