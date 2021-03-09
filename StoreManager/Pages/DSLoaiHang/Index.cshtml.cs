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
        public TypeGoods[] TypeGoods;
        public IndexModel(ITypeOfGoods ListTypeGoods, int page = 1)
        {
            _listTypeGood = ListTypeGoods;
            TypeGoods = _listTypeGood.DivideData(_listTypeGood.TypesOfGoods, 1, 10).listPage;
        }
        public void OnGet(int trang = 1)
        {
            Console.WriteLine(trang);
            var listPage = _listTypeGood.DivideData(_listTypeGood.TypesOfGoods, trang, 10);
            ViewData["pages"] = listPage.pages;
            ViewData["page"] = listPage.page;
            ViewData["path"] = "/dsloaihang/?trang=";
            ViewData["Title"] = "Quản lý loại hàng - Trang "+ listPage.page;
            ViewData["classLH"] = "classLH";
            TypeGoods = listPage.listPage;
        }
    }
}
