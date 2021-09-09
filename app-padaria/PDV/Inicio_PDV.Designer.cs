namespace SistemaPadoca.Forms_Iniciais
{
    partial class Inicio_PDV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarPdv = new System.Windows.Forms.Button();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.npdValorInicial = new System.Windows.Forms.NumericUpDown();
            this.lblalerta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Inicial:";
            // 
            // btnIniciarPdv
            // 
            this.btnIniciarPdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnIniciarPdv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnIniciarPdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPdv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPdv.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciarPdv.Location = new System.Drawing.Point(444, 32);
            this.btnIniciarPdv.Name = "btnIniciarPdv";
            this.btnIniciarPdv.Size = new System.Drawing.Size(106, 35);
            this.btnIniciarPdv.TabIndex = 3;
            this.btnIniciarPdv.Text = "Iniciar";
            this.btnIniciarPdv.UseVisualStyleBackColor = false;
            this.btnIniciarPdv.Click += new System.EventHandler(this.btnIniciarPdv_Click);
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbTurno.Location = new System.Drawing.Point(66, 36);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(114, 24);
            this.cbTurno.TabIndex = 1;
            // 
            // npdValorInicial
            // 
            this.npdValorInicial.DecimalPlaces = 2;
            this.npdValorInicial.Location = new System.Drawing.Point(294, 38);
            this.npdValorInicial.Name = "npdValorInicial";
            this.npdValorInicial.Size = new System.Drawing.Size(114, 23);
            this.npdValorInicial.TabIndex = 2;
            this.npdValorInicial.UseWaitCursor = true;
            // 
            // lblalerta
            // 
            this.lblalerta.AutoSize = true;
            this.lblalerta.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.lblalerta.Location = new System.Drawing.Point(63, 66);
            this.lblalerta.Name = "lblalerta";
            this.lblalerta.Size = new System.Drawing.Size(0, 10);
            this.lblalerta.TabIndex = 7;
            // 
            // Inicio_PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(565, 102);
            this.Controls.Add(this.lblalerta);
            this.Controls.Add(this.npdValorInicial);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.btnIniciarPdv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Inicio_PDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio_PDV";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inicio_PDV_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.npdValorInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciarPdv;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.NumericUpDown npdValorInicial;
        private System.Windows.Forms.Label lblalerta;
    }
}