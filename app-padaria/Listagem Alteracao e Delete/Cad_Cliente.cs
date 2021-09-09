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
    public partial class Cad_Cliente : Form
    {
        public Cad_Cliente()
        {
            InitializeComponent();
        }
        //variavel que sera atribuido valor ao se clicar em uma linha do datagrid
        int codigo = 0;

        //funçao responsavel por atualizar a tabela de registros, utilizando a barra de pesquisa
        private void tabelaRefresh(string strValor)
        {
            Cliente_Padaria cliente = new Cliente_Padaria();
            dgvCliente.DataSource = cliente.ConsultarClientes(strValor);
        }

        //funçao responsavel por atualizar todos registros da tabela
        private void tabelaRefresh()
        {
            Cliente_Padaria cliente = new Cliente_Padaria();
            dgvCliente.DataSource = cliente.ConsultarClientes();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Deseja realmente Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        //botao resposavel por chamar outro formulario responsavel pela inserçao
        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            Cad_Novo_Cliente novo_cliente = new Cad_Novo_Cliente();
            novo_cliente.ShowDialog();
            tabelaRefresh();
        }

        private void btnSairCliente_Click(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Deseja realmente Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        //apagando registros ao se clicar na linha referente a ele na tabela
        private void btnDelCliente_Click(object sender, EventArgs e)
        {
            //pega o codigo da linha
            codigo = Convert.ToInt16(dgvCliente.SelectedRows[0].Cells[0].Value);
            //dialogo de confirmarçao de exclusao
            DialogResult Excluir = MessageBox.Show("Excluir item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Excluir == DialogResult.Yes)
            {
                Cliente_Padaria cliente = new Cliente_Padaria();
                cliente.DelCliente(codigo);
                btnDelCliente.Enabled = false;
                MessageBox.Show("Item Removido!", "Confirmação", MessageBoxButtons.OK);
            }
            //atualizando tabela apos exclusao
            tabelaRefresh();
        }

        //campo de texto responsavel realizar a pesquisa por nome
        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            string pesquisar = txtPesquisaCliente.Text;
            tabelaRefresh(pesquisar);
        }

        // ao clicar duas vezes na linha, abre o formulario com as informaçoes da linha clicada
        private void dgvCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Situacao = 0,Limite = 0;
            string CPFCliente, NomeCliente, BairroCliente, RuaCliente, NmrResidenciaCliente, TelefoneFixoCliente, TelefoneCelularCliente;
            codigo = Convert.ToInt16(dgvCliente.SelectedRows[0].Cells[0].Value);
            //instanciando a classe
            Cliente_Padaria cliente = new Cliente_Padaria();
            //fazendo uma consulta no banco de dados para que se possa pegar os valores do registro clicado
            DataTable DADOS = cliente.ConsultarClientes(codigo);
            //atribuindo variaveis valores encontrados na consulta
            CPFCliente = DADOS.Rows[0]["CPF_Cliente"].ToString();           
            NomeCliente = DADOS.Rows[0]["Nome_Cliente"].ToString();
            BairroCliente = DADOS.Rows[0]["Bairro_Cliente"].ToString();
            RuaCliente = DADOS.Rows[0]["Rua_Cliente"].ToString();
            NmrResidenciaCliente = DADOS.Rows[0]["Numero_Residencia_Cliente"].ToString();
            TelefoneFixoCliente = DADOS.Rows[0]["Telefone_Fixo_Cliente"].ToString();
            TelefoneCelularCliente = DADOS.Rows[0]["Telefone_Celular_Cliente"].ToString();
            Limite = Convert.ToInt32(DADOS.Rows[0]["Limite"].ToString());

            //passando os valores para a funçao atualizar registros
            Cad_Novo_Cliente newCliente = new Cad_Novo_Cliente(codigo, CPFCliente, NomeCliente, BairroCliente, RuaCliente, NmrResidenciaCliente, TelefoneFixoCliente, TelefoneCelularCliente,Situacao,Limite);
            newCliente.ShowDialog();
            tabelaRefresh();
        }

        private void Cad_Cliente_Load(object sender, EventArgs e)
        {
            btnDelCliente.Enabled = false;
            tabelaRefresh();
            dgvCliente.ClearSelection();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelCliente.Enabled = true;
        }

    }
}
