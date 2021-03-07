using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.ENTITIES;
using StoreManager.BUSINESS_SERVICES.Common;
using StoreManager.CONSTANT;


namespace StoreManager.BUSINESS_SERVICES.Commodity
{
    /// <summary>
    /// Class description of the goods
    /// </summary>
    public class Goods : HandleCommon
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public DateTime HanSD { get; set; }
        public string CtySX { get; set; }
        public DateTime NgaySX { get; set; }
        public string LoaiHang { get; set; }

        private static int _numberAuto = 1;

   
        public string MakeId ()
        {

            if (TenMH != null)
                CodeHead = TenMH[0].ToString().ToUpper();
            else
                CodeHead = Constant.CodeHeadDefault.GOODS;

            DateTime dayNow = DateTime.Now;
            if (dayBase.Day != dayNow.Day || dayBase.Year != dayNow.Year)
            {
               _numberAuto = 1;
                dayBase = DateTime.Now;
            }

            MaMH = ConcatString(CodeHead, dayBase.Day.ToString().ConCatNumber0(2), dayBase.Month.ToString().ConCatNumber0(2), 
                        CutString(dayBase.Year.ToString(), 2, 3),".", _numberAuto.ToString().ConCatNumber0(3));
            _numberAuto++;
            return MaMH;
        }



    }
}
