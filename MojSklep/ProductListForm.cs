using MojSklep.Data;
using MojSklep.DataAccess;
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
    public partial class ProductListForm : Form
    {
        /// <summary>
        /// Ten konstruktor przepisuje liste Produktów do DataSource
        /// </summary>
        public ProductListForm()
        {
            InitializeComponent();
            this.produktyBindingSource.DataSource = DataContext.GetProductList();
        }
        /// <summary>
        /// Pozwala edytować już zapisane dane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Produkty produkty = row.DataBoundItem as Produkty; 
                if (produkty != null)
                {
                    NewProductForm ProductForm = new NewProductForm(); 
                    ProductForm.MdiParent = this.ParentForm;
                    ProductForm.Show();

                }
            }
        }
        /// <summary>
        /// metoda Wywołyje formularz Produktów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) 
        {
            NewProductForm newProductForm = new NewProductForm();
            newProductForm.MdiParent = this.ParentForm;
            newProductForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.produktyBindingSource.ResetBindings(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produktyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void produktyBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
