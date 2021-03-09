namespace StoreManager.DATA_ACCESS
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Linq.Dynamic.Core;
    using System.Xml.Serialization;

    /// <summary>
    /// Defines the <see cref="HandleFile{T}" />.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public class HandleFile<T>
    {
        /// <summary>
        /// Defines the _serializer.
        /// </summary>
        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(HashSet<T>));

        /// <summary>
        /// The ReadFile. Read data on file
        /// </summary>
        /// <param name="pathFile">The pathFile<see cref="string"/>.</param>
        /// <returns>The <see cref="HashSet{T}"/>.</returns>
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

        /// <summary>
        /// The SaveChange. Write data on file
        /// </summary>
        /// <param name="pathFile">The pathFile<see cref="string"/>.</param>
        /// <param name="data">The data<see cref="HashSet{T}"/>.</param>
        protected static void SaveChange(string pathFile, HashSet<T> data)
        {

            JsonSerializer ser = new JsonSerializer();
            using (StreamWriter sWriter = new StreamWriter(pathFile))
            using (JsonWriter jWriter = new JsonTextWriter(sWriter))
            {
                ser.Serialize(jWriter, data);
            }
        }

        /// <summary>
        /// The DivideData."Divide data to pading"
        /// </summary>
        /// <param name="listItem">The listItem<see cref="HashSet{T}"/>.</param>
        /// <param name="page">The page<see cref="int"/>.</param>
        /// <param name="size">The size<see cref="int"/>.</param>
        /// <returns>The <see cref="(T[] listPage, int pages, int page)"/>.</returns>
        public (T[] listPage, int pages, int page) DivideData(HashSet<T> listItem, int page, int size)
        {
            int pages = (int)Math.Ceiling((double)listItem.Count / size);
            var listPage = listItem.Skip((page - 1) * size).Take(size).ToArray();
            return (listPage, pages, page);
        }
    }
}
