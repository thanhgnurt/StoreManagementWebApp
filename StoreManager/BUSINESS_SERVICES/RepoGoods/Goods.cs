using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.ENTITIES;
using StoreManager.BUSINESS_SERVICES.Common;


namespace StoreManager.BUSINESS_SERVICES.RepoGoods
{
    /// <summary>
    /// Class description of the goods
    /// </summary>
    public class Goods : HandleCommon
    {
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public DATE HanSuDung { get; set; }
        public string CtySanXuat { get; set; }
        public int NamSanXuat { get; set; }
        public string LoaiHangHoa { get; set; }

        private static int _numberAuto = 0001;
        public Goods() : this("Default Name") { }
        public Goods(string tenHangHoa)
        {
            TenHangHoa = tenHangHoa;
            CodeHead = "HH." + TenHangHoa[0].ToString().ToUpper();
            DateTime dayNow = DateTime.Now;
            if (dateBase.Day != dayNow.Day || dateBase.Year != dayNow.Year)
            {
               _numberAuto = 0001;
                dateBase = DateTime.Now;
            }
            MaHangHoa = ConcatString(CodeHead, ConcatNum(dateBase.Day.ToString(), 2), ConcatNum(dateBase.Month.ToString(), 2), CutString(dateBase.Year.ToString(), 2, 3),".", ConcatNum(_numberAuto.ToString(), 4));
            _numberAuto++;
        }



    }
}
