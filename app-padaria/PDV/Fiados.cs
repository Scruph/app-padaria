using SistemaPadoca.Classes;
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
    public partial class Fiados : Form
    {
        public Fiados()
        {
            InitializeComponent();
        }
        int codigo = 0;
        int GId_Cliente = 0;
        public static int Idzin=0;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tabelaRefresh()
        {
            Cliente_Padaria cliente = new Cliente_Padaria();
            dgFiado.DataSource = cliente.ConsultarClientesDvg();
        }
        private void tabelaRefresh(string clientes)
        {
            Cliente_Padaria cliente = new Cliente_Padaria();
            dgFiado.DataSource = cliente.ConsultarClientesDvg(clientes);
        }

        private void Fiados_Load(object sender, EventArgs e)
        {
            dgFiado.ClearSelection();
            tabelaRefresh();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            tabelaRefresh(txtConsulta.Text);
        }

        private void dgFiado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {          
            codigo = Convert.ToInt32(dgFiado.SelectedRows[0].Cells[0].Value);
            Cliente_Padaria cliente = new Cliente_Padaria();
            DataTable DADOS = cliente.ConsultarClientes(codigo);
            int Id_Clientes = Convert.ToInt32(DADOS.Rows[0]["Id_Cliente"].ToString());
            Fiados.Idzin = Id_Clientes;
          
            Close();

        }
        public int PegarId()
        {          
            return GId_Cliente;
        }

        private void Fiados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
