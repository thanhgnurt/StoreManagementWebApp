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
        public static HashSet<Goods> DataTemplate { get; set; } = new HashSet<Goods>
        {

            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020},
            new Goods { TenHangHoa="Rượi", HanSuDung=new DATE(12,05,2025), CtySanXuat="Apple", LoaiHangHoa="Thực Phẩm", NamSanXuat=2020}
        };
        public static HashSet<Goods> ReadFileGoods()
        {
            HashSet<Goods> Goodses =  ReadFile(ConstantPath.pathFileGoods, DataTemplate);
            return Goodses;

        }

    }
}
