using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.BUSINESS_SERVICES.TypeGoods;

namespace StoreManager.Pages.DSLoaiHang
{
    public class IndexModel : PageModel
    {
        public readonly IListTypeGoods _listTypeGood;
        public HashSet<TyGoods> DsLoaiHang;
        public IndexModel(IListTypeGoods ListTypeGoods)
        {
            _listTypeGood = ListTypeGoods;
            DsLoaiHang = ListTypeGoods.DsLoaiHang;
        }
    }
}
