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
    public partial class ClientListForm : Form
    {
        /// <summary>
        /// Ten konstruktor przepisuje liste Klientów do DataSource
        /// </summary>
        public ClientListForm()
        {
            InitializeComponent();
            this.clientsBindingSource1.DataSource = DataContext.GetClientList();
        }

        /// <summary>
        /// metoda Wywołyje formularz Klientów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) 
        {
            NewClientForm newClientForm = new NewClientForm();
            newClientForm.MdiParent = this.ParentForm;
            newClientForm.Show();
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
                Clients client = row.DataBoundItem as Clients;
                if (client != null)
                {          
                    NewClientForm clientForm = new NewClientForm();
                    clientForm.MdiParent = this.ParentForm;
                    clientForm.Show();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource1.ResetBindings(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
