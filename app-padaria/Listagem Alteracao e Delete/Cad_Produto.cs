using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPadoca
{
    public partial class Cad_Produto : Form
    {

        public Cad_Produto()
        {
            InitializeComponent();
        }
        int codigo = 0;

        private void tabelaRefresh()
        {
            Produtos produto = new Produtos();
            dgvProduto.DataSource = produto.ConsultarProdutos();
        }

        private void tabelaRefresh(string strValor)
        {
            Produtos produto = new Produtos();
            dgvProduto.DataSource = produto.ConsultarProdutos(strValor);
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            Cad_Novo_Produto cadnovo = new Cad_Novo_Produto();       
            cadnovo.ShowDialog();
            tabelaRefresh();
        }

        private void btnSairProduto_Click(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Deseja Realmente Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Deseja realmente Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Cad_Produto_Load(object sender, EventArgs e)
        {
            btnDelProduto.Enabled = false;
            tabelaRefresh();
            dgvProduto.ClearSelection();
        }

        private void txtConsultaProd_TextChanged(object sender, EventArgs e)
        {
            string pesquisar = txtConsultaProd.Text;
            tabelaRefresh(pesquisar);
        }

      

        private void btnDelProduto_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt16(dgvProduto.SelectedRows[0].Cells[0].Value);
            DialogResult Excluir = MessageBox.Show("Excluir item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Excluir == DialogResult.Yes)
            {
                Produtos produto = new Produtos(codigo);
                produto.DelProduto(codigo);
                btnDelProduto.Enabled = false;
                MessageBox.Show("Item Removido!", "Confirmação", MessageBoxButtons.OK);
                
            }
            tabelaRefresh();
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt16(dgvProduto.SelectedRows[0].Cells[0].Value);
            Produtos produto = new Produtos();
            DataTable DADOS = produto.ConsultarProdutos(codigo);
            int fornecedores = Convert.ToInt32(DADOS.Rows[0]["Id_Fornecedores"].ToString());
            string nome = DADOS.Rows[0]["Nome_Produto"].ToString();         
            decimal preco = Convert.ToDecimal(DADOS.Rows[0]["Preco"].ToString());
            string estoque = DADOS.Rows[0]["Qtde_Disponivel"].ToString();
            string tipo = DADOS.Rows[0]["Tipo_Produto"].ToString();
            string barcode = DADOS.Rows[0]["Cod_Barras"].ToString();
            string unidade = DADOS.Rows[0]["Unidade"].ToString();
            DateTime data = Convert.ToDateTime(DADOS.Rows[0]["Data_Validade"].ToString());
            btnDelProduto.Enabled = true;

            Cad_Novo_Produto cadnovo = new Cad_Novo_Produto(codigo,fornecedores,preco,nome,tipo,unidade,barcode,estoque,data);
            cadnovo.ShowDialog();
            tabelaRefresh();
        }

        private void dgvProduto_Click(object sender, EventArgs e)
        {
            btnDelProduto.Enabled = true;
        }
    }
}
