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
    public partial class Cad_Fornecedor : Form
    {
        public Cad_Fornecedor()
        {
            InitializeComponent();
        }

        int codigo = 0;
        
     
        private void tabelaRefresh(string strValor)
        {
            Fornecedores fornec = new Fornecedores();
            dgvFornecedores.DataSource = fornec.ConsultaFornecedores(strValor);
        }

        private void tabelaRefresh()
        {
            Fornecedores fornec = new Fornecedores();
            dgvFornecedores.DataSource = fornec.ConsultaFornecedores();
        }

        private void txtConsultaFornec_TextChanged(object sender, EventArgs e)
        {
            tabelaRefresh(txtConsultaFornec.Text);
        }

        private void Cad_Fornecedor_Load(object sender, EventArgs e)
        {
            tabelaRefresh();
            btnDelFornec.Enabled = false;
            dgvFornecedores.ClearSelection();
        }

        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Deseja realmente Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnNovoFornecedor_Click_1(object sender, EventArgs e)
        {
            Cad_Novo_Fornecedor novo_Fornecedor = new Cad_Novo_Fornecedor();
            novo_Fornecedor.ShowDialog();
            tabelaRefresh();
        }

        private void btnDelFornec_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt16(dgvFornecedores.SelectedRows[0].Cells[0].Value);
            DialogResult Excluir = MessageBox.Show("Excluir item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Excluir == DialogResult.Yes)
            {
                Fornecedores fornec = new Fornecedores();
                fornec.DelFornecedores(codigo);
                btnDelFornec.Enabled = false;
                MessageBox.Show("Item Removido!", "Confirmação", MessageBoxButtons.OK);
                tabelaRefresh();
            }
        }

        private void btnSairFornec_Click(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Fechar esta aba?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt16(dgvFornecedores.SelectedRows[0].Cells[0].Value);
            btnDelFornec.Enabled = true;
        }

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomefornec, nomevende, telemp, telcel;
            codigo = Convert.ToInt16(dgvFornecedores.SelectedRows[0].Cells[0].Value);
            Fornecedores fornec = new Fornecedores();
            DataTable DADOS = fornec.ConsultarFornecedores(codigo);
            nomefornec = DADOS.Rows[0]["Nome_Fornecedores"].ToString();
            nomevende = DADOS.Rows[0]["Nome_Vendedor"].ToString();
            telemp = DADOS.Rows[0]["Telefone_Fixo_Fornecedor"].ToString();
            telcel = DADOS.Rows[0]["Telefone_Celular_Fornecedor"].ToString();
            Cad_Novo_Fornecedor cadfornec = new Cad_Novo_Fornecedor(codigo, nomefornec, nomevende, telemp, telcel);
            cadfornec.ShowDialog();
            tabelaRefresh();
        }
    }
}
