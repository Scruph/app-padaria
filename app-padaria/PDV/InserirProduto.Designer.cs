namespace SistemaPadoca.Forms_Iniciais
{
    partial class InserirProduto
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(98, 47);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(254, 23);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TabStop = false;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(98, 127);
            this.txtIdProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.ReadOnly = true;
            this.txtIdProd.Size = new System.Drawing.Size(119, 23);
            this.txtIdProd.TabIndex = 1;
            this.txtIdProd.TabStop = false;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(338, 127);
            this.txtCodBarras.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.ReadOnly = true;
            this.txtCodBarras.Size = new System.Drawing.Size(119, 23);
            this.txtCodBarras.TabIndex = 2;
            this.txtCodBarras.TabStop = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(473, 47);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(119, 23);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.TabStop = false;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(560, 127);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(119, 23);
            this.txtQtde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descriçao:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cód de Barras:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cód Prod:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.Location = new System.Drawing.Point(575, 182);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(104, 33);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar (F2)";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // InserirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 249);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.txtDescricao);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InserirProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InserirProduto";
            this.Load += new System.EventHandler(this.InserirProduto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InserirProduto_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
    }
}