using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.ENTITIES;

namespace StoreManager.BUSINESS_SERVICES.RepoGoods
{
    /// <summary>
    /// Class description of the goods
    /// </summary>
    public class Goods
    {
        public int maHangHoa { get; set; }
        public string tenHangHoa { get; set; }
        public DATE hanSuDung { get; set; }
        public string ctySanXuat { get; set; }
        public int namSanXuat { get; set; }
        public string loaiHangHoa { get; set; }

    }
}
