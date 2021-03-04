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
        public enum Action { Detail, Delete, Update, Create };

        public readonly IRepositoryGoods _khoHang;
        public HangHoaModel(IRepositoryGoods KhoHang)
        {
            _khoHang = KhoHang;
        }
        public Action CongViec { get; private set; }
        public Goods Goods { get; set; }
        public void OnGet(string maHangHoa)
        {
            CongViec = Action.Detail;
            Goods = _khoHang.Get(maHangHoa);
            ViewData["Title"] = Goods == null ? "Không tìm thấy hàng hoá" : $"Chi tiết - {Goods.TenHangHoa}";
            ViewData["classHH"] = "classHH";
        }
        public void OnGetCreate()
        {
            CongViec = Action.Create;
            Goods = RepositoryGoods.GoodsNull;
            ViewData["Title"] = "Thêm hàng hoá";
            ViewData["classHH"] = "classHH";
        }
        public IActionResult OnPostCreate(Goods goods)
        {

            _khoHang.Add(goods);
            return new RedirectToPageResult("index");
        }

    }
}
