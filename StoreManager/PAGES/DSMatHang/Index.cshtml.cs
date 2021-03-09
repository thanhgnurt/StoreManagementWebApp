using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.BUSINESS_SERVICES.Commodity;
using StoreManager.BUSINESS_SERVICES.Interface;
using System;
using System.Collections.Generic;

namespace StoreManager.Pages.DSMatHang
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryGoods _repositoryGoods;

        public List<int> selectHH { get; private set; } = null;
        public Goods[] listGoods;

        public IndexModel(IRepositoryGoods repositoryGoods)
        {
            _repositoryGoods = repositoryGoods;
            listGoods = _repositoryGoods.DivideData(_repositoryGoods.ListGoods, 1, 10).listPage;
        }

        public void OnGet(int trang = 1)
        {
            Console.WriteLine(trang);
            var listPage = _repositoryGoods.DivideData(_repositoryGoods.ListGoods,trang, 10);
            ViewData["pages"] = listPage.pages;
            ViewData["page"] = listPage.page;
            listGoods = listPage.listPage;
        }

        public void OnPost(List<int> selectGoods)
        {
            try
            {
                if (selectGoods.Count > 0)
                {
                    selectHH = selectGoods;
                }
            }
            catch
            {
                selectHH = null;
            }
        }
    }
}