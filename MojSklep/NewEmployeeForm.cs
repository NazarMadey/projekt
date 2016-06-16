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
    public partial class NewEmployeeForm : Form
    {
        private Employee data = new Employee();

        public NewEmployeeForm () 
        { 
            InitializeComponent(); 
            this.employeeBindingSource.DataSource = data;
        }

        public NewEmployeeForm(Employee employeeData) 
        {
            
            this.data = employeeData;
            InitializeComponent(); 
            this.employeeBindingSource.DataSource = data;

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Zapisz_Click(object sender, EventArgs e)  /// Ta metoda będzie zapisywać dane w głównej klasie sterującej obsługą danych
        {

            try
            {
                if (DataContext.AddOrEditEmployee(data) == true)
                {
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas zapisu wystąpił błąd: " + x.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)  /// Import danych do pliku XML 
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Eksport danych klienta";
                saveFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    EmployeeXmlSerializer.Serialize(data, saveFileDialog.FileName);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas eksportu dannych wystąpił błąd: " + x.Message);
            }

        }
    }
}
