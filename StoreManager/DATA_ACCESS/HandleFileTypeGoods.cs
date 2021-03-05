using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.TypeGoods;
using StoreManager.CONSTANT;

namespace StoreManager.DATA_ACCESS
{
    public class HandleFileTypeGoods : HandleFile<TyGoods>
    {

        public static HashSet<TyGoods> ReadFileTyGoods()
        {
            HashSet<TyGoods> TyGoodses = ReadFile(Constant.Path.pathFileGoodsType);
            return TyGoodses;
        }
        public static void SaveChangeGoods(HashSet<TyGoods> tyGoods)
        {
            SaveChange(Constant.Path.pathFileGoodsType, tyGoods);
        }
    }

}
