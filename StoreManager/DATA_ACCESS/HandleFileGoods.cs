using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.RepoGoods;
using StoreManager.CONSTANT;
using StoreManager.ENTITIES;

namespace StoreManager.DATA_ACCESS
{
    public class HandleFileGoods : HandleFile<Goods>
    {
       
        public static HashSet<Goods> ReadFileGoods()
        {
            HashSet<Goods> Goodses =  ReadFile(ConstantPath.pathFileGoods);
            return Goodses;

        }
        public static void SaveChangeGoods(HashSet<Goods> goodses)
        {
            SaveChange(ConstantPath.pathFileGoods, goodses);
        }

    }
}
