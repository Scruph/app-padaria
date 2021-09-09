namespace SistemaPadoca
{
    partial class Cad_Cliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Residencia_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Fixo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Celular_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnDelCliente = new System.Windows.Forms.Button();
            this.btnSairCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 29);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cadastrar Cliente";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(652, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(26, 27);
            this.btnCloseForm.TabIndex = 7;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela de Clientes";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.Numero_Residencia_Cliente,
            this.Nome_Cliente,
            this.CPF_Cliente,
            this.Bairro_Cliente,
            this.Rua_Cliente,
            this.Telefone_Fixo_Cliente,
            this.Telefone_Celular_Cliente});
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCliente.Location = new System.Drawing.Point(3, 21);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(514, 351);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            this.dgvCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentDoubleClick);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.DataPropertyName = "Id_Cliente";
            this.Id_Cliente.HeaderText = "Código";
            this.Id_Cliente.MinimumWidth = 6;
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.ReadOnly = true;
            this.Id_Cliente.Width = 83;
            // 
            // Numero_Residencia_Cliente
            // 
            this.Numero_Residencia_Cliente.DataPropertyName = "Numero_Residencia_Cliente";
            this.Numero_Residencia_Cliente.HeaderText = "Número Residêncial";
            this.Numero_Residencia_Cliente.MinimumWidth = 6;
            this.Numero_Residencia_Cliente.Name = "Numero_Residencia_Cliente";
            this.Numero_Residencia_Cliente.ReadOnly = true;
            this.Numero_Residencia_Cliente.Width = 154;
            // 
            // Nome_Cliente
            // 
            this.Nome_Cliente.DataPropertyName = "Nome_Cliente";
            this.Nome_Cliente.HeaderText = "Nome";
            this.Nome_Cliente.MinimumWidth = 6;
            this.Nome_Cliente.Name = "Nome_Cliente";
            this.Nome_Cliente.ReadOnly = true;
            this.Nome_Cliente.Width = 76;
            // 
            // CPF_Cliente
            // 
            this.CPF_Cliente.DataPropertyName = "CPF_Cliente";
            this.CPF_Cliente.HeaderText = "CPF";
            this.CPF_Cliente.MinimumWidth = 6;
            this.CPF_Cliente.Name = "CPF_Cliente";
            this.CPF_Cliente.ReadOnly = true;
            this.CPF_Cliente.Width = 67;
            // 
            // Bairro_Cliente
            // 
            this.Bairro_Cliente.DataPropertyName = "Bairro_Cliente";
            this.Bairro_Cliente.HeaderText = "Bairro";
            this.Bairro_Cliente.MinimumWidth = 6;
            this.Bairro_Cliente.Name = "Bairro_Cliente";
            this.Bairro_Cliente.ReadOnly = true;
            this.Bairro_Cliente.Width = 76;
            // 
            // Rua_Cliente
            // 
            this.Rua_Cliente.DataPropertyName = "Rua_Cliente";
            this.Rua_Cliente.HeaderText = "Rua";
            this.Rua_Cliente.MinimumWidth = 6;
            this.Rua_Cliente.Name = "Rua_Cliente";
            this.Rua_Cliente.ReadOnly = true;
            this.Rua_Cliente.Width = 64;
            // 
            // Telefone_Fixo_Cliente
            // 
            this.Telefone_Fixo_Cliente.DataPropertyName = "Telefone_Fixo_Cliente";
            this.Telefone_Fixo_Cliente.HeaderText = "Telefone Fixo";
            this.Telefone_Fixo_Cliente.MinimumWidth = 6;
            this.Telefone_Fixo_Cliente.Name = "Telefone_Fixo_Cliente";
            this.Telefone_Fixo_Cliente.ReadOnly = true;
            this.Telefone_Fixo_Cliente.Width = 112;
            // 
            // Telefone_Celular_Cliente
            // 
            this.Telefone_Celular_Cliente.DataPropertyName = "Telefone_Celular_Cliente";
            this.Telefone_Celular_Cliente.HeaderText = "Telefone Celular";
            this.Telefone_Celular_Cliente.MinimumWidth = 6;
            this.Telefone_Celular_Cliente.Name = "Telefone_Celular_Cliente";
            this.Telefone_Celular_Cliente.ReadOnly = true;
            this.Telefone_Celular_Cliente.Width = 129;
            // 
            // txtPesquisaCliente
            // 
            this.txtPesquisaCliente.Location = new System.Drawing.Point(18, 62);
            this.txtPesquisaCliente.Name = "txtPesquisaCliente";
            this.txtPesquisaCliente.Size = new System.Drawing.Size(520, 25);
            this.txtPesquisaCliente.TabIndex = 1;
            this.txtPesquisaCliente.TextChanged += new System.EventHandler(this.txtPesquisaCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Localize um Cliente por nome";
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoCliente.Location = new System.Drawing.Point(558, 106);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(100, 72);
            this.btnNovoCliente.TabIndex = 2;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnDelCliente
            // 
            this.btnDelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelCliente.Location = new System.Drawing.Point(558, 229);
            this.btnDelCliente.Name = "btnDelCliente";
            this.btnDelCliente.Size = new System.Drawing.Size(100, 72);
            this.btnDelCliente.TabIndex = 3;
            this.btnDelCliente.Text = "Excluir ";
            this.btnDelCliente.UseVisualStyleBackColor = false;
            this.btnDelCliente.Click += new System.EventHandler(this.btnDelCliente_Click);
            // 
            // btnSairCliente
            // 
            this.btnSairCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSairCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairCliente.Location = new System.Drawing.Point(558, 352);
            this.btnSairCliente.Name = "btnSairCliente";
            this.btnSairCliente.Size = new System.Drawing.Size(100, 72);
            this.btnSairCliente.TabIndex = 4;
            this.btnSairCliente.Text = "Sair";
            this.btnSairCliente.UseVisualStyleBackColor = false;
            this.btnSairCliente.Click += new System.EventHandler(this.btnSairCliente_Click);
            // 
            // Cad_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.Controls.Add(this.btnSairCliente);
            this.Controls.Add(this.btnDelCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesquisaCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cad_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Cliente";
            this.Load += new System.EventHandler(this.Cad_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtPesquisaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnDelCliente;
        private System.Windows.Forms.Button btnSairCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Residencia_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Fixo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Celular_Cliente;
    }
}