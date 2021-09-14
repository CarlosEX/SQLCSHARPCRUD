
namespace SQLCSHARPCRUD {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalProjects = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxIdUpadate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLastNameUpadate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirestNameUpadate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpadate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxLastNameAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirestNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTotalProjects);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Projetos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de Projetos";
            // 
            // textBoxTotalProjects
            // 
            this.textBoxTotalProjects.Enabled = false;
            this.textBoxTotalProjects.Location = new System.Drawing.Point(476, 194);
            this.textBoxTotalProjects.Name = "textBoxTotalProjects";
            this.textBoxTotalProjects.Size = new System.Drawing.Size(52, 20);
            this.textBoxTotalProjects.TabIndex = 1;
            this.textBoxTotalProjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.textBoxIdUpadate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxLastNameUpadate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxFirestNameUpadate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonUpadate);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atualizar";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(91, 91);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Deletar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxIdUpadate
            // 
            this.textBoxIdUpadate.Enabled = false;
            this.textBoxIdUpadate.Location = new System.Drawing.Point(91, 13);
            this.textBoxIdUpadate.Name = "textBoxIdUpadate";
            this.textBoxIdUpadate.Size = new System.Drawing.Size(61, 20);
            this.textBoxIdUpadate.TabIndex = 11;
            this.textBoxIdUpadate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Id";
            // 
            // textBoxLastNameUpadate
            // 
            this.textBoxLastNameUpadate.Location = new System.Drawing.Point(91, 65);
            this.textBoxLastNameUpadate.Name = "textBoxLastNameUpadate";
            this.textBoxLastNameUpadate.Size = new System.Drawing.Size(167, 20);
            this.textBoxLastNameUpadate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sobrenome";
            // 
            // textBoxFirestNameUpadate
            // 
            this.textBoxFirestNameUpadate.Location = new System.Drawing.Point(91, 39);
            this.textBoxFirestNameUpadate.Name = "textBoxFirestNameUpadate";
            this.textBoxFirestNameUpadate.Size = new System.Drawing.Size(167, 20);
            this.textBoxFirestNameUpadate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome";
            // 
            // buttonUpadate
            // 
            this.buttonUpadate.Location = new System.Drawing.Point(177, 91);
            this.buttonUpadate.Name = "buttonUpadate";
            this.buttonUpadate.Size = new System.Drawing.Size(81, 23);
            this.buttonUpadate.TabIndex = 5;
            this.buttonUpadate.Text = "Atualizar";
            this.buttonUpadate.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxLastNameAdd);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxFirestNameAdd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Location = new System.Drawing.Point(290, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar";
            // 
            // textBoxLastNameAdd
            // 
            this.textBoxLastNameAdd.Location = new System.Drawing.Point(83, 46);
            this.textBoxLastNameAdd.Name = "textBoxLastNameAdd";
            this.textBoxLastNameAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxLastNameAdd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sobrenome";
            // 
            // textBoxFirestNameAdd
            // 
            this.textBoxFirestNameAdd.Location = new System.Drawing.Point(83, 20);
            this.textBoxFirestNameAdd.Name = "textBoxFirestNameAdd";
            this.textBoxFirestNameAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxFirestNameAdd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(169, 98);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(SQLCSHARPCRUD.Employee);
            // 
            // employeeRepositoryBindingSource
            // 
            this.employeeRepositoryBindingSource.DataSource = typeof(SQLCSHARPCRUD.EmployeeRepository);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(SQLCSHARPCRUD.Employee);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 388);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource employeeRepositoryBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalProjects;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIdUpadate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLastNameUpadate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirestNameUpadate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpadate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxLastNameAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirestNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
    }
}

