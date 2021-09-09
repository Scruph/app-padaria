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
    public partial class AutorizacaoSenha : Form
    {
        public AutorizacaoSenha()
        {
            InitializeComponent();
        }
        public bool Aprovado = false;

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSenha.Text))
            {
                lblaviso.Text = "";
                string senha = txtSenha.Text;
                string senhaG = SESSION.SenhaGerente;

                if (senha == senhaG)
                {
                    Aprovado = true;
                    Close();
                }
                else
                {
                    lblaviso.Text = "* Senha Incorreta";
                    txtSenha.Text = "";
                    Aprovado = false;
                }
            }
            else
            {
                lblaviso.Text = "* Senha Incorreta";
                Aprovado = false;
            }
        }
        public bool Autorizado()
        {
            return Aprovado;
        }

        private void AutorizacaoSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }

        }
    }
}
