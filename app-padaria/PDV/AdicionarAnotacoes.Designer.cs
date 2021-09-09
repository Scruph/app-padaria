namespace SistemaPadoca.Forms_Iniciais
{
    partial class AdicionarAnotacoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.btnSalvarAnotacoes = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(121, 50);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(175, 26);
            this.txtDescricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Situação:";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(152, 116);
            this.dtData.Margin = new System.Windows.Forms.Padding(4);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(153, 26);
            this.dtData.TabIndex = 10;
            this.dtData.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Realizada:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSituacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(615, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar";
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Vazio",
            "Comprado"});
            this.cbSituacao.Location = new System.Drawing.Point(403, 50);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(121, 26);
            this.cbSituacao.TabIndex = 1;
            // 
            // btnSalvarAnotacoes
            // 
            this.btnSalvarAnotacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnSalvarAnotacoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnSalvarAnotacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAnotacoes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAnotacoes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarAnotacoes.Location = new System.Drawing.Point(481, 219);
            this.btnSalvarAnotacoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarAnotacoes.Name = "btnSalvarAnotacoes";
            this.btnSalvarAnotacoes.Size = new System.Drawing.Size(136, 38);
            this.btnSalvarAnotacoes.TabIndex = 3;
            this.btnSalvarAnotacoes.Text = "Salvar (F5)";
            this.btnSalvarAnotacoes.UseVisualStyleBackColor = false;
            this.btnSalvarAnotacoes.Click += new System.EventHandler(this.btnSalvarAnotacoes_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Location = new System.Drawing.Point(323, 219);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 38);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Cancelar (ESC)";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(88, 235);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(132, 22);
            this.txtCod.TabIndex = 12;
            this.txtCod.TabStop = false;
            this.txtCod.Visible = false;
            // 
            // AdicionarAnotacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 281);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvarAnotacoes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdicionarAnotacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarAnotacoes";
            this.Load += new System.EventHandler(this.AdicionarAnotacoes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdicionarAnotacoes_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvarAnotacoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.TextBox txtCod;
    }
}