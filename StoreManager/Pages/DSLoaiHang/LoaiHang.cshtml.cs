using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.BUSINESS_SERVICES.TypeOfGoods;
using StoreManager.Pages._Common;

namespace StoreManager.Pages.DSLoaiHang
{
    public class LoaiHangModel : PageModel
    {
        public readonly ITypesOfGoods _typesOfGoods;
        public LoaiHangModel(ITypesOfGoods TypeGoodes)
        {
            _typesOfGoods = TypeGoodes;
        }
        public Enumuration.Action Job { get; private set; }
        public TypeGoods Tygoods { get; set; }
        public void OnGet(string id)
        {
            Job = Enumuration.Action.Detail;
            Tygoods = _typesOfGoods.Get(id);
            ViewData["Title"] = Tygoods == null ? "Không tìm thấy hàng hoá" : $"Chi tiết - {Tygoods.TenLH}";
        }
        public void OnGetCreate()
        {
            Job = Enumuration.Action.Create;
            Tygoods = TypesGoods.TyGoodsNull;
            ViewData["Title"] = "Thêm loại hàng";
            ViewData["classLH"] = "classLH";
        }

        public IActionResult OnPostCreate(TypeGoods typeGoods)
        {

            _typesOfGoods.Add(typeGoods);
            return new RedirectToPageResult("index");
        }
    }
}
