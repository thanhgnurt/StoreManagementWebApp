using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.DATA_ACCESS;

namespace StoreManager.BUSINESS_SERVICES.TypeGoods
{
    public class ListTypeGoods : HandleFileTypeGoods, IListTypeGoods
    {
        public static readonly TyGoods TyGoodsNull = new TyGoods();

        private HashSet<TyGoods> _tyGoodses;
        public HashSet<TyGoods> TyGoodses
        {
            get
            {
                return _tyGoodses;
            }
            set
            {
                _tyGoodses = value;
            }
        }
        public ListTypeGoods()
        {
            _tyGoodses = ReadFileTyGoods();
        }
        public TyGoods Get(string id)
        {
            return _tyGoodses.SingleOrDefault(loaiHang => loaiHang.MaLoaiHang == id);
        }
        public void Add(TyGoods tyGoods)
        {
            tyGoods.MaLoaiHang = tyGoods.MakeId();
            _tyGoodses.Add(tyGoods);
            SaveChangeGoods(_tyGoodses);
        }
    }
}
