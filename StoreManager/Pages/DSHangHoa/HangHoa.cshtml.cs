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
    public class HangHoaModel : PageModel
    {
        public enum Action { ChiTiet, Xoa, CapNhat, ThemMoi };

        public readonly IRepositoryGoods _khoHang;
        public HangHoaModel(IRepositoryGoods khoHang)
        {
            _khoHang = khoHang;
        }
        public Action CongViec { get; private set; }
        public Goods goods { get; set; }
        public void OnGet(int maHangHoa)
        {
            CongViec = Action.ChiTiet;
            goods = _khoHang.Get(maHangHoa);
            ViewData["Title"] = goods == null ? "Không tìm thấy hàng hoá" : $"Chi tiết - {goods.tenHangHoa}";
        }
    }
}
