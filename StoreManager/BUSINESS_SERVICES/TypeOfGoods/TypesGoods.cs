using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.BUSINESS_SERVICES.Common;
using StoreManager.BUSINESS_SERVICES.Interface;
using StoreManager.CONSTANT;
using StoreManager.DATA_ACCESS;

namespace StoreManager.BUSINESS_SERVICES.TypeOfGoods
{
    public class TypesGoods : HandleFileTypeGoods, ITypesOfGoods
    {
        public static readonly TypeGoods TyGoodsNull = new TypeGoods();

        private HashSet<TypeGoods> _typesGoods;
        public HashSet<TypeGoods> TypesOfGoods
        {
            get
            {
                return _typesGoods;
            }
            set
            {
                _typesGoods = value;
            }
        }
        public TypesGoods()
        {
            _typesGoods = ReadFileTyGoods();
        }
        public TypeGoods Get(string id)
        {
            return _typesGoods.SingleOrDefault(loaiHang => loaiHang.MaLH == id);
        }
        public void Add(TypeGoods tyGoods)
        {
            tyGoods.MaLH = tyGoods.MakeId();
            TypesOfGoods.Add(tyGoods);
            SaveChangeGoods(_typesGoods);
        }

    }
}
