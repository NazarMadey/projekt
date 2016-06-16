namespace MojSklep
{
    partial class EmployeeListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressZamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNumberPracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionPracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoPracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pracownikNameDataGridViewTextBoxColumn,
            this.addressZamDataGridViewTextBoxColumn,
            this.wiekDataGridViewTextBoxColumn,
            this.clockJobDataGridViewTextBoxColumn,
            this.telNumberPracownikDataGridViewTextBoxColumn,
            this.positionPracDataGridViewTextBoxColumn,
            this.infoPracDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(MojSklep.Data.Employee);
            // 
            // pracownikNameDataGridViewTextBoxColumn
            // 
            this.pracownikNameDataGridViewTextBoxColumn.DataPropertyName = "PracownikName";
            this.pracownikNameDataGridViewTextBoxColumn.HeaderText = "PracownikName";
            this.pracownikNameDataGridViewTextBoxColumn.Name = "pracownikNameDataGridViewTextBoxColumn";
            this.pracownikNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressZamDataGridViewTextBoxColumn
            // 
            this.addressZamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressZamDataGridViewTextBoxColumn.DataPropertyName = "AddressZam";
            this.addressZamDataGridViewTextBoxColumn.HeaderText = "AddressZam";
            this.addressZamDataGridViewTextBoxColumn.Name = "addressZamDataGridViewTextBoxColumn";
            this.addressZamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wiekDataGridViewTextBoxColumn
            // 
            this.wiekDataGridViewTextBoxColumn.DataPropertyName = "Wiek";
            this.wiekDataGridViewTextBoxColumn.HeaderText = "Wiek";
            this.wiekDataGridViewTextBoxColumn.Name = "wiekDataGridViewTextBoxColumn";
            this.wiekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clockJobDataGridViewTextBoxColumn
            // 
            this.clockJobDataGridViewTextBoxColumn.DataPropertyName = "ClockJob";
            this.clockJobDataGridViewTextBoxColumn.HeaderText = "ClockJob";
            this.clockJobDataGridViewTextBoxColumn.Name = "clockJobDataGridViewTextBoxColumn";
            this.clockJobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telNumberPracownikDataGridViewTextBoxColumn
            // 
            this.telNumberPracownikDataGridViewTextBoxColumn.DataPropertyName = "TelNumberPracownik";
            this.telNumberPracownikDataGridViewTextBoxColumn.HeaderText = "TelNumberPracownik";
            this.telNumberPracownikDataGridViewTextBoxColumn.Name = "telNumberPracownikDataGridViewTextBoxColumn";
            this.telNumberPracownikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionPracDataGridViewTextBoxColumn
            // 
            this.positionPracDataGridViewTextBoxColumn.DataPropertyName = "PositionPrac";
            this.positionPracDataGridViewTextBoxColumn.HeaderText = "PositionPrac";
            this.positionPracDataGridViewTextBoxColumn.Name = "positionPracDataGridViewTextBoxColumn";
            this.positionPracDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoPracDataGridViewTextBoxColumn
            // 
            this.infoPracDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.infoPracDataGridViewTextBoxColumn.DataPropertyName = "InfoPrac";
            this.infoPracDataGridViewTextBoxColumn.HeaderText = "InfoPrac";
            this.infoPracDataGridViewTextBoxColumn.Name = "infoPracDataGridViewTextBoxColumn";
            this.infoPracDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edytuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Odświedż";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(649, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Zamknij";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 376);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmployeeListForm";
            this.Text = "Lista Pracowników";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressZamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wiekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNumberPracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionPracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoPracDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}