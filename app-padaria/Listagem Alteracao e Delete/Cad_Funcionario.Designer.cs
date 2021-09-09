namespace SistemaPadoca
{
    partial class Cad_Funcionario
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
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtConsultaFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.btnDelFuncionario = new System.Windows.Forms.Button();
            this.btnSairFuncionario = new System.Windows.Forms.Button();
            this.Id_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Permissoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Fixo_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cadastrar Funcionario";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(654, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(26, 27);
            this.btnCloseForm.TabIndex = 7;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFuncionarios);
            this.groupBox1.Location = new System.Drawing.Point(14, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela de Funcionário";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeColumns = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Funcionario,
            this.Id_Permissoes,
            this.Column2,
            this.Column3,
            this.CPF_Funcionario,
            this.Nome_Funcionario,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Telefone_Fixo_Funcionario,
            this.Column1});
            this.dgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionarios.Location = new System.Drawing.Point(3, 21);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowHeadersWidth = 51;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(514, 342);
            this.dgvFuncionarios.TabIndex = 0;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            this.dgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellDoubleClick);
            // 
            // txtConsultaFuncionario
            // 
            this.txtConsultaFuncionario.Location = new System.Drawing.Point(19, 68);
            this.txtConsultaFuncionario.Name = "txtConsultaFuncionario";
            this.txtConsultaFuncionario.Size = new System.Drawing.Size(515, 25);
            this.txtConsultaFuncionario.TabIndex = 3;
            this.txtConsultaFuncionario.TextChanged += new System.EventHandler(this.txtConsultaFuncionario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localize um funcionario por nome:";
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnNovoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoFuncionario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoFuncionario.Location = new System.Drawing.Point(559, 112);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(100, 72);
            this.btnNovoFuncionario.TabIndex = 9;
            this.btnNovoFuncionario.Text = "Novo Funcionario";
            this.btnNovoFuncionario.UseVisualStyleBackColor = false;
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // btnDelFuncionario
            // 
            this.btnDelFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDelFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFuncionario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelFuncionario.Location = new System.Drawing.Point(559, 233);
            this.btnDelFuncionario.Name = "btnDelFuncionario";
            this.btnDelFuncionario.Size = new System.Drawing.Size(100, 72);
            this.btnDelFuncionario.TabIndex = 11;
            this.btnDelFuncionario.Text = "Excluir";
            this.btnDelFuncionario.UseVisualStyleBackColor = false;
            this.btnDelFuncionario.Click += new System.EventHandler(this.btnDelFuncionario_Click);
            // 
            // btnSairFuncionario
            // 
            this.btnSairFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSairFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairFuncionario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairFuncionario.Location = new System.Drawing.Point(559, 358);
            this.btnSairFuncionario.Name = "btnSairFuncionario";
            this.btnSairFuncionario.Size = new System.Drawing.Size(100, 72);
            this.btnSairFuncionario.TabIndex = 12;
            this.btnSairFuncionario.Text = "Sair";
            this.btnSairFuncionario.UseVisualStyleBackColor = false;
            this.btnSairFuncionario.Click += new System.EventHandler(this.btnSairFuncionario_Click);
            // 
            // Id_Funcionario
            // 
            this.Id_Funcionario.DataPropertyName = "Id_Funcionario";
            this.Id_Funcionario.HeaderText = "Código";
            this.Id_Funcionario.MinimumWidth = 6;
            this.Id_Funcionario.Name = "Id_Funcionario";
            this.Id_Funcionario.ReadOnly = true;
            // 
            // Id_Permissoes
            // 
            this.Id_Permissoes.DataPropertyName = "Id_Permissoes";
            this.Id_Permissoes.HeaderText = "Nivel";
            this.Id_Permissoes.MinimumWidth = 6;
            this.Id_Permissoes.Name = "Id_Permissoes";
            this.Id_Permissoes.ReadOnly = true;
            this.Id_Permissoes.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Username";
            this.Column2.HeaderText = "User";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Password";
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // CPF_Funcionario
            // 
            this.CPF_Funcionario.DataPropertyName = "CPF_Funcionario";
            this.CPF_Funcionario.HeaderText = "CPF";
            this.CPF_Funcionario.MinimumWidth = 6;
            this.CPF_Funcionario.Name = "CPF_Funcionario";
            this.CPF_Funcionario.ReadOnly = true;
            // 
            // Nome_Funcionario
            // 
            this.Nome_Funcionario.DataPropertyName = "Nome_Funcionario";
            this.Nome_Funcionario.HeaderText = "Nome";
            this.Nome_Funcionario.MinimumWidth = 6;
            this.Nome_Funcionario.Name = "Nome_Funcionario";
            this.Nome_Funcionario.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Bairro_Funcionario";
            this.Column5.HeaderText = "Bairro";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Rua_Funcionario";
            this.Column4.HeaderText = "Rua";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Numero_Residencia_Funcionario";
            this.Column6.HeaderText = "N°";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Telefone_Fixo_Funcionario
            // 
            this.Telefone_Fixo_Funcionario.DataPropertyName = "Telefone_Fixo_Funcionario";
            this.Telefone_Fixo_Funcionario.HeaderText = "Telefone Fixo";
            this.Telefone_Fixo_Funcionario.MinimumWidth = 6;
            this.Telefone_Fixo_Funcionario.Name = "Telefone_Fixo_Funcionario";
            this.Telefone_Fixo_Funcionario.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Telefone_Celular_Funcionario";
            this.Column1.HeaderText = "Telefone Cel";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Cad_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 473);
            this.Controls.Add(this.btnSairFuncionario);
            this.Controls.Add(this.btnDelFuncionario);
            this.Controls.Add(this.btnNovoFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConsultaFuncionario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Cad_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Funcionario";
            this.Load += new System.EventHandler(this.Cad_Funcionario_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cad_Funcionario_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtConsultaFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoFuncionario;
        private System.Windows.Forms.Button btnDelFuncionario;
        private System.Windows.Forms.Button btnSairFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Permissoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Fixo_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}