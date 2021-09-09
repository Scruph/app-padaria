namespace SistemaPadoca
{
    partial class Cad_Novo_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Novo_Cliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbInfoCli = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.npdLimiteCliente = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtTelCel = new System.Windows.Forms.MaskedTextBox();
            this.txtTelFixo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.txtRuaCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.btnLimparForm = new System.Windows.Forms.Button();
            this.btnSairNovoCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpbInfoCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdLimiteCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Location = new System.Drawing.Point(-7, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 31);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastrar Cliente";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(742, 4);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(26, 28);
            this.btnCloseForm.TabIndex = 7;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(76, 57);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(269, 27);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(407, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // gpbInfoCli
            // 
            this.gpbInfoCli.Controls.Add(this.label12);
            this.gpbInfoCli.Controls.Add(this.npdLimiteCliente);
            this.gpbInfoCli.Controls.Add(this.label11);
            this.gpbInfoCli.Controls.Add(this.label10);
            this.gpbInfoCli.Controls.Add(this.txtCpfCliente);
            this.gpbInfoCli.Controls.Add(this.txtTelCel);
            this.gpbInfoCli.Controls.Add(this.txtTelFixo);
            this.gpbInfoCli.Controls.Add(this.label9);
            this.gpbInfoCli.Controls.Add(this.label8);
            this.gpbInfoCli.Controls.Add(this.txtNumeroCliente);
            this.gpbInfoCli.Controls.Add(this.txtBairroCliente);
            this.gpbInfoCli.Controls.Add(this.txtRuaCliente);
            this.gpbInfoCli.Controls.Add(this.label7);
            this.gpbInfoCli.Controls.Add(this.label6);
            this.gpbInfoCli.Controls.Add(this.label5);
            this.gpbInfoCli.Controls.Add(this.label3);
            this.gpbInfoCli.Controls.Add(this.label4);
            this.gpbInfoCli.Controls.Add(this.txtNomeCliente);
            this.gpbInfoCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbInfoCli.Location = new System.Drawing.Point(12, 34);
            this.gpbInfoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbInfoCli.Name = "gpbInfoCli";
            this.gpbInfoCli.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbInfoCli.Size = new System.Drawing.Size(576, 380);
            this.gpbInfoCli.TabIndex = 4;
            this.gpbInfoCli.TabStop = false;
            this.gpbInfoCli.Text = "Insira a informções do Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(22, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(403, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "*Ao atingir o limite, a conta do cliente sera bloqueada!";
            // 
            // npdLimiteCliente
            // 
            this.npdLimiteCliente.DecimalPlaces = 2;
            this.npdLimiteCliente.Location = new System.Drawing.Point(205, 289);
            this.npdLimiteCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.npdLimiteCliente.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.npdLimiteCliente.Name = "npdLimiteCliente";
            this.npdLimiteCliente.Size = new System.Drawing.Size(140, 27);
            this.npdLimiteCliente.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(22, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Definitir Limite de Compra:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(7, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 16;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(453, 57);
            this.txtCpfCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCpfCliente.Mask = "999.999.999.99";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(116, 27);
            this.txtCpfCliente.TabIndex = 2;
            // 
            // txtTelCel
            // 
            this.txtTelCel.Location = new System.Drawing.Point(453, 211);
            this.txtTelCel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelCel.Mask = "(99)99999-9999";
            this.txtTelCel.Name = "txtTelCel";
            this.txtTelCel.Size = new System.Drawing.Size(116, 27);
            this.txtTelCel.TabIndex = 7;
            // 
            // txtTelFixo
            // 
            this.txtTelFixo.Location = new System.Drawing.Point(124, 211);
            this.txtTelFixo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelFixo.Mask = "(99) 9999-9999";
            this.txtTelFixo.Name = "txtTelFixo";
            this.txtTelFixo.Size = new System.Drawing.Size(116, 27);
            this.txtTelFixo.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(332, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Telefone Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(22, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Telefone Fixo:";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(511, 134);
            this.txtNumeroCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroCliente.MaxLength = 5;
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(58, 27);
            this.txtNumeroCliente.TabIndex = 5;
            this.txtNumeroCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCliente_KeyPress);
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(357, 134);
            this.txtBairroCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairroCliente.MaxLength = 50;
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(116, 27);
            this.txtBairroCliente.TabIndex = 4;
            // 
            // txtRuaCliente
            // 
            this.txtRuaCliente.Location = new System.Drawing.Point(76, 134);
            this.txtRuaCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRuaCliente.MaxLength = 50;
            this.txtRuaCliente.Name = "txtRuaCliente";
            this.txtRuaCliente.Size = new System.Drawing.Size(213, 27);
            this.txtRuaCliente.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(479, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nº:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(301, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rua:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCliente.Location = new System.Drawing.Point(622, 291);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(116, 27);
            this.txtCodCliente.TabIndex = 20;
            this.txtCodCliente.Visible = false;
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnSalvarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCliente.Image")));
            this.btnSalvarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCliente.Location = new System.Drawing.Point(597, 44);
            this.btnSalvarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(164, 55);
            this.btnSalvarCliente.TabIndex = 9;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = false;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
            // 
            // btnLimparForm
            // 
            this.btnLimparForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLimparForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparForm.Image")));
            this.btnLimparForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparForm.Location = new System.Drawing.Point(597, 136);
            this.btnLimparForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimparForm.Name = "btnLimparForm";
            this.btnLimparForm.Size = new System.Drawing.Size(164, 55);
            this.btnLimparForm.TabIndex = 10;
            this.btnLimparForm.Text = "Limpar";
            this.btnLimparForm.UseVisualStyleBackColor = false;
            this.btnLimparForm.Click += new System.EventHandler(this.btnLimparForm_Click);
            // 
            // btnSairNovoCliente
            // 
            this.btnSairNovoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSairNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairNovoCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairNovoCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairNovoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSairNovoCliente.Image")));
            this.btnSairNovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairNovoCliente.Location = new System.Drawing.Point(597, 228);
            this.btnSairNovoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSairNovoCliente.Name = "btnSairNovoCliente";
            this.btnSairNovoCliente.Size = new System.Drawing.Size(164, 55);
            this.btnSairNovoCliente.TabIndex = 11;
            this.btnSairNovoCliente.Text = "Sair";
            this.btnSairNovoCliente.UseVisualStyleBackColor = false;
            this.btnSairNovoCliente.Click += new System.EventHandler(this.btnSairNovoCliente_Click);
            // 
            // Cad_Novo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 428);
            this.Controls.Add(this.btnSairNovoCliente);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.btnLimparForm);
            this.Controls.Add(this.btnSalvarCliente);
            this.Controls.Add(this.gpbInfoCli);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cad_Novo_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Novo_Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbInfoCli.ResumeLayout(false);
            this.gpbInfoCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdLimiteCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbInfoCli;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.TextBox txtRuaCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown npdLimiteCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCpfCliente;
        private System.Windows.Forms.MaskedTextBox txtTelCel;
        private System.Windows.Forms.MaskedTextBox txtTelFixo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Button btnLimparForm;
        private System.Windows.Forms.Button btnSairNovoCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
    }
}