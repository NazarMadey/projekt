using MojSklep.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MojSklep.Serializers
{
    class ProductXmlSerializer
    {
        /// <summary>
        /// 2 metody statyczne jakie obsługują serializacje
        /// </summary>
        /// <param name="product"></param>
        /// <param name="filePath"></param>
        public static void Serialize(Produkty product, string filePath) 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Produkty));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, product);
            textWriter.Close();
        }
        public static Produkty Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Produkty)); 
            TextReader textReader = new StreamReader(filePath);
            Produkty product = (Produkty)deserializer.Deserialize(textReader);
            textReader.Close();
            return product;
        }
    }
}
