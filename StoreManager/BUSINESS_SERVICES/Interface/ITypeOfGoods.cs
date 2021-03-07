using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.TypeOfGoods;

namespace StoreManager.BUSINESS_SERVICES.Interface
{
    public interface ITypeOfGoods : ICreateReadUpdateDelete<TypeGoods>
    {
        public HashSet<TypeGoods> TypesOfGoods { get; set; }
    }
}
