using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.BUSINESS_SERVICES.Common
{
    public class HandleCommon
    {
        protected string CodeHead;

        protected static DateTime dateBase = new DateTime();
        protected string ConcatString(params string[] listString)
        {
            string resultString = "";
            foreach (string item in listString)
            {
                resultString += item;
            }
            return resultString;
        }
        protected string ConcatNum(string num, int len)
        {
            if (num.Length <= len)
            {
                for (int i = num.Length; i < len; i++)
                {
                    num = "0" + num;
                }
            }
            return num;
        }
        protected string CutString(string input, int indexStart, int indexEnd)
        {
            string output = "";
            for (int i = indexStart; i <= indexEnd; i++)
            {
                output += input[i];
            }
            return output;
        }
    }
}
