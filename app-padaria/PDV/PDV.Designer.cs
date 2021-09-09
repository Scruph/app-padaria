namespace SistemaPadoca.Forms_Iniciais
{
    partial class PDV
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSair2 = new System.Windows.Forms.Button();
            this.txtInsersaoProdutos = new System.Windows.Forms.TextBox();
            this.rtbListaProdutos = new System.Windows.Forms.RichTextBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnumeroitems = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.valorDaCompra = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAnotacoes = new System.Windows.Forms.Button();
            this.btnRetirarCaixa = new System.Windows.Forms.Button();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.btnConsultaPreco = new System.Windows.Forms.Button();
            this.txtForaEstoque = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnSair2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1324, 34);
            this.panel2.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(11, 6);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 19);
            this.label15.TabIndex = 12;
            this.label15.Text = "Ponto de Venda - Sistema";
            // 
            // btnSair2
            // 
            this.btnSair2.FlatAppearance.BorderSize = 0;
            this.btnSair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair2.ForeColor = System.Drawing.Color.White;
            this.btnSair2.Location = new System.Drawing.Point(1280, 0);
            this.btnSair2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair2.Name = "btnSair2";
            this.btnSair2.Size = new System.Drawing.Size(29, 28);
            this.btnSair2.TabIndex = 11;
            this.btnSair2.TabStop = false;
            this.btnSair2.Text = "X";
            this.btnSair2.UseVisualStyleBackColor = true;
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // txtInsersaoProdutos
            // 
            this.txtInsersaoProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInsersaoProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsersaoProdutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInsersaoProdutos.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsersaoProdutos.Location = new System.Drawing.Point(8, 18);
            this.txtInsersaoProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsersaoProdutos.Name = "txtInsersaoProdutos";
            this.txtInsersaoProdutos.Size = new System.Drawing.Size(819, 34);
            this.txtInsersaoProdutos.TabIndex = 1;
            this.txtInsersaoProdutos.TextChanged += new System.EventHandler(this.txtInsersaoProdutos_TextChanged);
            this.txtInsersaoProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsersaoProdutos_KeyPress);
            // 
            // rtbListaProdutos
            // 
            this.rtbListaProdutos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtbListaProdutos.BackColor = System.Drawing.SystemColors.Window;
            this.rtbListaProdutos.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListaProdutos.Location = new System.Drawing.Point(17, 108);
            this.rtbListaProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.rtbListaProdutos.Name = "rtbListaProdutos";
            this.rtbListaProdutos.ReadOnly = true;
            this.rtbListaProdutos.Size = new System.Drawing.Size(1001, 479);
            this.rtbListaProdutos.TabIndex = 5;
            this.rtbListaProdutos.TabStop = false;
            this.rtbListaProdutos.Text = "";
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(1031, 617);
            this.btnFinalizarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(260, 69);
            this.btnFinalizarVenda.TabIndex = 11;
            this.btnFinalizarVenda.TabStop = false;
            this.btnFinalizarVenda.Text = "Finalizar Venda ";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(17, 508);
            this.rtbDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(979, 79);
            this.rtbDescricao.TabIndex = 12;
            this.rtbDescricao.TabStop = false;
            this.rtbDescricao.Text = "";
            this.rtbDescricao.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblnumeroitems);
            this.groupBox1.Controls.Add(this.lblquantidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 596);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 85);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // lblnumeroitems
            // 
            this.lblnumeroitems.AutoSize = true;
            this.lblnumeroitems.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroitems.Location = new System.Drawing.Point(152, 31);
            this.lblnumeroitems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumeroitems.Name = "lblnumeroitems";
            this.lblnumeroitems.Size = new System.Drawing.Size(0, 29);
            this.lblnumeroitems.TabIndex = 3;
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantidade.Location = new System.Drawing.Point(391, 31);
            this.lblquantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(0, 29);
            this.lblquantidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº de Itens:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(8, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 40);
            this.label13.TabIndex = 14;
            this.label13.Text = "Valor Total:";
            // 
            // valorDaCompra
            // 
            this.valorDaCompra.AutoSize = true;
            this.valorDaCompra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorDaCompra.ForeColor = System.Drawing.Color.Green;
            this.valorDaCompra.Location = new System.Drawing.Point(259, 31);
            this.valorDaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valorDaCompra.Name = "valorDaCompra";
            this.valorDaCompra.Size = new System.Drawing.Size(83, 40);
            this.valorDaCompra.TabIndex = 15;
            this.valorDaCompra.Text = "0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.valorDaCompra);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(511, 596);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(453, 85);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Total:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1031, 742);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 69);
            this.button1.TabIndex = 17;
            this.button1.TabStop = false;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(28, 299);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 69);
            this.button2.TabIndex = 18;
            this.button2.TabStop = false;
            this.button2.Text = "Sugerir Quantidade";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(28, 176);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 69);
            this.button3.TabIndex = 19;
            this.button3.TabStop = false;
            this.button3.Text = "Cancelar Item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarVenda.Location = new System.Drawing.Point(28, 64);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(207, 69);
            this.btnCancelarVenda.TabIndex = 20;
            this.btnCancelarVenda.TabStop = false;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = false;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelarVenda);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1031, 186);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 402);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funções";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Operador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Data:";
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Location = new System.Drawing.Point(67, 66);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(0, 19);
            this.lblHoraAtual.TabIndex = 25;
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(67, 106);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(0, 19);
            this.lblDataAtual.TabIndex = 26;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(101, 27);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 19);
            this.lblUsername.TabIndex = 27;
            // 
            // tHora
            // 
            this.tHora.Enabled = true;
            this.tHora.Interval = 1000;
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // dgConsulta
            // 
            this.dgConsulta.AllowUserToAddRows = false;
            this.dgConsulta.AllowUserToDeleteRows = false;
            this.dgConsulta.AllowUserToResizeColumns = false;
            this.dgConsulta.AllowUserToResizeRows = false;
            this.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgConsulta.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgConsulta.Location = new System.Drawing.Point(17, 112);
            this.dgConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.ReadOnly = true;
            this.dgConsulta.RowHeadersVisible = false;
            this.dgConsulta.RowHeadersWidth = 51;
            this.dgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConsulta.Size = new System.Drawing.Size(1001, 476);
            this.dgConsulta.TabIndex = 28;
            this.dgConsulta.TabStop = false;
            this.dgConsulta.Visible = false;
            this.dgConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsulta_CellContentClick);
            this.dgConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsulta_CellDoubleClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_Produto";
            this.Column1.HeaderText = "Cód";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nome_Produto";
            this.Column2.HeaderText = "Nome";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Unidade";
            this.Column3.HeaderText = "Tipo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Cod_Barras";
            this.Column4.HeaderText = "Barcode";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Preco";
            this.Column5.HeaderText = "Preço";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAnotacoes);
            this.groupBox4.Controls.Add(this.btnRetirarCaixa);
            this.groupBox4.Controls.Add(this.btnConsultaCliente);
            this.groupBox4.Controls.Add(this.btnConsultaPreco);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 719);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(947, 118);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultas/Funções";
            // 
            // btnAnotacoes
            // 
            this.btnAnotacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAnotacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnotacoes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotacoes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnotacoes.Location = new System.Drawing.Point(699, 23);
            this.btnAnotacoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnotacoes.Name = "btnAnotacoes";
            this.btnAnotacoes.Size = new System.Drawing.Size(207, 69);
            this.btnAnotacoes.TabIndex = 24;
            this.btnAnotacoes.TabStop = false;
            this.btnAnotacoes.Text = "Anotações";
            this.btnAnotacoes.UseVisualStyleBackColor = false;
            this.btnAnotacoes.Click += new System.EventHandler(this.btnAnotacoes_Click);
            // 
            // btnRetirarCaixa
            // 
            this.btnRetirarCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnRetirarCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirarCaixa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirarCaixa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRetirarCaixa.Location = new System.Drawing.Point(465, 23);
            this.btnRetirarCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetirarCaixa.Name = "btnRetirarCaixa";
            this.btnRetirarCaixa.Size = new System.Drawing.Size(207, 69);
            this.btnRetirarCaixa.TabIndex = 23;
            this.btnRetirarCaixa.TabStop = false;
            this.btnRetirarCaixa.Text = "Retirada do Caixa";
            this.btnRetirarCaixa.UseVisualStyleBackColor = false;
            this.btnRetirarCaixa.Click += new System.EventHandler(this.btnRetirarCaixa_Click);
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnConsultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultaCliente.Location = new System.Drawing.Point(236, 23);
            this.btnConsultaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(207, 69);
            this.btnConsultaCliente.TabIndex = 22;
            this.btnConsultaCliente.TabStop = false;
            this.btnConsultaCliente.Text = "Consultar Cliente";
            this.btnConsultaCliente.UseVisualStyleBackColor = false;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // btnConsultaPreco
            // 
            this.btnConsultaPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnConsultaPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPreco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPreco.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultaPreco.Location = new System.Drawing.Point(13, 23);
            this.btnConsultaPreco.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaPreco.Name = "btnConsultaPreco";
            this.btnConsultaPreco.Size = new System.Drawing.Size(207, 69);
            this.btnConsultaPreco.TabIndex = 21;
            this.btnConsultaPreco.TabStop = false;
            this.btnConsultaPreco.Text = "Consultar Preco";
            this.btnConsultaPreco.UseVisualStyleBackColor = false;
            this.btnConsultaPreco.Click += new System.EventHandler(this.btnConsultaPreco_Click);
            // 
            // txtForaEstoque
            // 
            this.txtForaEstoque.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForaEstoque.Location = new System.Drawing.Point(653, 18);
            this.txtForaEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForaEstoque.Name = "txtForaEstoque";
            this.txtForaEstoque.Size = new System.Drawing.Size(173, 33);
            this.txtForaEstoque.TabIndex = 2;
            this.txtForaEstoque.Visible = false;
            this.txtForaEstoque.TextChanged += new System.EventHandler(this.txtForaEstoque_TextChanged);
            this.txtForaEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForaEstoque_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(849, 18);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(145, 33);
            this.txtQuantidade.TabIndex = 29;
            this.txtQuantidade.TabStop = false;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtForaEstoque);
            this.groupBox5.Controls.Add(this.txtInsersaoProdutos);
            this.groupBox5.Controls.Add(this.txtQuantidade);
            this.groupBox5.Location = new System.Drawing.Point(16, 42);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1003, 63);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Insira o codigo de um produto ou pesquise pelo nome";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.lblHoraAtual);
            this.groupBox6.Controls.Add(this.lblUsername);
            this.groupBox6.Controls.Add(this.lblDataAtual);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1031, 42);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(267, 137);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            // 
            // PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1316, 854);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgConsulta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.rtbListaProdutos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV";
            this.Load += new System.EventHandler(this.PDV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PDV_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.TextBox txtInsersaoProdutos;
        private System.Windows.Forms.RichTextBox rtbListaProdutos;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label valorDaCompra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Timer tHora;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAnotacoes;
        private System.Windows.Forms.Button btnRetirarCaixa;
        private System.Windows.Forms.Button btnConsultaCliente;
        private System.Windows.Forms.Button btnConsultaPreco;
        private System.Windows.Forms.TextBox txtForaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblnumeroitems;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}