using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPadoca.Forms_Iniciais
{
    public partial class InserirProduto : Form
    {
        public InserirProduto()
        {
            InitializeComponent();
        }
        int qtde = 0;
        public InserirProduto(int Id_Produto, string Nome, decimal Preco, string CodBarras)
        {
            InitializeComponent();
            txtIdProd.Text = Convert.ToString(Id_Produto);
            txtDescricao.Text = Nome;
            txtPreco.Text = Convert.ToString(Preco);
            txtCodBarras.Text = CodBarras;     
        }

        private void InserirProduto_Load(object sender, EventArgs e)
        {
            txtQtde.Text = Convert.ToString(1);
        }
        public int Quantidade()
        {
            int Quantidade = qtde;
            return Quantidade;
        }
        public void btnEnviar_Click(object sender, EventArgs e)
        {
            qtde = Convert.ToInt32(txtQtde.Text);          
            Close();
        }

        private void InserirProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
            if(e.KeyChar == 116)
            {
                btnEnviar.PerformClick();
            }
        }
    }
}
