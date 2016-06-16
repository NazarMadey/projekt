using MojSklep.Data;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zamknijAplikacjęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eksportujDaneKontrahentówToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Inmportowanie danych z pliku XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importujDaneKontrahentówToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import danych produktu";
                openFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Clients data = ClientXmlSerializer.Deserialize(openFileDialog.FileName);

                    NewClientForm newclientForm = new NewClientForm(data);
                    newclientForm.MdiParent = this;
                    newclientForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas importu danych wystąpił błąd: " + x.Message);
            }
        }

        private void dodajKontrahentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClientForm newClients = new NewClientForm();
            newClients.MdiParent = this;
            newClients.Show();
        }

        private void dodajProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProductForm newproductForm = new NewProductForm();
            newproductForm.MdiParent = this;
            newproductForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            NewProductForm newproductForm = new NewProductForm();
            newproductForm.MdiParent = this;
            newproductForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewClientForm newClients = new NewClientForm();
            newClients.MdiParent = this;
            newClients.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metoda szereguje wszystkie otwarte ekzemplerze kaskadowo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uszeregujKaskadowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Metoda szereguje wszystkie otwarte ekzemplerze w poziomie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uszeregujWPoziomieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        /// <summary>
        /// Metoda szereguje wszystkie otwarte ekzemplerze w pionie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uszeregujWPionieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void zamknijFormularzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            NewEmployeeForm newemployeeForm = new NewEmployeeForm();
            newemployeeForm.MdiParent = this;
            newemployeeForm.Show();
        }

        private void dodajPracownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEmployeeForm newemployeeForm = new NewEmployeeForm();
            newemployeeForm.MdiParent = this;
            newemployeeForm.Show();
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm newHelpForm = new HelpForm();
            newHelpForm.MdiParent = this;
            newHelpForm.Show();
        }

        private void listaKlientówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientListForm clientListForm = new ClientListForm();
            clientListForm.MdiParent = this;
            clientListForm.Show();
        }

        /// <summary>
        /// Inmportowanie danych z pliku XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inmportujDaneProduktówToolStripMenuItem_Click(object sender, EventArgs e)  
        {

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import danych produktu";
                openFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*"; 
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Produkty data = ProductXmlSerializer.Deserialize(openFileDialog.FileName);

                    NewProductForm productForm = new NewProductForm(data); 
                    productForm.MdiParent = this; 
                    productForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas importu danych wystąpił błąd: " + x.Message);
            }
           
        }

        /// <summary>
        /// Inmportowanie danych z pliku XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importujDanePracownikówToolStripMenuItem_Click(object sender, EventArgs e)   
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import danych produktu";
                openFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Employee data = EmployeeXmlSerializer.Deserialize(openFileDialog.FileName);

                    NewEmployeeForm newEmployeeForm = new NewEmployeeForm(data);
                    newEmployeeForm.MdiParent = this;
                    newEmployeeForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas importu danych wystąpił błąd: " + x.Message);
            }
        }

        private void listaProduktówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm(); 
            productListForm.MdiParent = this;
            productListForm.Show();
        }

        private void listaPracownikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.MdiParent = this;
            employeeListForm.Show();
        }

        private void dodajProduktToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewProductForm newproductForm = new NewProductForm();
            newproductForm.MdiParent = this;
            newproductForm.Show();
        }

        private void dodajKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClientForm newClients = new NewClientForm();
            newClients.MdiParent = this;
            newClients.Show();
        }

        private void dodajPracownikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewEmployeeForm newemployeeForm = new NewEmployeeForm();
            newemployeeForm.MdiParent = this;
            newemployeeForm.Show();
        }

        private void listaProduktówToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            productListForm.MdiParent = this;
            productListForm.Show();
        }

        private void listaKlientówToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientListForm clientListForm = new ClientListForm();
            clientListForm.MdiParent = this;
            clientListForm.Show();
        }

        private void listaPracownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.MdiParent = this;
            employeeListForm.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
