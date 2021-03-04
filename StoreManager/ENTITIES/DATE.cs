using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.ENTITIES
{
    public struct DATE
    {
        public int Ngay;
        public int Thang;
        public int Nam;
        public DATE(int a, int b, int c)
        {
            Ngay = a;
            Thang = b;
            Nam = c;

        }
    }
}
