using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MojSklep.Data
{
    [Table("Produkty")]
    public class Produkty
    {
            int productId = 0;
            string productName = "";
            string group = "";
            string lotNumber = "";
            int stockAmount = 1;
            bool isBestseller = false;
            string color = "";
            string description; 
        /// <summary>
        /// Oznaznacza to że ProdukttId będzie kluczen głównym danych w Tabelie Produkty 
        /// </summary>
        [Key]
        public int ProductId
        {
            get { return productId;}
            set{productId = value;}
        }
        /// <summary>
        /// atrybuty xml które będą sterowały procesem serializacji 
        /// </summary>
            [XmlElement("nazwa-produktu")]  
            public string ProductName
            {
                get { return productName; }
                set { productName = value; }
            }

            [XmlElement("grupa")]
            public string Group
            {
                get { return group; }
                set { group = value; }
            }

            [XmlElement("numer-seryjny")]
            public string LotNumber
            {
                get { return lotNumber; }
                set { lotNumber = value; }
            }
            [XmlElement("stan-magazynowy")]
            public int StockAmount
            {
                get { return stockAmount; }
                set { stockAmount = value; }
            }

            [XmlElement("kolor")]
            public string Color
            {
                get { return color; }
                set {color = value; }
            }

        [XmlElement("bestseller")]
            public bool IsBestseller
            {
                get { return isBestseller; }
                set { isBestseller = value; }
            }

        [XmlElement("opis")]
            public string Description
            {
                get { return description; }
                set { description = value; }
            }

       

       
    }
}
