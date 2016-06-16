using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MojSklep.Data
{
    public class Employee
    {
        
        string pracownikName = "";
        string addressZam = "";
        int wiek = 0;
        int clockJob = 0;
        string telNumberPracownik = "";
        string positionPrac = "";
        string infoPrac = "";

        /// <summary>
        /// atrybuty xml które będą sterowały procesem serializacji
        /// </summary>
        [XmlElement("nazwa-pracownika")]  
        public string PracownikName
        {
            get { return pracownikName; }
            set { pracownikName = value; }
        }

        [XmlElement("adres-zamieszkania")]
        public string AddressZam
        {
            get { return addressZam; }
            set { addressZam = value; }
        }

        [XmlElement("wiek")]
        public int Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }

        [XmlElement("godziny-pracy")]
        public int ClockJob
        {
            get { return clockJob; }
            set { clockJob = value; }
        }

        [XmlElement("numer-telefonu")]
        public string TelNumberPracownik
        {
            get { return telNumberPracownik; }
            set { telNumberPracownik = value; }
        }

        [XmlElement("stanowisko")]
        public string PositionPrac
        {
            get { return positionPrac; }
            set { positionPrac = value; }
        }

        [XmlElement("dodatkowa-informacja")]
        public string InfoPrac
        {
            get { return infoPrac; }
            set { infoPrac = value; }
        }


        public int EmployeeId { get; set; }
    }
}
