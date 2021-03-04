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
        public HangHoaModel(IRepositoryGoods KhoHang)
        {
            _khoHang = KhoHang;
        }
        public Action CongViec { get; private set; }
        public Goods Goods { get; set; }
        public void OnGet(string maHangHoa)
        {
            CongViec = Action.ChiTiet;
            Goods = _khoHang.Get(maHangHoa);
            ViewData["Title"] = Goods == null ? "Không tìm thấy hàng hoá" : $"Chi tiết - {Goods.TenHangHoa}";
            ViewData["classHH"] = "classHH";
        }
        public void OnGetCreate()
        {
            CongViec = Action.ThemMoi;
            Goods = new Goods();
            ViewData["Title"] = "Them hang hoa";
            ViewData["classHH"] = "classHH";
        }
        public void OnGetDetail(string maHangHoa)
        {
            CongViec = Action.ChiTiet;
            Goods = _khoHang.Get(maHangHoa);
            ViewData["Title"] = Goods == null ? "Không tìm thấy hàng hoá" : $"Chi tiết - {Goods.TenHangHoa}";
            ViewData["classHH"] = "classHH";
        }
    }
}
