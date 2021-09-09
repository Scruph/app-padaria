namespace SistemaPadoca.Forms_Iniciais
{
    partial class ConsultarCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRece = new System.Windows.Forms.Label();
            this.txtRecebimento = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblUltimaData = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblValorAtual = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaixa = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(30, 118);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(675, 368);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRece);
            this.groupBox1.Controls.Add(this.txtRecebimento);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblLimite);
            this.groupBox1.Controls.Add(this.lblUltimaData);
            this.groupBox1.Controls.Add(this.lblValorPago);
            this.groupBox1.Controls.Add(this.lbldata);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblValorAtual);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(727, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(278, 361);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // lblRece
            // 
            this.lblRece.AutoSize = true;
            this.lblRece.Location = new System.Drawing.Point(8, 267);
            this.lblRece.Name = "lblRece";
            this.lblRece.Size = new System.Drawing.Size(109, 19);
            this.lblRece.TabIndex = 16;
            this.lblRece.Text = "Recebimento:";
            this.lblRece.Visible = false;
            // 
            // txtRecebimento
            // 
            this.txtRecebimento.Location = new System.Drawing.Point(123, 264);
            this.txtRecebimento.Name = "txtRecebimento";
            this.txtRecebimento.Size = new System.Drawing.Size(79, 26);
            this.txtRecebimento.TabIndex = 15;
            this.txtRecebimento.Visible = false;
            this.txtRecebimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecebimento_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(77, 42);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 19);
            this.lblNome.TabIndex = 14;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(165, 76);
            this.lblLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(0, 19);
            this.lblLimite.TabIndex = 13;
            // 
            // lblUltimaData
            // 
            this.lblUltimaData.AutoSize = true;
            this.lblUltimaData.Location = new System.Drawing.Point(165, 114);
            this.lblUltimaData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltimaData.Name = "lblUltimaData";
            this.lblUltimaData.Size = new System.Drawing.Size(0, 19);
            this.lblUltimaData.TabIndex = 12;
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(171, 150);
            this.lblValorPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(0, 19);
            this.lblValorPago.TabIndex = 11;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(97, 192);
            this.lbldata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 19);
            this.lbldata.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Dia Atual:";
            // 
            // lblValorAtual
            // 
            this.lblValorAtual.AutoSize = true;
            this.lblValorAtual.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAtual.ForeColor = System.Drawing.Color.Green;
            this.lblValorAtual.Location = new System.Drawing.Point(129, 313);
            this.lblValorAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorAtual.Name = "lblValorAtual";
            this.lblValorAtual.Size = new System.Drawing.Size(48, 22);
            this.lblValorAtual.TabIndex = 7;
            this.lblValorAtual.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ultimo Mes Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ultimo Valor Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limite de Compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnBaixa
            // 
            this.btnBaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnBaixa.Enabled = false;
            this.btnBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBaixa.Location = new System.Drawing.Point(825, 494);
            this.btnBaixa.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixa.Name = "btnBaixa";
            this.btnBaixa.Size = new System.Drawing.Size(145, 54);
            this.btnBaixa.TabIndex = 25;
            this.btnBaixa.Text = "Dar Baixa (F5)";
            this.btnBaixa.UseVisualStyleBackColor = false;
            this.btnBaixa.Click += new System.EventHandler(this.btnBaixa_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(672, 494);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 54);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(519, 494);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 54);
            this.button2.TabIndex = 27;
            this.button2.Text = "Imprimir Nota";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Digite o nome do cliente:";
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Location = new System.Drawing.Point(32, 50);
            this.txtConsultaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(673, 22);
            this.txtConsultaCliente.TabIndex = 0;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 562);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnBaixa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConsultaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsultarCliente_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValorAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblUltimaData;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBaixa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.Label lblRece;
        private System.Windows.Forms.TextBox txtRecebimento;
    }
}