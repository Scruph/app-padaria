namespace SistemaPadoca.Forms_Iniciais
{
    partial class FinalizarVenda
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
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnFiado = new System.Windows.Forms.Button();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(356, 146);
            this.txtDinheiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(153, 22);
            this.txtDinheiro.TabIndex = 7;
            this.txtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinheiro_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(251, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dinheiro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(555, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValorFinal.Location = new System.Drawing.Point(649, 181);
            this.lblValorFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(68, 32);
            this.lblValorFinal.TabIndex = 6;
            this.lblValorFinal.Text = "0,00";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(255, 400);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 69);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cancelar Venda (ESC)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnSalvarDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarDados.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarDados.Location = new System.Drawing.Point(512, 400);
            this.btnSalvarDados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(207, 69);
            this.btnSalvarDados.TabIndex = 6;
            this.btnSalvarDados.Text = "Finalizar Venda (F5)";
            this.btnSalvarDados.UseVisualStyleBackColor = false;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(356, 219);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(153, 22);
            this.txtTroco.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(251, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Troco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(251, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Forma de Pagamento:";
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinheiro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinheiro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDinheiro.Location = new System.Drawing.Point(16, 71);
            this.btnDinheiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(173, 69);
            this.btnDinheiro.TabIndex = 1;
            this.btnDinheiro.Text = "Dinheiro (F6)";
            this.btnDinheiro.UseVisualStyleBackColor = false;
            this.btnDinheiro.Click += new System.EventHandler(this.btnDinheiro_Click);
            // 
            // btnDebito
            // 
            this.btnDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebito.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDebito.Location = new System.Drawing.Point(16, 181);
            this.btnDebito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(173, 69);
            this.btnDebito.TabIndex = 2;
            this.btnDebito.Text = "Débito (F7)";
            this.btnDebito.UseVisualStyleBackColor = false;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCredito.Location = new System.Drawing.Point(16, 290);
            this.btnCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(173, 69);
            this.btnCredito.TabIndex = 3;
            this.btnCredito.Text = "Credito (F8)";
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnFiado
            // 
            this.btnFiado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnFiado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFiado.Location = new System.Drawing.Point(16, 400);
            this.btnFiado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiado.Name = "btnFiado";
            this.btnFiado.Size = new System.Drawing.Size(173, 69);
            this.btnFiado.TabIndex = 4;
            this.btnFiado.Text = "Vincular Cliente(F9)";
            this.btnFiado.UseVisualStyleBackColor = false;
            this.btnFiado.Click += new System.EventHandler(this.btnFiado_Click);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFormaPagamento.Location = new System.Drawing.Point(473, 76);
            this.lblFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(126, 18);
            this.lblFormaPagamento.TabIndex = 30;
            this.lblFormaPagamento.Text = "DEFINIR FORMA";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(9, 30);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(230, 23);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Imprimir Cupom Não Fiscal";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox2.Location = new System.Drawing.Point(305, 30);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 23);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Não Imprimir";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 31);
            this.panel1.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(16, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Finalizar Venda";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(752, -1);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(29, 28);
            this.btnCloseForm.TabIndex = 7;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox1.Location = new System.Drawing.Point(255, 293);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(464, 66);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impressao de Comprovante";
            // 
            // FinalizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(783, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.btnFiado);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnDinheiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.btnSalvarDados);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDinheiro);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FinalizarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalizarVenda";
            this.Load += new System.EventHandler(this.FinalizarVenda_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FinalizarVenda_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FinalizarVenda_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDinheiro;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnFiado;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}