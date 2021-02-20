using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using StoreManager.BUSINESS_SERVICES.RepoGoods;

namespace StoreManager.DATA_ACCESS
{
    public class BinaryDataAccess
    {
        public List<Goods> Books { get; set; } = new List<Goods>();
        private readonly string _file = "data.dat";

        public void Load()
        {
            if (!File.Exists(_file))
            {
                SaveChanges();
                return;
            }

            using (FileStream stream = File.OpenRead(_file))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Books = formatter.Deserialize(stream) as List<Goods>;
            }
        }

        public void SaveChanges()
        {
            using (FileStream stream = File.OpenWrite(_file))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Books);
            }
        }
    }
}
