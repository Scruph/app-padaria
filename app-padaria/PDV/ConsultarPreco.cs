using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPadoca.Forms_Iniciais
{
    public partial class ConsultarPreco : Form
    {
        public ConsultarPreco()
        {
            InitializeComponent();
        }
        int codigo = 0;

        private void ConsultarPreco_TextChanged(object sender, EventArgs e)
        {
            dgvConsulta.Visible = true;

            lblNome.Text = "";
            lblPreco.Text = "";
            lblEstoque.Text = "";
            lblUnidade.Text = "";
            lblTipo.Text = "";
            lblCodBarras.Text = "";
            lblData.Text = "";
        }

        private void ConsultarPreco_Load(object sender, EventArgs e)
        {
            tabelaRefresh();
            dgvConsulta.ClearSelection();

        }
        private void tabelaRefresh()
        {
            Produtos produto = new Produtos();
            dgvConsulta.DataSource = produto.ConsultarProdutos();
        }

        private void tabelaRefresh(string Nome)
        {
            Produtos produto = new Produtos();
            dgvConsulta.DataSource = produto.ConsultarProdutos(Nome);
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt16(dgvConsulta.SelectedRows[0].Cells[0].Value);
            Produtos produto = new Produtos();
            DataTable DADOS = produto.ConsultarProdutos(codigo);
            int fornecedores = Convert.ToInt32(DADOS.Rows[0]["Id_Fornecedores"].ToString());
            string nome = DADOS.Rows[0]["Nome_Produto"].ToString();
            decimal preco = Convert.ToDecimal(DADOS.Rows[0]["Preco"].ToString());
            string estoque = DADOS.Rows[0]["Qtde_Disponivel"].ToString();
            string tipo = DADOS.Rows[0]["Tipo_Produto"].ToString();
            string barcode = DADOS.Rows[0]["Cod_Barras"].ToString();
            string unidade = DADOS.Rows[0]["Unidade"].ToString();
            string data = DADOS.Rows[0]["Data_Validade"].ToString();

            lblNome.Text = nome;
            lblPreco.Text = Convert.ToString(preco);
            lblEstoque.Text = estoque;
            lblUnidade.Text = unidade;
            lblTipo.Text = tipo;
            lblCodBarras.Text = barcode;
            lblData.Text = Convert.ToString(data);

            dgvConsulta.Visible = false;

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultarPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvConsulta.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtConsulta.Text;
            tabelaRefresh(pesquisa);
        }
    }
}
