using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.TypeGoods;

namespace StoreManager.BUSINESS_SERVICES.Interface
{
    public interface IListTypeGoods : ICreateReadUpdateDelete<TyGoods>
    {
        public HashSet<TyGoods> TyGoodses { get; set; }
    }
}
