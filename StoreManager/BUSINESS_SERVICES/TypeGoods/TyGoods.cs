using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Common;

namespace StoreManager.BUSINESS_SERVICES.TypeGoods
{
    public class TyGoods : HandleCommon
    {
        public string MaLoaiHang { get; set; }
        public string TenLoaihang { get; set; }
        public string MoTaLoaihang { get; set; }

        private static int _numberAuto = 0001;

        public TyGoods() : this("Default Name") { }
        public TyGoods(string tenLoaiHang)
        {
            TenLoaihang = tenLoaiHang;
            CodeHead = "LH." + tenLoaiHang[0].ToString().ToUpper();
            DateTime dayNow = DateTime.Now;
            if (dateBase.Day != dayNow.Day || dateBase.Year != dayNow.Year)
            {
                _numberAuto = 0001;
                dateBase = DateTime.Now;
            }
            MaLoaiHang = ConcatString(CodeHead, ConcatNum(dateBase.Day.ToString(), 2), ConcatNum(dateBase.Month.ToString(), 2), CutString(dateBase.Year.ToString(), 2, 3),".", ConcatNum(_numberAuto.ToString(), 4));
            _numberAuto++;
        }
    }
}
