namespace StoreManager.BUSINESS_SERVICES.RepoGoods
{
    using StoreManager.BUSINESS_SERVICES.Interface;
    using StoreManager.DATA_ACCESS;
    using System.Collections.Generic;
    using System.Linq;

    public class RepositoryGoods : HandleFileGoods, IRepositoryGoods
    {
        public static readonly Goods GoodsNull = new Goods();
        private HashSet<Goods> _goodses;
        public HashSet<Goods> Goodses
        {
            get
            {
                return _goodses;
            }
            set
            {
                _goodses = value;
            }
        }
        public RepositoryGoods()
        {
            _goodses = ReadFileGoods();
        }
        public Goods Get(string id)
        {
            return _goodses.SingleOrDefault(hangHoa => hangHoa.MaHangHoa == id);
        }
        public void Add(Goods goods)
        {
            _goodses.Add(goods);
            SaveChangeGoods(_goodses);
        }
    }
}
