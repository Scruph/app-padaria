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
    public partial class Anotacoes : Form
    {
        public Anotacoes()
        {
            InitializeComponent();
        }
        int codigo = 0;

        private void btnAnotacoes_Click(object sender, EventArgs e)
        {
            AdicionarAnotacoes add = new AdicionarAnotacoes();
            add.ShowDialog();
        }
        private void tabelaRefresh(string Valor)
        {
            Anotar anotar = new Anotar();
            dgvConsulta.DataSource = anotar.ConsultaAnotacao();
        }
        private void tabelaRefresh()
        {
            Anotar anotar = new Anotar();
            dgvConsulta.DataSource = anotar.ConsultaAnotacao();
           
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            tabelaRefresh(txtConsulta.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt16(dgvConsulta.SelectedRows[0].Cells[0].Value);
            DialogResult Excluir = MessageBox.Show("Excluir item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Excluir == DialogResult.Yes)
            {
                Anotar fornec = new Anotar();
                fornec.DelFornecedores(codigo);              
                MessageBox.Show("Item Removido!", "Confirmação", MessageBoxButtons.OK);
                tabelaRefresh();
            }
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idAnotacao;
            string descricao, situacao;
            DateTime dt;

            codigo = Convert.ToInt32(dgvConsulta.SelectedRows[0].Cells[0].Value);
            Anotar consulta = new Anotar();
            DataTable Dados = consulta.ConsultaAnotacao(codigo);
            idAnotacao = Convert.ToInt32(Dados.Rows[0]["Id_Anotacao"].ToString());
            descricao = Dados.Rows[0]["Descricao"].ToString();
            situacao = Dados.Rows[0]["Situacao"].ToString();
            dt = Convert.ToDateTime(Dados.Rows[0]["Data"].ToString());
            AdicionarAnotacoes alterar = new AdicionarAnotacoes(idAnotacao,descricao,situacao,dt);
            alterar.ShowDialog();
            tabelaRefresh();
        }

        private void Anotacoes_Load(object sender, EventArgs e)
        {
            tabelaRefresh();
            dgvConsulta.ClearSelection();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dgvConsulta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvConsulta.Rows)
            {
                string dt = Convert.ToString(row.Cells[3].Value);

                if(dt == "Comprado")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        private void Anotacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }

            if (e.KeyChar == 116)
            {
                btnAnotacoes.PerformClick();
            }
        }
    }
}
