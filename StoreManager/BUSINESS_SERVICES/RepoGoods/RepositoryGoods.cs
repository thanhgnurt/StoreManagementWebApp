using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.ENTITIES;
using StoreManager.DATA_ACCESS;

namespace StoreManager.BUSINESS_SERVICES.RepoGoods
{
    /// <summary>
    /// The class description of the goods repository
    /// </summary>
    public class RepositoryGoods : IRepositoryGoods
    {
        
        public HashSet<Goods> Goodes { get; set; } = new HashSet<Goods>
        {
            new Goods {maHangHoa=1, tenHangHoa="Rượi", hanSuDung=new DATE(12,05,2025), ctySanXuat="Apple", loaiHangHoa="Thực Phẩm", namSanXuat=2020},
            new Goods {maHangHoa=2, tenHangHoa="Rượi", hanSuDung=new DATE(12,05,2025), ctySanXuat="Apple", loaiHangHoa="Thực Phẩm", namSanXuat=2020},
            new Goods {maHangHoa=3, tenHangHoa="Rượi", hanSuDung=new DATE(12,05,2025), ctySanXuat="Apple", loaiHangHoa="Thực Phẩm", namSanXuat=2020},
            new Goods {maHangHoa=4, tenHangHoa="Rượi", hanSuDung=new DATE(12,05,2025), ctySanXuat="Apple", loaiHangHoa="Thực Phẩm", namSanXuat=2020},
            new Goods {maHangHoa=5, tenHangHoa="Rượi", hanSuDung=new DATE(12,05,2025), ctySanXuat="Apple", loaiHangHoa="Thực Phẩm", namSanXuat=2020},
            new Goods {maHangHoa=6, tenHangHoa="Rượi", hanSuDung=new DATE(12,05,2025), ctySanXuat="Apple", loaiHangHoa="Thực Phẩm", namSanXuat=2020},
            new Goods {maHangHoa=7, tenHangHoa="Rượi", hanSuDung=new DATE(12,05,2025), ctySanXuat="Apple", loaiHangHoa="Thực Phẩm", namSanXuat=2020},

        };
        public Goods Get(int id)
        {
            return Goodes.SingleOrDefault(hangHoa => hangHoa.maHangHoa == id);
        }

    }
}
