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
        public readonly IRepositoryGoods _khohang;
        public List<int> selectHangHoa { get; private set; } = null;
        public HashSet<Goods> dshangHoa;
        public IndexModel(IRepositoryGoods khoHang)
        {
            _khohang = khoHang;
            dshangHoa = _khohang.Goodes;
        }
        public void OnPost(List<int> selecthanghoa)
        {
            try
            {
                if (selecthanghoa.Count > 0)
                {
                    selectHangHoa = selecthanghoa;
                }
            }
            catch
            {
                selectHangHoa = null;
            }
          
        }
    }
}
