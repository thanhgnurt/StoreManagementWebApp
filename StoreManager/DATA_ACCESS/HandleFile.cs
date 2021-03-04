﻿using System;
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

namespace StoreManager.DATA_ACCESS
{
    public class HandleFile<T>
    {

        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(HashSet<T>));

        protected static HashSet<T> ReadFile(string pathFile, HashSet<T> dataTemplate)
        {
            HashSet<T> data = new HashSet<T>();
            if (!File.Exists(pathFile))
            {
                using var streamCre = File.Create(pathFile);
                _serializer.Serialize(streamCre, dataTemplate);

            }
            using var streamRead = File.OpenRead(pathFile);
            data = _serializer.Deserialize(streamRead) as HashSet<T>;
            return data;
        }
    }


}
