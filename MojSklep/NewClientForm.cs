using MojSklep.Data;
using MojSklep.DataAccess;
using MojSklep.Serializers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojSklep
{
    public partial class NewClientForm : Form
    {
        public Clients data = new Clients();

        public NewClientForm() 
        {
            InitializeComponent();
            this.clientsBindingSource.DataSource = data;
        }

        public NewClientForm(Clients clientsData)
        {
            
            this.data = clientsData;
            InitializeComponent(); 
            this.clientsBindingSource.DataSource = data;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2Zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) /// Ta metoda będzie zapisywać dane w głównej klasie sterującej obsługą danych
        {

            try
            {
                if (DataContext.AddOrEditClient(data) == true)
                {
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas zapisu wystąpił błąd: " + x.Message);
            }
            /*try
            {
                if (DataContext.AddOrEditClient(data) == true)
                {
                    DatabaseTool.ConnectDataBase(data.ClientName,data.Address,data.Vip,data.Discount,data.TelNumber);
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas zapisu wystąpił błąd: " + x.Message);
            }*/
            /*StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nazwa klienta: " + data.ClientName);
            sb.AppendLine("Adres: " + data.Address);
            sb.AppendLine("Rabat: " + data.Discount);
            sb.AppendLine("Numer tel.: " + data.TelNumber);
            sb.AppendLine("VIP: " + (data.Vip == true ? "TAK" : "Nie"));

            MessageBox.Show(sb.ToString());*/
        }

        private void button3_Click(object sender, EventArgs e)  /// Import danych do pliku XML 
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Eksport danych kontrahenta";
                saveFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*"; 
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ClientXmlSerializer.Serialize(data, saveFileDialog.FileName);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas eksportu wystąpił błąd: " + x.Message);
            }
        }
    }
}
