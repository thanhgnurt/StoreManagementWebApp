using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.BUSINESS_SERVICES.RepoGoods;

namespace StoreManager.Pages.DSHangHoa
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryGoods _goodses;
        public List<int> selectHH { get; private set; } = null;
        public HashSet<Goods> listGoods;
        public IndexModel(IRepositoryGoods khoHang)
        {
            _goodses = khoHang;
            listGoods = _goodses.Goodses;
        }
        public void OnPost(List<int> selecthanghoa)
        {
            try
            {
                if (selecthanghoa.Count > 0)
                {
                    selectHH = selecthanghoa;
                }
            }
            catch
            {
                selectHH = null;
            }
          
        }
    }
}
