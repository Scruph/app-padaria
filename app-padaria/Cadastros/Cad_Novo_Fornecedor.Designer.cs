namespace SistemaPadoca
{
    partial class Cad_Novo_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Novo_Fornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.gpCadFornecedor = new System.Windows.Forms.GroupBox();
            this.txtTelEmpFornec = new System.Windows.Forms.MaskedTextBox();
            this.txtTelCelFornec = new System.Windows.Forms.MaskedTextBox();
            this.txtCodFornec = new System.Windows.Forms.TextBox();
            this.txtNomeVendeFornc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFornec = new System.Windows.Forms.TextBox();
            this.btnSalvarFornec = new System.Windows.Forms.Button();
            this.btnLimparForm = new System.Windows.Forms.Button();
            this.btnSairNovoFornec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpCadFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 31);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastrar Fornecedor";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(569, 4);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(26, 28);
            this.btnCloseForm.TabIndex = 7;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // gpCadFornecedor
            // 
            this.gpCadFornecedor.Controls.Add(this.txtTelEmpFornec);
            this.gpCadFornecedor.Controls.Add(this.txtTelCelFornec);
            this.gpCadFornecedor.Controls.Add(this.txtNomeVendeFornc);
            this.gpCadFornecedor.Controls.Add(this.label6);
            this.gpCadFornecedor.Controls.Add(this.label5);
            this.gpCadFornecedor.Controls.Add(this.label4);
            this.gpCadFornecedor.Controls.Add(this.label3);
            this.gpCadFornecedor.Controls.Add(this.txtNomeFornec);
            this.gpCadFornecedor.Font = new System.Drawing.Font("Arial", 10F);
            this.gpCadFornecedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpCadFornecedor.Location = new System.Drawing.Point(13, 37);
            this.gpCadFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpCadFornecedor.Name = "gpCadFornecedor";
            this.gpCadFornecedor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpCadFornecedor.Size = new System.Drawing.Size(398, 365);
            this.gpCadFornecedor.TabIndex = 2;
            this.gpCadFornecedor.TabStop = false;
            this.gpCadFornecedor.Text = "Informações:";
            // 
            // txtTelEmpFornec
            // 
            this.txtTelEmpFornec.Location = new System.Drawing.Point(166, 284);
            this.txtTelEmpFornec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelEmpFornec.Mask = "(99)9999-9999";
            this.txtTelEmpFornec.Name = "txtTelEmpFornec";
            this.txtTelEmpFornec.Size = new System.Drawing.Size(116, 23);
            this.txtTelEmpFornec.TabIndex = 4;
            // 
            // txtTelCelFornec
            // 
            this.txtTelCelFornec.Location = new System.Drawing.Point(153, 208);
            this.txtTelCelFornec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelCelFornec.Mask = "(99)99999-9999";
            this.txtTelCelFornec.Name = "txtTelCelFornec";
            this.txtTelCelFornec.Size = new System.Drawing.Size(116, 23);
            this.txtTelCelFornec.TabIndex = 3;
            // 
            // txtCodFornec
            // 
            this.txtCodFornec.Location = new System.Drawing.Point(463, 298);
            this.txtCodFornec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodFornec.Name = "txtCodFornec";
            this.txtCodFornec.ReadOnly = true;
            this.txtCodFornec.Size = new System.Drawing.Size(74, 23);
            this.txtCodFornec.TabIndex = 8;
            this.txtCodFornec.Visible = false;
            // 
            // txtNomeVendeFornc
            // 
            this.txtNomeVendeFornc.Location = new System.Drawing.Point(153, 132);
            this.txtNomeVendeFornc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeVendeFornc.Name = "txtNomeVendeFornc";
            this.txtNomeVendeFornc.Size = new System.Drawing.Size(221, 23);
            this.txtNomeVendeFornc.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefone Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefone Empresarial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome Vendedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome Fornecedor:";
            // 
            // txtNomeFornec
            // 
            this.txtNomeFornec.Location = new System.Drawing.Point(153, 56);
            this.txtNomeFornec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFornec.Name = "txtNomeFornec";
            this.txtNomeFornec.Size = new System.Drawing.Size(221, 23);
            this.txtNomeFornec.TabIndex = 1;
            // 
            // btnSalvarFornec
            // 
            this.btnSalvarFornec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnSalvarFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFornec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFornec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarFornec.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFornec.Image")));
            this.btnSalvarFornec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarFornec.Location = new System.Drawing.Point(419, 45);
            this.btnSalvarFornec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarFornec.Name = "btnSalvarFornec";
            this.btnSalvarFornec.Size = new System.Drawing.Size(164, 55);
            this.btnSalvarFornec.TabIndex = 5;
            this.btnSalvarFornec.Text = "Salvar";
            this.btnSalvarFornec.UseVisualStyleBackColor = false;
            this.btnSalvarFornec.Click += new System.EventHandler(this.btnSalvarFornec_Click);
            // 
            // btnLimparForm
            // 
            this.btnLimparForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLimparForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparForm.Image")));
            this.btnLimparForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparForm.Location = new System.Drawing.Point(419, 140);
            this.btnLimparForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimparForm.Name = "btnLimparForm";
            this.btnLimparForm.Size = new System.Drawing.Size(164, 55);
            this.btnLimparForm.TabIndex = 6;
            this.btnLimparForm.Text = "Limpar";
            this.btnLimparForm.UseVisualStyleBackColor = false;
            this.btnLimparForm.Click += new System.EventHandler(this.btnLimparForm_Click);
            // 
            // btnSairNovoFornec
            // 
            this.btnSairNovoFornec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSairNovoFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairNovoFornec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairNovoFornec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairNovoFornec.Image = ((System.Drawing.Image)(resources.GetObject("btnSairNovoFornec.Image")));
            this.btnSairNovoFornec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairNovoFornec.Location = new System.Drawing.Point(419, 235);
            this.btnSairNovoFornec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSairNovoFornec.Name = "btnSairNovoFornec";
            this.btnSairNovoFornec.Size = new System.Drawing.Size(164, 55);
            this.btnSairNovoFornec.TabIndex = 7;
            this.btnSairNovoFornec.Text = "Sair";
            this.btnSairNovoFornec.UseVisualStyleBackColor = false;
            this.btnSairNovoFornec.Click += new System.EventHandler(this.btnSairNovoFornec_Click);
            // 
            // Cad_Novo_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 419);
            this.Controls.Add(this.btnSairNovoFornec);
            this.Controls.Add(this.btnLimparForm);
            this.Controls.Add(this.txtCodFornec);
            this.Controls.Add(this.btnSalvarFornec);
            this.Controls.Add(this.gpCadFornecedor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cad_Novo_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Novo_Fornecedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpCadFornecedor.ResumeLayout(false);
            this.gpCadFornecedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.GroupBox gpCadFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFornec;
        private System.Windows.Forms.TextBox txtNomeVendeFornc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodFornec;
        private System.Windows.Forms.Button btnSalvarFornec;
        private System.Windows.Forms.Button btnLimparForm;
        private System.Windows.Forms.Button btnSairNovoFornec;
        private System.Windows.Forms.MaskedTextBox txtTelEmpFornec;
        private System.Windows.Forms.MaskedTextBox txtTelCelFornec;
    }
}