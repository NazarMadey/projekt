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
    public partial class EmployeeListForm : Form
    {
        /// <summary>
        /// Ten konstruktor przepisuje liste pracowników do DataSource
        /// </summary>
        public EmployeeListForm()
        {
            InitializeComponent();
            this.employeeBindingSource.DataSource = DataContext.GetEmployeeList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                Employee employee = row.DataBoundItem as Employee;
                if (employee != null)
                {
                    NewEmployeeForm newEmployeeForm = new NewEmployeeForm();
                    newEmployeeForm.MdiParent = this.ParentForm;
                    newEmployeeForm.Show();

                }
            }
        }
        /// <summary>
        /// metoda Wywołyje formularz Pracowników 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) 
        {
            NewEmployeeForm newEmployeeForm = new NewEmployeeForm();
            newEmployeeForm.MdiParent = this.ParentForm;
            newEmployeeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.ResetBindings(true);
        }
    }
}
