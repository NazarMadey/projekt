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

    [Table("Klienci")]  
    public class Clients
    {
        int clientId = 0;
        string clientName = "";
        string address = "";
        int discount = 0;
        bool vip = false;
        string telNumber = "";
        string nazwa = "";
        /// <summary>
        ///  Oznaznacza to że KlientId będzie kluczen głównym danych w Tabelie Klienci 
        /// </summary>
        [Key]  
        public int ClientId 
        {
            get { return clientId; }
            set { clientId = value; } 
        }

        /// <summary>
        /// atrybuty xml które będą sterowały procesem serializacji 
        /// </summary>
        /// 


        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        [XmlElement("nazwa-klienta")]  
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
       
        [XmlElement("adres")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [XmlElement("rabat")]
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        [XmlElement("VIP")]
        public bool Vip
        {
            get { return vip; }
            set { vip = value; }
        }

        [XmlElement("numer-telefonu")]
        public string TelNumber
        {
            get { return telNumber; }
            set { telNumber = value; }
        }
        
    }
}
