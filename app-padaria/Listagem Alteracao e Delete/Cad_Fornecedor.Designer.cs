namespace SistemaPadoca
{
    partial class Cad_Fornecedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.btnNovoFornecedor = new System.Windows.Forms.Button();
            this.btnDelFornec = new System.Windows.Forms.Button();
            this.btnSairFornec = new System.Windows.Forms.Button();
            this.txtConsultaFornec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Fornecedores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Fornecedores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Fixo_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Celular_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 29);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cadastrar Fornecedor\r\n";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(644, 2);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(26, 27);
            this.btnCloseForm.TabIndex = 7;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFornecedores);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela do Fornecedor";
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.AllowUserToResizeColumns = false;
            this.dgvFornecedores.AllowUserToResizeRows = false;
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFornecedores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Fornecedores,
            this.Nome_Fornecedores,
            this.Nome_Vendedor,
            this.Telefone_Fixo_Fornecedor,
            this.Telefone_Celular_Fornecedor});
            this.dgvFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFornecedores.Location = new System.Drawing.Point(3, 17);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowHeadersWidth = 51;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(514, 355);
            this.dgvFornecedores.TabIndex = 0;
            this.dgvFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellClick);
            this.dgvFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellDoubleClick);
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnNovoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoFornecedor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovoFornecedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoFornecedor.Location = new System.Drawing.Point(550, 103);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(100, 72);
            this.btnNovoFornecedor.TabIndex = 3;
            this.btnNovoFornecedor.Text = "Novo";
            this.btnNovoFornecedor.UseVisualStyleBackColor = false;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click_1);
            // 
            // btnDelFornec
            // 
            this.btnDelFornec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDelFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFornec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelFornec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelFornec.Location = new System.Drawing.Point(550, 226);
            this.btnDelFornec.Name = "btnDelFornec";
            this.btnDelFornec.Size = new System.Drawing.Size(100, 72);
            this.btnDelFornec.TabIndex = 4;
            this.btnDelFornec.Text = "Excluir";
            this.btnDelFornec.UseVisualStyleBackColor = false;
            this.btnDelFornec.Click += new System.EventHandler(this.btnDelFornec_Click);
            // 
            // btnSairFornec
            // 
            this.btnSairFornec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSairFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairFornec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSairFornec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairFornec.Location = new System.Drawing.Point(550, 349);
            this.btnSairFornec.Name = "btnSairFornec";
            this.btnSairFornec.Size = new System.Drawing.Size(100, 72);
            this.btnSairFornec.TabIndex = 5;
            this.btnSairFornec.Text = "Sair";
            this.btnSairFornec.UseVisualStyleBackColor = false;
            this.btnSairFornec.Click += new System.EventHandler(this.btnSairFornec_Click);
            // 
            // txtConsultaFornec
            // 
            this.txtConsultaFornec.Location = new System.Drawing.Point(22, 60);
            this.txtConsultaFornec.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultaFornec.Name = "txtConsultaFornec";
            this.txtConsultaFornec.Size = new System.Drawing.Size(510, 21);
            this.txtConsultaFornec.TabIndex = 6;
            this.txtConsultaFornec.TextChanged += new System.EventHandler(this.txtConsultaFornec_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o nome do Fornecedor:";
            // 
            // Id_Fornecedores
            // 
            this.Id_Fornecedores.DataPropertyName = "Id_Fornecedores";
            this.Id_Fornecedores.HeaderText = "Código";
            this.Id_Fornecedores.Name = "Id_Fornecedores";
            this.Id_Fornecedores.ReadOnly = true;
            // 
            // Nome_Fornecedores
            // 
            this.Nome_Fornecedores.DataPropertyName = "Nome_Fornecedores";
            this.Nome_Fornecedores.HeaderText = "Nome";
            this.Nome_Fornecedores.Name = "Nome_Fornecedores";
            this.Nome_Fornecedores.ReadOnly = true;
            // 
            // Nome_Vendedor
            // 
            this.Nome_Vendedor.DataPropertyName = "Nome_Vendedor";
            this.Nome_Vendedor.HeaderText = "Nome Vendedor";
            this.Nome_Vendedor.Name = "Nome_Vendedor";
            this.Nome_Vendedor.ReadOnly = true;
            // 
            // Telefone_Fixo_Fornecedor
            // 
            this.Telefone_Fixo_Fornecedor.DataPropertyName = "Telefone_Fixo_Fornecedor";
            this.Telefone_Fixo_Fornecedor.HeaderText = "Telefone Fixo";
            this.Telefone_Fixo_Fornecedor.Name = "Telefone_Fixo_Fornecedor";
            this.Telefone_Fixo_Fornecedor.ReadOnly = true;
            // 
            // Telefone_Celular_Fornecedor
            // 
            this.Telefone_Celular_Fornecedor.DataPropertyName = "Telefone_Celular_Fornecedor";
            this.Telefone_Celular_Fornecedor.HeaderText = "Telefone Celular";
            this.Telefone_Celular_Fornecedor.Name = "Telefone_Celular_Fornecedor";
            this.Telefone_Celular_Fornecedor.ReadOnly = true;
            // 
            // Cad_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsultaFornec);
            this.Controls.Add(this.btnSairFornec);
            this.Controls.Add(this.btnDelFornec);
            this.Controls.Add(this.btnNovoFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cad_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Fornecedor";
            this.Load += new System.EventHandler(this.Cad_Fornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Button btnNovoFornecedor;
        private System.Windows.Forms.Button btnDelFornec;
        private System.Windows.Forms.Button btnSairFornec;
        private System.Windows.Forms.TextBox txtConsultaFornec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Fornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Fornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Fixo_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Celular_Fornecedor;
    }
}