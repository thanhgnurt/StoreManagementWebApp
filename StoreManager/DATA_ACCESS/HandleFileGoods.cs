using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Commodity;
using StoreManager.CONSTANT;
using StoreManager.ENTITIES;

namespace StoreManager.DATA_ACCESS
{
    public class HandleFileGoods : HandleFile<Goods>
    {
       
        public static HashSet<Goods> ReadFileGoods()
        {
            HashSet<Goods> Goodses =  ReadFile(Constant.Path.REPOSITORY_GOODS);
            return Goodses;

        }
        public static void SaveChangeGoods(HashSet<Goods> goodses)
        {

            SaveChange(Constant.Path.REPOSITORY_GOODS, goodses);
        }

    }
}
