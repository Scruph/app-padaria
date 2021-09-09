namespace SistemaPadoca
{
    partial class Cad_Inicio
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
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadProduto.Location = new System.Drawing.Point(19, 34);
            this.btnCadProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(207, 74);
            this.btnCadProduto.TabIndex = 1;
            this.btnCadProduto.Text = "Cadastrar Produto";
            this.btnCadProduto.UseVisualStyleBackColor = false;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadCliente.Location = new System.Drawing.Point(246, 34);
            this.btnCadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(207, 74);
            this.btnCadCliente.TabIndex = 2;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = false;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadFuncionario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadFuncionario.Location = new System.Drawing.Point(246, 146);
            this.btnCadFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(207, 74);
            this.btnCadFuncionario.TabIndex = 4;
            this.btnCadFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadFuncionario.UseVisualStyleBackColor = false;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCadFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadFornecedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFornecedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadFornecedor.Location = new System.Drawing.Point(19, 146);
            this.btnCadFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(207, 74);
            this.btnCadFornecedor.TabIndex = 3;
            this.btnCadFornecedor.Text = "Cadastrar Fornecedor";
            this.btnCadFornecedor.UseVisualStyleBackColor = false;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadFuncionario);
            this.groupBox1.Controls.Add(this.btnCadProduto);
            this.groupBox1.Controls.Add(this.btnCadFornecedor);
            this.groupBox1.Controls.Add(this.btnCadCliente);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Cad_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(482, 250);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cad_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Inicio";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cad_Inicio_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Button btnCadFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}