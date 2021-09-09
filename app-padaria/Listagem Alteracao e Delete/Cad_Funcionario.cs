using SistemaPadoca.Forms_Iniciais;
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
    public partial class Cad_Funcionario : Form
    {
        public Cad_Funcionario()
        {
            InitializeComponent();
        }
        int codigo;
        int Nivel = SESSION.NivelUser;

        private void tabelaRefresh(string strValor)
        {
            Funcionario_Padaria funcionario = new Funcionario_Padaria();
            dgvFuncionarios.DataSource = funcionario.ConsultarFuncionarios(strValor);
        }
        private void tabelaRefresh()
        {
            Funcionario_Padaria funcionario = new Funcionario_Padaria();
            dgvFuncionarios.DataSource = funcionario.ConsultarFuncionarios();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            Cad_Novo_Funcionario novo_Funcionario = new Cad_Novo_Funcionario();
            novo_Funcionario.ShowDialog();
            tabelaRefresh();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Deseja realmente Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSairFuncionario_Click(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Deseja realmente Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDelFuncionario_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt16(dgvFuncionarios.SelectedRows[0].Cells[0].Value);
            DialogResult Excluir = MessageBox.Show("Excluir item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Excluir == DialogResult.Yes)
            {
                Funcionario_Padaria funcionario = new Funcionario_Padaria();
                funcionario.DelFuncionarios(codigo);
                btnDelFuncionario.Enabled = false;
                MessageBox.Show("Item Removido!", "Confirmação", MessageBoxButtons.OK);
            }

            tabelaRefresh();
        }

        private void txtConsultaFuncionario_TextChanged(object sender, EventArgs e)
        {
            string pesquisar = txtConsultaFuncionario.Text;
            tabelaRefresh(pesquisar);
        }

        private void Cad_Funcionario_Load(object sender, EventArgs e)
        {
            btnDelFuncionario.Enabled = false;
            tabelaRefresh();
            dgvFuncionarios.ClearSelection();
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar Id Permissoes 
            int NivelUsuario;                    
            string Username,Password,CPFFuncionario, NomeFuncionario, BairroFuncionario, RuaFuncionario, NmrResidenciaFuncionario, TelFixoFuncionario, TelCelFuncionario;
            codigo = Convert.ToInt16(dgvFuncionarios.SelectedRows[0].Cells[0].Value);
            Funcionario_Padaria funcionario = new Funcionario_Padaria();
            DataTable DADOS = funcionario.ConsultarFuncionarios(codigo);
            NivelUsuario = Convert.ToInt32(DADOS.Rows[0]["Id_Permissoes"].ToString());
            CPFFuncionario = DADOS.Rows[0]["CPF_Funcionario"].ToString();
            Username = DADOS.Rows[0]["Username"].ToString();
            Password = DADOS.Rows[0]["Password"].ToString();
            NomeFuncionario = DADOS.Rows[0]["Nome_Funcionario"].ToString();
            BairroFuncionario = DADOS.Rows[0]["Bairro_Funcionario"].ToString();
            RuaFuncionario = DADOS.Rows[0]["Rua_Funcionario"].ToString();
            NmrResidenciaFuncionario = DADOS.Rows[0]["Numero_Residencia_Funcionario"].ToString();
            TelFixoFuncionario = DADOS.Rows[0]["Telefone_Fixo_Funcionario"].ToString();
            TelCelFuncionario = DADOS.Rows[0]["Telefone_Celular_Funcionario"].ToString();
            Cad_Novo_Funcionario Attfuncionario = new Cad_Novo_Funcionario(codigo, NivelUsuario, Username,Password, CPFFuncionario, NomeFuncionario, BairroFuncionario, RuaFuncionario, NmrResidenciaFuncionario, TelFixoFuncionario, TelCelFuncionario);
            Attfuncionario.ShowDialog();
            tabelaRefresh();          
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelFuncionario.Enabled = true;
        }

        private void Cad_Funcionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
