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
        public static HashSet<TyGoods> DataTemplate = new HashSet<TyGoods>
        {
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{ TenLoaihang = "Đồ Uống", MoTaLoaihang="thức uống dinh dưỡng" },
        };
        public static HashSet<TyGoods> ReadFileTyGoods()
        {
            HashSet<TyGoods> Goodses = ReadFile(ConstantPath.pathFileGoodsType, DataTemplate);
            return Goodses;
        }
    }

}
