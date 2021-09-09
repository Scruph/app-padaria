namespace SistemaPadoca
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFechamentoCaixa = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseAllForms = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.pbPdv = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFuncionarios = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pbProdutos = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnFechamentoCaixa);
            this.panel1.Controls.Add(this.btnRelatorios);
            this.panel1.Controls.Add(this.btnCadastros);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 713);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.ForeColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(16, 113);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 48);
            this.panel3.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(4, 658);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(353, 48);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFechamentoCaixa
            // 
            this.btnFechamentoCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnFechamentoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechamentoCaixa.Location = new System.Drawing.Point(33, 204);
            this.btnFechamentoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechamentoCaixa.Name = "btnFechamentoCaixa";
            this.btnFechamentoCaixa.Size = new System.Drawing.Size(295, 48);
            this.btnFechamentoCaixa.TabIndex = 4;
            this.btnFechamentoCaixa.Text = "Fechamento Caixa";
            this.btnFechamentoCaixa.UseVisualStyleBackColor = false;
            this.btnFechamentoCaixa.Click += new System.EventHandler(this.btnFechamentoCaixa_Click);
            this.btnFechamentoCaixa.MouseEnter += new System.EventHandler(this.btnFechamentoCaixa_MouseEnter);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorios.Location = new System.Drawing.Point(33, 297);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(295, 48);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            this.btnRelatorios.MouseEnter += new System.EventHandler(this.btnRelatorios_MouseEnter);
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastros.Location = new System.Drawing.Point(33, 113);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(295, 48);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            this.btnCadastros.MouseEnter += new System.EventHandler(this.btnCadastros_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCloseAllForms);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnCloseAllForms
            // 
            this.btnCloseAllForms.FlatAppearance.BorderSize = 0;
            this.btnCloseAllForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAllForms.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAllForms.Location = new System.Drawing.Point(1013, -1);
            this.btnCloseAllForms.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseAllForms.Name = "btnCloseAllForms";
            this.btnCloseAllForms.Size = new System.Drawing.Size(33, 31);
            this.btnCloseAllForms.TabIndex = 2;
            this.btnCloseAllForms.TabStop = false;
            this.btnCloseAllForms.Text = "X";
            this.btnCloseAllForms.UseVisualStyleBackColor = true;
            this.btnCloseAllForms.Click += new System.EventHandler(this.btnCloseAllForms_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(147, 5);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 17);
            this.lblHora.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 5);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 17);
            this.lblData.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(272, 5);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            this.lblUser.TabIndex = 2;
            // 
            // tHora
            // 
            this.tHora.Enabled = true;
            this.tHora.Interval = 1000;
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // pbPdv
            // 
            this.pbPdv.Image = ((System.Drawing.Image)(resources.GetObject("pbPdv.Image")));
            this.pbPdv.Location = new System.Drawing.Point(464, 139);
            this.pbPdv.Margin = new System.Windows.Forms.Padding(4);
            this.pbPdv.Name = "pbPdv";
            this.pbPdv.Size = new System.Drawing.Size(160, 149);
            this.pbPdv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPdv.TabIndex = 7;
            this.pbPdv.TabStop = false;
            this.pbPdv.Click += new System.EventHandler(this.pbPdv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(520, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "PDV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(460, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ponto de Venda do Sistema";
            // 
            // pbFuncionarios
            // 
            this.pbFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("pbFuncionarios.Image")));
            this.pbFuncionarios.Location = new System.Drawing.Point(771, 139);
            this.pbFuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.pbFuncionarios.Name = "pbFuncionarios";
            this.pbFuncionarios.Size = new System.Drawing.Size(160, 149);
            this.pbFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFuncionarios.TabIndex = 10;
            this.pbFuncionarios.TabStop = false;
            this.pbFuncionarios.Click += new System.EventHandler(this.pbFuncionarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(755, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gerencimento de Funcionarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(805, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Funcionarios";
            // 
            // pbClientes
            // 
            this.pbClientes.Image = ((System.Drawing.Image)(resources.GetObject("pbClientes.Image")));
            this.pbClientes.Location = new System.Drawing.Point(464, 465);
            this.pbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(160, 149);
            this.pbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClientes.TabIndex = 13;
            this.pbClientes.TabStop = false;
            this.pbClientes.Click += new System.EventHandler(this.pbClientes_Click);
            // 
            // pbProdutos
            // 
            this.pbProdutos.Image = ((System.Drawing.Image)(resources.GetObject("pbProdutos.Image")));
            this.pbProdutos.Location = new System.Drawing.Point(771, 465);
            this.pbProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.pbProdutos.Name = "pbProdutos";
            this.pbProdutos.Size = new System.Drawing.Size(160, 149);
            this.pbProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProdutos.TabIndex = 14;
            this.pbProdutos.TabStop = false;
            this.pbProdutos.Click += new System.EventHandler(this.pbProdutos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(515, 633);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Clientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(816, 630);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Produtos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(467, 652);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gerenciamento de Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(767, 652);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Gerenciamento de Produtos";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 738);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbProdutos);
            this.Controls.Add(this.pbClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbFuncionarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPdv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inicio_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechamentoCaixa;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCloseAllForms;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Timer tHora;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbPdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFuncionarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.PictureBox pbProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

