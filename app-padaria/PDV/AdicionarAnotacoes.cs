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
    public partial class AdicionarAnotacoes : Form
    {
        public AdicionarAnotacoes()
        {
            InitializeComponent();
        }

        public AdicionarAnotacoes(int idAnotacao,string descricao,string situacao, DateTime dt)
        {
            InitializeComponent();
            txtCod.Text = Convert.ToString(idAnotacao);
            txtDescricao.Text = descricao;
            cbSituacao.SelectedItem = situacao;
            dtData.Value = dt;
        }

        private void AdicionarAnotacoes_Load(object sender, EventArgs e)
        {
            dtData.Enabled = false;
        }

        private void btnSalvarAnotacoes_Click(object sender, EventArgs e)
        {
            string descricao, situacao;
            DateTime dt;

            descricao = txtDescricao.Text;
            situacao = Convert.ToString(cbSituacao.SelectedItem);
            dt = dtData.Value;

            if (txtCod.Text == "")
            {
                Anotar cadastrar = new Anotar(descricao,situacao,dt);
                if (cadastrar.AddAnotacao())
                {
                    MessageBox.Show("Anotação Cadastrada com Sucesso");
                }
                else
                    MessageBox.Show("Falha ao Cadastrar Anotação");
            }          
            else
            {
                int codigo = Convert.ToInt32(txtCod.Text);
                Anotar cadastrar = new Anotar(codigo,descricao, situacao, dt);
                if (cadastrar.AttAnotacao())
                {
                    MessageBox.Show("Anotação Alterada com Sucesso");
                }
                else
                    MessageBox.Show("Falha ao Alterar Anotação");
            }
        
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdicionarAnotacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }

            if(e.KeyChar == 116)
            {
                btnSalvarAnotacoes.PerformClick();
            }
        }
    }
}
