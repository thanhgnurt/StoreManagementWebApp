using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.TypeOfGoods;
using StoreManager.CONSTANT;

namespace StoreManager.DATA_ACCESS
{
    public class HandleFileTypeGoods : HandleFile<TypeGoods>
    {

        public static HashSet<TypeGoods> ReadFileTyGoods()
        {
            HashSet<TypeGoods> listTyGoods = ReadFile(Constant.Path.TYPES_OF_GOODS);
            return listTyGoods;
        }
        public static void SaveChangeGoods(HashSet<TypeGoods> tyGoods)
        {
            SaveChange(Constant.Path.TYPES_OF_GOODS, tyGoods);
        }
    }

}
