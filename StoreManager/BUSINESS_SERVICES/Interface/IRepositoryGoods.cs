using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.RepoGoods;

namespace StoreManager.BUSINESS_SERVICES.Interface
{
    public interface IRepositoryGoods : ICreateReadUpdateDelete<Goods>
    {
        public HashSet<Goods> Goodses { get; set; }
    }
}
