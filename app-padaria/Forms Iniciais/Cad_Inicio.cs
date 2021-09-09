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
    public partial class Cad_Inicio : Form
    {
        public Cad_Inicio()
        {
            InitializeComponent();
        }
        int Nivel = SESSION.NivelUser;

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            Cad_Produto cadproduto = new Cad_Produto();
            cadproduto.ShowDialog();
            this.Close();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            Cad_Cliente cliente = new Cad_Cliente();
            cliente.ShowDialog();
            this.Close();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            if (Nivel == 1)
            {
                Cad_Funcionario funcionario = new Cad_Funcionario();
                funcionario.ShowDialog();
                this.Close();
            }
            else
            {
                AutorizacaoSenha auto = new AutorizacaoSenha();
                auto.ShowDialog();
                if (auto.Autorizado())
                {
                    Cad_Funcionario funcionario = new Cad_Funcionario();
                    funcionario.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            Cad_Fornecedor fornecedor = new Cad_Fornecedor();
            fornecedor.ShowDialog();
            this.Close();
        }

        private void Cad_Inicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape){
                this.Close();
            }
        }

    }
}
