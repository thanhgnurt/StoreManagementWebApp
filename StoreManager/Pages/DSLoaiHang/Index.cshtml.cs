using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.BUSINESS_SERVICES.TypeOfGoods;

namespace StoreManager.Pages.DSLoaiHang
{
    public class IndexModel : PageModel
    {
        private readonly ITypeOfGoods _listTypeGood;
        public HashSet<TypeGoods> tyGoodses;
        public IndexModel(ITypeOfGoods ListTypeGoods, int page = 1)
        {
            _listTypeGood = ListTypeGoods;
            tyGoodses = ListTypeGoods.TypesOfGoods;
        }
    }
}
