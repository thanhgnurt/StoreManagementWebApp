using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.DATA_ACCESS;

namespace StoreManager.BUSINESS_SERVICES.TypeGoods
{
    public class ListTypeGoods : IListTypeGoods
    {
        public HashSet<TyGoods> DsLoaiHang { get; set; } = HandleFileTypeGoods.ReadFileTyGoods();



        public TyGoods Get(string id)
        {
            return DsLoaiHang.SingleOrDefault(loaiHang => loaiHang.MaLoaiHang == id);
        }
    }
}
