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
    class ClientXmlSerializer
    {
        /// <summary>
        /// 2 metody statyczne jakie obsługują serializacje
        /// </summary>
        /// <param name="client"></param>
        /// <param name="filePath"></param>
        public static void Serialize(Clients client, string filePath)  
        {  
            XmlSerializer serializer = new XmlSerializer(typeof(Clients));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, client);
            textWriter.Close();
        }
        public static Clients Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Clients));
            TextReader textReader = new StreamReader(filePath);
            Clients client = (Clients)deserializer.Deserialize(textReader);
            textReader.Close();
            return client;
        }   
    }
}
