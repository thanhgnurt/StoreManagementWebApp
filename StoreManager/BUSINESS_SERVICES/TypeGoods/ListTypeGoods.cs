using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Interface;

namespace StoreManager.BUSINESS_SERVICES.TypeGoods
{
    public class ListTypeGoods : IListTypeGoods
    {
        public HashSet<TyGoods> dsLoaiHang { get; set; } = new HashSet<TyGoods>
        {
            new TyGoods{maLoaiHang= 1, tenLoaihang = "Đồ Uống", moTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{maLoaiHang= 2, tenLoaihang = "Đồ Uống", moTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{maLoaiHang= 3, tenLoaihang = "Đồ Uống", moTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{maLoaiHang= 4, tenLoaihang = "Đồ Uống", moTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{maLoaiHang= 5, tenLoaihang = "Đồ Uống", moTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{maLoaiHang= 6, tenLoaihang = "Đồ Uống", moTaLoaihang="thức uống dinh dưỡng" },
            new TyGoods{maLoaiHang= 7, tenLoaihang = "Đồ Uống", moTaLoaihang="thức uống dinh dưỡng" },
        };

       

        public TyGoods Get(int id)
        {
            return dsLoaiHang.SingleOrDefault(loaiHang => loaiHang.maLoaiHang == id);
        }
    }
}
