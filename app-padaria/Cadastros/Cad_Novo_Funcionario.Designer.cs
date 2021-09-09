namespace SistemaPadoca
{
    partial class Cad_Novo_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Novo_Funcionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.cbNivelUsuario = new System.Windows.Forms.ComboBox();
            this.mtxtTelCel = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelFixo = new System.Windows.Forms.MaskedTextBox();
            this.txtNrm = new System.Windows.Forms.TextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.gpbCadLogin = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnSalvarFunc = new System.Windows.Forms.Button();
            this.btnLimparForm = new System.Windows.Forms.Button();
            this.btnSairNovoFunc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.gpbCadLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 31);
            this.panel1.TabIndex = 2;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(720, 2);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(26, 28);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar\r\n";
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.label2);
            this.gpbInfo.Controls.Add(this.cbNivelUsuario);
            this.gpbInfo.Controls.Add(this.mtxtTelCel);
            this.gpbInfo.Controls.Add(this.mtxtTelFixo);
            this.gpbInfo.Controls.Add(this.txtNrm);
            this.gpbInfo.Controls.Add(this.mtxtCPF);
            this.gpbInfo.Controls.Add(this.txtBairro);
            this.gpbInfo.Controls.Add(this.txtRua);
            this.gpbInfo.Controls.Add(this.label11);
            this.gpbInfo.Controls.Add(this.label10);
            this.gpbInfo.Controls.Add(this.label9);
            this.gpbInfo.Controls.Add(this.label8);
            this.gpbInfo.Controls.Add(this.label7);
            this.gpbInfo.Controls.Add(this.txtNome);
            this.gpbInfo.Controls.Add(this.label6);
            this.gpbInfo.Controls.Add(this.label5);
            this.gpbInfo.Font = new System.Drawing.Font("Arial", 10F);
            this.gpbInfo.Location = new System.Drawing.Point(12, 134);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbInfo.Size = new System.Drawing.Size(524, 363);
            this.gpbInfo.TabIndex = 5;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Informações:";
            // 
            // cbNivelUsuario
            // 
            this.cbNivelUsuario.FormattingEnabled = true;
            this.cbNivelUsuario.Items.AddRange(new object[] {
            "Nivel de Acesso",
            "Administrador",
            "Funcionairo"});
            this.cbNivelUsuario.Location = new System.Drawing.Point(152, 318);
            this.cbNivelUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbNivelUsuario.Name = "cbNivelUsuario";
            this.cbNivelUsuario.Size = new System.Drawing.Size(144, 27);
            this.cbNivelUsuario.TabIndex = 13;
            // 
            // mtxtTelCel
            // 
            this.mtxtTelCel.Location = new System.Drawing.Point(363, 253);
            this.mtxtTelCel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtTelCel.Mask = "(99) 99999-9999";
            this.mtxtTelCel.Name = "mtxtTelCel";
            this.mtxtTelCel.Size = new System.Drawing.Size(121, 27);
            this.mtxtTelCel.TabIndex = 12;
            // 
            // mtxtTelFixo
            // 
            this.mtxtTelFixo.Location = new System.Drawing.Point(119, 253);
            this.mtxtTelFixo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtTelFixo.Mask = "(99) 9999-9999";
            this.mtxtTelFixo.Name = "mtxtTelFixo";
            this.mtxtTelFixo.Size = new System.Drawing.Size(115, 27);
            this.mtxtTelFixo.TabIndex = 11;
            // 
            // txtNrm
            // 
            this.txtNrm.Location = new System.Drawing.Point(286, 187);
            this.txtNrm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNrm.MaxLength = 5;
            this.txtNrm.Name = "txtNrm";
            this.txtNrm.Size = new System.Drawing.Size(89, 27);
            this.txtNrm.TabIndex = 10;
            this.txtNrm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrm_KeyPress);
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(70, 121);
            this.mtxtCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtCPF.Mask = "999.999.999-99";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(115, 27);
            this.mtxtCPF.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(70, 187);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(140, 27);
            this.txtBairro.TabIndex = 9;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(286, 121);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(220, 27);
            this.txtRua.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Telefone Celular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Telefone Fixo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nº:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rua:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 55);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(436, 27);
            this.txtNome.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(595, 292);
            this.txtCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(84, 27);
            this.txtCod.TabIndex = 15;
            this.txtCod.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(366, 22);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(140, 27);
            this.txtSenha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(70, 39);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // gpbCadLogin
            // 
            this.gpbCadLogin.Controls.Add(this.label13);
            this.gpbCadLogin.Controls.Add(this.txtConfirmPass);
            this.gpbCadLogin.Controls.Add(this.label3);
            this.gpbCadLogin.Controls.Add(this.label4);
            this.gpbCadLogin.Controls.Add(this.txtUsername);
            this.gpbCadLogin.Controls.Add(this.txtSenha);
            this.gpbCadLogin.Font = new System.Drawing.Font("Arial", 10F);
            this.gpbCadLogin.Location = new System.Drawing.Point(12, 33);
            this.gpbCadLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCadLogin.Name = "gpbCadLogin";
            this.gpbCadLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCadLogin.Size = new System.Drawing.Size(524, 93);
            this.gpbCadLogin.TabIndex = 1;
            this.gpbCadLogin.TabStop = false;
            this.gpbCadLogin.Text = "Cadastro de Login:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Confirmar Senha:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(366, 56);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPass.MaxLength = 30;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(140, 27);
            this.txtConfirmPass.TabIndex = 4;
            // 
            // btnSalvarFunc
            // 
            this.btnSalvarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnSalvarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFunc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFunc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFunc.Image")));
            this.btnSalvarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarFunc.Location = new System.Drawing.Point(558, 40);
            this.btnSalvarFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarFunc.Name = "btnSalvarFunc";
            this.btnSalvarFunc.Size = new System.Drawing.Size(164, 55);
            this.btnSalvarFunc.TabIndex = 14;
            this.btnSalvarFunc.Text = "Salvar";
            this.btnSalvarFunc.UseVisualStyleBackColor = false;
            this.btnSalvarFunc.Click += new System.EventHandler(this.btnSalvarFunc_Click);
            // 
            // btnLimparForm
            // 
            this.btnLimparForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLimparForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparForm.Image")));
            this.btnLimparForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparForm.Location = new System.Drawing.Point(558, 134);
            this.btnLimparForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimparForm.Name = "btnLimparForm";
            this.btnLimparForm.Size = new System.Drawing.Size(164, 55);
            this.btnLimparForm.TabIndex = 15;
            this.btnLimparForm.Text = "Limpar";
            this.btnLimparForm.UseVisualStyleBackColor = false;
            this.btnLimparForm.Click += new System.EventHandler(this.btnLimparForm_Click);
            // 
            // btnSairNovoFunc
            // 
            this.btnSairNovoFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSairNovoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairNovoFunc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairNovoFunc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairNovoFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnSairNovoFunc.Image")));
            this.btnSairNovoFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairNovoFunc.Location = new System.Drawing.Point(558, 229);
            this.btnSairNovoFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSairNovoFunc.Name = "btnSairNovoFunc";
            this.btnSairNovoFunc.Size = new System.Drawing.Size(164, 55);
            this.btnSairNovoFunc.TabIndex = 16;
            this.btnSairNovoFunc.Text = "Cancelar";
            this.btnSairNovoFunc.UseVisualStyleBackColor = false;
            this.btnSairNovoFunc.Click += new System.EventHandler(this.btnSairNovoFunc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nível de Acesso:";
            // 
            // Cad_Novo_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 510);
            this.Controls.Add(this.btnSairNovoFunc);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnLimparForm);
            this.Controls.Add(this.btnSalvarFunc);
            this.Controls.Add(this.gpbCadLogin);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cad_Novo_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Novo_Funcionario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbCadLogin.ResumeLayout(false);
            this.gpbCadLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbCadLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtTelCel;
        private System.Windows.Forms.MaskedTextBox mtxtTelFixo;
        private System.Windows.Forms.TextBox txtNrm;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Button btnSalvarFunc;
        private System.Windows.Forms.Button btnLimparForm;
        private System.Windows.Forms.Button btnSairNovoFunc;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.ComboBox cbNivelUsuario;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
    }
}