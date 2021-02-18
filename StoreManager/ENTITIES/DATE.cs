using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.ENTITIES
{
    public struct DATE
    {
        public int ngay;
        public int thang;
        public int nam;
        public DATE(int a, int b, int c)
        {
            ngay = a;
            thang = b;
            nam = c;

        }
    }
}
