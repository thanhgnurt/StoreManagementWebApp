using StoreManager.BUSINESS_SERVICES.Common;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.CONSTANT;
using StoreManager.DATA_ACCESS;
using System.Collections.Generic;
using System.Linq;

namespace StoreManager.BUSINESS_SERVICES.Commodity
{
    public class RepositoryGoods : HandleFileGoods, IRepositoryGoods
    {
        public static readonly Goods GoodsNull = new Goods();

        private HashSet<Goods> _listGoods;

        public HashSet<Goods> ListGoods
        {
            get
            {
                return _listGoods;
            }
            set
            {
                _listGoods = value;
            }
        }

        public RepositoryGoods()
        {
            _listGoods = ReadFileGoods();
        }

        public Goods Get(string id)
        {
            try
            {
                return _listGoods.SingleOrDefault(matHang => matHang.MaMH == id);
            }
            catch
            {
                return null;
            }
        }

        public void Add(Goods goods)
        {
            goods.MaMH = goods.MakeId();
            _listGoods.Add(goods);
            SaveChangeGoods(_listGoods);
        }


    }
}