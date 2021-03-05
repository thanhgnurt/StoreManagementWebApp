using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Linq.Dynamic.Core;
using StoreManager.BUSINESS_SERVICES.Common;
using StoreManager.BUSINESS_SERVICES.RepoGoods;
using System.Xml;
using StoreManager.DATA_ACCESS;
using Newtonsoft.Json;

namespace StoreManager.DATA_ACCESS
{
    public class HandleFile<T>
    {

        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(HashSet<T>));

        protected static HashSet<T> ReadFile(string pathFile)
        {
            HashSet<T> data = new HashSet<T>();
            if (!File.Exists(pathFile))
            {
                JsonSerializer ser = new JsonSerializer();
                using (StreamWriter sWriter = new StreamWriter(pathFile))
                using (JsonWriter jWriter = new JsonTextWriter(sWriter))
                {
                    ser.Serialize(jWriter, data);
                }

            }
            else
            {
                JsonSerializer ser = new JsonSerializer();
                using (StreamReader sReader = new StreamReader(pathFile))
                using (JsonReader jReader = new JsonTextReader(sReader))
                {
                    return ser.Deserialize<HashSet<T>>(jReader);
                }
            }


            return data;
        }
        protected static void SaveChange(string pathFile,HashSet<T> data)
        {
     
            JsonSerializer ser= new JsonSerializer();
            using (StreamWriter sWriter = new StreamWriter(pathFile))
            using (JsonWriter jWriter = new JsonTextWriter(sWriter))
            {
                ser.Serialize(jWriter, data);
            }

        }
    }


}
