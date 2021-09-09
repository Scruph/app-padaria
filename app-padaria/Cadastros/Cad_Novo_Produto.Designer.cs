namespace SistemaPadoca
{
    partial class Cad_Novo_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Novo_Produto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigoProd = new System.Windows.Forms.TextBox();
            this.txtnome_prod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbunidade_prod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbarcode_prod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtestoque_prod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudpreco_prod = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbtipo_prod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gpDadosProduto = new System.Windows.Forms.GroupBox();
            this.CbFornec = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_prod = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.btnLimparForm = new System.Windows.Forms.Button();
            this.btnSairNovoProd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudpreco_prod)).BeginInit();
            this.gpDadosProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 33);
            this.panel1.TabIndex = 1;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(810, 1);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(29, 30);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Produto";
            // 
            // TxtCodigoProd
            // 
            this.TxtCodigoProd.Location = new System.Drawing.Point(715, 377);
            this.TxtCodigoProd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigoProd.Name = "TxtCodigoProd";
            this.TxtCodigoProd.ReadOnly = true;
            this.TxtCodigoProd.Size = new System.Drawing.Size(73, 25);
            this.TxtCodigoProd.TabIndex = 0;
            this.TxtCodigoProd.Visible = false;
            // 
            // txtnome_prod
            // 
            this.txtnome_prod.Location = new System.Drawing.Point(86, 41);
            this.txtnome_prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome_prod.MaxLength = 35;
            this.txtnome_prod.Name = "txtnome_prod";
            this.txtnome_prod.Size = new System.Drawing.Size(525, 27);
            this.txtnome_prod.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // cbunidade_prod
            // 
            this.cbunidade_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunidade_prod.FormattingEnabled = true;
            this.cbunidade_prod.Items.AddRange(new object[] {
            "Escolher...",
            "UN \t",
            "KG "});
            this.cbunidade_prod.Location = new System.Drawing.Point(86, 113);
            this.cbunidade_prod.Margin = new System.Windows.Forms.Padding(4);
            this.cbunidade_prod.Name = "cbunidade_prod";
            this.cbunidade_prod.Size = new System.Drawing.Size(163, 27);
            this.cbunidade_prod.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Unidade:";
            // 
            // txtbarcode_prod
            // 
            this.txtbarcode_prod.Location = new System.Drawing.Point(430, 185);
            this.txtbarcode_prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtbarcode_prod.MaxLength = 13;
            this.txtbarcode_prod.Name = "txtbarcode_prod";
            this.txtbarcode_prod.Size = new System.Drawing.Size(181, 27);
            this.txtbarcode_prod.TabIndex = 5;
            this.txtbarcode_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarcode_prod_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cód. de Barras:";
            // 
            // txtestoque_prod
            // 
            this.txtestoque_prod.Location = new System.Drawing.Point(430, 258);
            this.txtestoque_prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtestoque_prod.MaxLength = 10;
            this.txtestoque_prod.Name = "txtestoque_prod";
            this.txtestoque_prod.Size = new System.Drawing.Size(124, 27);
            this.txtestoque_prod.TabIndex = 7;
            this.txtestoque_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtestoque_prod_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Estoque:";
            // 
            // nudpreco_prod
            // 
            this.nudpreco_prod.DecimalPlaces = 2;
            this.nudpreco_prod.Location = new System.Drawing.Point(86, 258);
            this.nudpreco_prod.Margin = new System.Windows.Forms.Padding(4);
            this.nudpreco_prod.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudpreco_prod.Name = "nudpreco_prod";
            this.nudpreco_prod.Size = new System.Drawing.Size(97, 27);
            this.nudpreco_prod.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Preço:";
            // 
            // cbtipo_prod
            // 
            this.cbtipo_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo_prod.FormattingEnabled = true;
            this.cbtipo_prod.Items.AddRange(new object[] {
            "Frios",
            "Laticinios",
            "Panificações",
            "Doces",
            "Refrigerantes"});
            this.cbtipo_prod.Location = new System.Drawing.Point(86, 185);
            this.cbtipo_prod.Margin = new System.Windows.Forms.Padding(4);
            this.cbtipo_prod.Name = "cbtipo_prod";
            this.cbtipo_prod.Size = new System.Drawing.Size(161, 27);
            this.cbtipo_prod.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tipo:";
            // 
            // gpDadosProduto
            // 
            this.gpDadosProduto.Controls.Add(this.CbFornec);
            this.gpDadosProduto.Controls.Add(this.label11);
            this.gpDadosProduto.Controls.Add(this.label10);
            this.gpDadosProduto.Controls.Add(this.dt_prod);
            this.gpDadosProduto.Controls.Add(this.label9);
            this.gpDadosProduto.Controls.Add(this.cbtipo_prod);
            this.gpDadosProduto.Controls.Add(this.label8);
            this.gpDadosProduto.Controls.Add(this.nudpreco_prod);
            this.gpDadosProduto.Controls.Add(this.label7);
            this.gpDadosProduto.Controls.Add(this.txtestoque_prod);
            this.gpDadosProduto.Controls.Add(this.label6);
            this.gpDadosProduto.Controls.Add(this.txtbarcode_prod);
            this.gpDadosProduto.Controls.Add(this.label5);
            this.gpDadosProduto.Controls.Add(this.cbunidade_prod);
            this.gpDadosProduto.Controls.Add(this.label4);
            this.gpDadosProduto.Controls.Add(this.txtnome_prod);
            this.gpDadosProduto.Font = new System.Drawing.Font("Arial", 10F);
            this.gpDadosProduto.Location = new System.Drawing.Point(13, 50);
            this.gpDadosProduto.Margin = new System.Windows.Forms.Padding(4);
            this.gpDadosProduto.Name = "gpDadosProduto";
            this.gpDadosProduto.Padding = new System.Windows.Forms.Padding(4);
            this.gpDadosProduto.Size = new System.Drawing.Size(638, 384);
            this.gpDadosProduto.TabIndex = 2;
            this.gpDadosProduto.TabStop = false;
            this.gpDadosProduto.Text = "Produto";
            // 
            // CbFornec
            // 
            this.CbFornec.FormattingEnabled = true;
            this.CbFornec.Location = new System.Drawing.Point(430, 113);
            this.CbFornec.Name = "CbFornec";
            this.CbFornec.Size = new System.Drawing.Size(154, 27);
            this.CbFornec.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Fornecedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 332);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Data de Cadastro:";
            // 
            // dt_prod
            // 
            this.dt_prod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_prod.Location = new System.Drawing.Point(146, 327);
            this.dt_prod.Margin = new System.Windows.Forms.Padding(4);
            this.dt_prod.Name = "dt_prod";
            this.dt_prod.Size = new System.Drawing.Size(234, 27);
            this.dt_prod.TabIndex = 8;
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnSalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProd.Image")));
            this.btnSalvarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarProd.Location = new System.Drawing.Point(669, 75);
            this.btnSalvarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(164, 55);
            this.btnSalvarProd.TabIndex = 9;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.UseVisualStyleBackColor = false;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click);
            // 
            // btnLimparForm
            // 
            this.btnLimparForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLimparForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparForm.Image")));
            this.btnLimparForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparForm.Location = new System.Drawing.Point(669, 170);
            this.btnLimparForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparForm.Name = "btnLimparForm";
            this.btnLimparForm.Size = new System.Drawing.Size(164, 61);
            this.btnLimparForm.TabIndex = 10;
            this.btnLimparForm.Text = "Limpar";
            this.btnLimparForm.UseVisualStyleBackColor = false;
            this.btnLimparForm.Click += new System.EventHandler(this.btnLimparForm_Click);
            // 
            // btnSairNovoProd
            // 
            this.btnSairNovoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSairNovoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairNovoProd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairNovoProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairNovoProd.Image = ((System.Drawing.Image)(resources.GetObject("btnSairNovoProd.Image")));
            this.btnSairNovoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairNovoProd.Location = new System.Drawing.Point(669, 266);
            this.btnSairNovoProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSairNovoProd.Name = "btnSairNovoProd";
            this.btnSairNovoProd.Size = new System.Drawing.Size(164, 65);
            this.btnSairNovoProd.TabIndex = 11;
            this.btnSairNovoProd.Text = "Cancelar";
            this.btnSairNovoProd.UseVisualStyleBackColor = false;
            this.btnSairNovoProd.Click += new System.EventHandler(this.btnSairNovoProd_Click);
            // 
            // Cad_Novo_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 470);
            this.Controls.Add(this.btnSalvarProd);
            this.Controls.Add(this.btnLimparForm);
            this.Controls.Add(this.btnSairNovoProd);
            this.Controls.Add(this.gpDadosProduto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCodigoProd);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cad_Novo_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "/";
            this.Load += new System.EventHandler(this.Cad_Novo_Produto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudpreco_prod)).EndInit();
            this.gpDadosProduto.ResumeLayout(false);
            this.gpDadosProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigoProd;
        private System.Windows.Forms.TextBox txtnome_prod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbunidade_prod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbarcode_prod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtestoque_prod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudpreco_prod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbtipo_prod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpDadosProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_prod;
        private System.Windows.Forms.ComboBox CbFornec;
        private System.Windows.Forms.Button btnSairNovoProd;
        private System.Windows.Forms.Button btnLimparForm;
        private System.Windows.Forms.Button btnSalvarProd;
        private System.Windows.Forms.Label label11;
    }
}