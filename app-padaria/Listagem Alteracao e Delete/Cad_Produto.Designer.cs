namespace SistemaPadoca
{
    partial class Cad_Produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConsultaProd = new System.Windows.Forms.TextBox();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnDelProduto = new System.Windows.Forms.Button();
            this.btnSairProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 25);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Produto";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(667, 2);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(22, 23);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduto);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(13, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela de Produtos";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProduto.ColumnHeadersHeight = 29;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Produto,
            this.Nome_Produto,
            this.Preco,
            this.CodBarras});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvProduto.Location = new System.Drawing.Point(3, 17);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvProduto.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(514, 355);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            this.dgvProduto.Click += new System.EventHandler(this.dgvProduto_Click);
            // 
            // Id_Produto
            // 
            this.Id_Produto.DataPropertyName = "Id_Produto";
            this.Id_Produto.HeaderText = "Codigo";
            this.Id_Produto.MinimumWidth = 6;
            this.Id_Produto.Name = "Id_Produto";
            this.Id_Produto.ReadOnly = true;
            // 
            // Nome_Produto
            // 
            this.Nome_Produto.DataPropertyName = "Nome_Produto";
            this.Nome_Produto.HeaderText = "Nome";
            this.Nome_Produto.MinimumWidth = 6;
            this.Nome_Produto.Name = "Nome_Produto";
            this.Nome_Produto.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.MinimumWidth = 6;
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // CodBarras
            // 
            this.CodBarras.DataPropertyName = "Cod_Barras";
            this.CodBarras.HeaderText = "Cód Barras";
            this.CodBarras.MinimumWidth = 6;
            this.CodBarras.Name = "CodBarras";
            this.CodBarras.ReadOnly = true;
            // 
            // txtConsultaProd
            // 
            this.txtConsultaProd.Location = new System.Drawing.Point(16, 55);
            this.txtConsultaProd.Name = "txtConsultaProd";
            this.txtConsultaProd.Size = new System.Drawing.Size(515, 20);
            this.txtConsultaProd.TabIndex = 1;
            this.txtConsultaProd.Tag = "";
            this.txtConsultaProd.TextChanged += new System.EventHandler(this.txtConsultaProd_TextChanged);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoProduto.Location = new System.Drawing.Point(554, 98);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(100, 72);
            this.btnNovoProduto.TabIndex = 2;
            this.btnNovoProduto.Text = "Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnDelProduto
            // 
            this.btnDelProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDelProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelProduto.Location = new System.Drawing.Point(554, 221);
            this.btnDelProduto.Name = "btnDelProduto";
            this.btnDelProduto.Size = new System.Drawing.Size(100, 72);
            this.btnDelProduto.TabIndex = 3;
            this.btnDelProduto.Text = "Excluir";
            this.btnDelProduto.UseVisualStyleBackColor = false;
            this.btnDelProduto.Click += new System.EventHandler(this.btnDelProduto_Click);
            // 
            // btnSairProduto
            // 
            this.btnSairProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSairProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairProduto.Location = new System.Drawing.Point(554, 344);
            this.btnSairProduto.Name = "btnSairProduto";
            this.btnSairProduto.Size = new System.Drawing.Size(100, 72);
            this.btnSairProduto.TabIndex = 4;
            this.btnSairProduto.Text = "Sair";
            this.btnSairProduto.UseVisualStyleBackColor = false;
            this.btnSairProduto.Click += new System.EventHandler(this.btnSairProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite o nome do produto: ";
            // 
            // Cad_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(682, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSairProduto);
            this.Controls.Add(this.btnDelProduto);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.txtConsultaProd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cad_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Produto";
            this.Load += new System.EventHandler(this.Cad_Produto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConsultaProd;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnDelProduto;
        private System.Windows.Forms.Button btnSairProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBarras;
    }
}