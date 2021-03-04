namespace StoreManager.BUSINESS_SERVICES.RepoGoods
{
    using StoreManager.BUSINESS_SERVICES.Interface;
    using StoreManager.DATA_ACCESS;
    using System.Collections.Generic;
    using System.Linq;

    public class RepositoryGoods : IRepositoryGoods
    {
        public HashSet<Goods> Goodses { get; set; } = HandleFileGoods.ReadFileGoods();

        public Goods Get(string id)
        {
            return Goodses.SingleOrDefault(hangHoa => hangHoa.MaHangHoa == id);
        }
    }
}
