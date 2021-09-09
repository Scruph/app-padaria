namespace SistemaPadoca.Forms_Iniciais
{
    partial class CancelarItem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblaviso = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtApagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblaviso);
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Controls.Add(this.txtApagar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(29, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(540, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite o Código do item que deseja apagar";
            // 
            // lblaviso
            // 
            this.lblaviso.AutoSize = true;
            this.lblaviso.Location = new System.Drawing.Point(91, 85);
            this.lblaviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaviso.Name = "lblaviso";
            this.lblaviso.Size = new System.Drawing.Size(0, 17);
            this.lblaviso.TabIndex = 5;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApagar.Location = new System.Drawing.Point(367, 50);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(141, 43);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtApagar
            // 
            this.txtApagar.Location = new System.Drawing.Point(93, 60);
            this.txtApagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApagar.Name = "txtApagar";
            this.txtApagar.Size = new System.Drawing.Size(235, 25);
            this.txtApagar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // CancelarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(593, 169);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CancelarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelarItem";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelarItem_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblaviso;
    }
}