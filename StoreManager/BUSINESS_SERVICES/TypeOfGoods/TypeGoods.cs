using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Common;
using StoreManager.CONSTANT;

namespace StoreManager.BUSINESS_SERVICES.TypeOfGoods
{
    public class TypeGoods : HandleCommon
    {
        public string MaLH { get; set; }
        public string TenLH { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }

        private static int _numberAuto = 1;

        
        public string MakeId()
        {
            if(TenLH!=null)
            CodeHead = TenLH[0].ToString().ToUpper();
            else
            CodeHead = Constant.CodeHeadDefault.TYPE_GOODS + "N";

            DateTime dayNow = DateTime.Now;
            if (dayBase.Day != dayNow.Day || dayBase.Year != dayNow.Year)
            {
                _numberAuto = 1;
                dayBase = DateTime.Now;
            }
            MaLH = ConcatString(CodeHead, dayBase.Day.ToString().ConCatNumber0(2), dayBase.Month.ToString().ConCatNumber0(2), CutString(dayBase.Year.ToString(), 2, 3),".", _numberAuto.ToString().ConCatNumber0(4));
            _numberAuto++;
            return MaLH;
        }
 
    }
}
