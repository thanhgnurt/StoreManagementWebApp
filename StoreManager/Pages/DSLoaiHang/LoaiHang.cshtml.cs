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
        public LoaiHangModel(IListTypeGoods typeGoodes)
        {
            _typeGoodes = typeGoodes;
        }
        public Action CongViec { get; private set; }
        public TyGoods tygoods { get; set; }
        public void OnGet(int id)
        {
            CongViec = Action.ChiTiet;
            tygoods = _typeGoodes.Get(id);
            ViewData["Title"] = tygoods == null ? "Không tìm thấy hàng hoá" : $"Chi tiết - {tygoods.tenLoaihang}";
        }
        public void OnGetCreate()
        {
            CongViec = Action.ThemMoi;
            tygoods = new TyGoods();
            ViewData["Title"] = "Thêm loại hàng";
            ViewData["classLH"] = "classLH";
        }
    }
}
