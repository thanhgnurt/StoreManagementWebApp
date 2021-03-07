using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Commodity;


namespace StoreManager.BUSINESS_SERVICES.Interface
{
    public interface IRepositoryGoods : ICreateReadUpdateDelete<Goods>
    {
        public HashSet<Goods> ListGoods { get; set; }

    }
}
