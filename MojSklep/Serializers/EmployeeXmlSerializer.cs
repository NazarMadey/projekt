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
    class EmployeeXmlSerializer
    {
        /// <summary>
        /// 2 metody statyczne jakie obsługują serializacje
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="filePath"></param>
        public static void Serialize(Employee employee, string filePath)  
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            TextWriter textWriter = new StreamWriter(filePath); serializer.Serialize(textWriter, employee);
            textWriter.Close();
        }
        public static Employee Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Employee));
            TextReader textReader = new StreamReader(filePath);
            Employee employee = (Employee)deserializer.Deserialize(textReader);
            textReader.Close();
            return employee;
        } 
    }
}
