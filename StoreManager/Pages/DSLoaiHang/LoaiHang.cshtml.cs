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
    public class LoaiHangModel : PageModel
    {
        public enum Action { ChiTiet, Xoa, CapNhat, ThemMoi };

        public readonly IListTypeGoods _typeGoodes;
        public LoaiHangModel(IListTypeGoods TypeGoodes)
        {
            _typeGoodes = TypeGoodes;
        }
        public Action CongViec { get; private set; }
        public TyGoods Tygoods { get; set; }
        public void OnGet(string id)
        {
            CongViec = Action.ChiTiet;
            Tygoods = _typeGoodes.Get(id);
            ViewData["Title"] = Tygoods == null ? "Không tìm thấy hàng hoá" : $"Chi tiết - {Tygoods.TenLoaihang}";
        }
        public void OnGetCreate()
        {
            CongViec = Action.ThemMoi;
            Tygoods = new TyGoods();
            ViewData["Title"] = "Thêm loại hàng";
            ViewData["classLH"] = "classLH";
        }
    }
}
