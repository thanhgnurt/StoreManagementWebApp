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

        private static int _numberAuto = 1;

        public TyGoods() : this("Default Name") { }
        public TyGoods(string tenLoaiHang)
        {
            TenLoaihang = tenLoaiHang;
            CodeHead = "LH." + tenLoaiHang[0].ToString().ToUpper();
            DateTime dayNow = DateTime.Now;
            if (dayBase.Day != dayNow.Day || dayBase.Year != dayNow.Year)
            {
                _numberAuto = 1;
                dayBase = DateTime.Now;
            }
            MaLoaiHang = ConcatString(CodeHead, ConcatNum(dayBase.Day.ToString(), 2), ConcatNum(dayBase.Month.ToString(), 2), CutString(dayBase.Year.ToString(), 2, 3),".", ConcatNum(_numberAuto.ToString(), 4));
            _numberAuto++;
        }
        ~TyGoods()
        {
            _numberAuto--;
        }
    }
}
