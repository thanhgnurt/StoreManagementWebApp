using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.BUSINESS_SERVICES.TypeGoods;
using StoreManager.Pages._Common;

namespace StoreManager.Pages.DSLoaiHang
{
    public class LoaiHangModel : PageModel
    {
        public readonly IListTypeGoods _typeGoodes;
        public LoaiHangModel(IListTypeGoods TypeGoodes)
        {
            _typeGoodes = TypeGoodes;
        }
        public Enumuration.Action Job { get; private set; }
        public TyGoods Tygoods { get; set; }
        public void OnGet(string id)
        {
            Job = Enumuration.Action.Detail;
            Tygoods = _typeGoodes.Get(id);
            ViewData["Title"] = Tygoods == null ? "Không tìm thấy hàng hoá" : $"Chi tiết - {Tygoods.TenLoaihang}";
        }
        public void OnGetCreate()
        {
            Job = Enumuration.Action.Create;
            Tygoods = ListTypeGoods.TyGoodsNull;
            ViewData["Title"] = "Thêm loại hàng";
            ViewData["classLH"] = "classLH";
        }

        public IActionResult OnPostCreate(TyGoods tyGoods)
        {

            _typeGoodes.Add(tyGoods);
            return new RedirectToPageResult("index");
        }
    }
}
