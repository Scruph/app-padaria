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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }
        decimal valorRecibo=0;
        int Id_Cliente = 0;
        decimal ValorAtual = 0, ValorPago = 0;
        //Declarando Variaveis Globais
        int codigo = 0;

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {           
            tabelaRefresh();
            dgvCliente.ClearSelection();
        }
        private void tabelaRefreshDados(int Id_Cliente)
        {
            Cliente_Padaria cliente = new Cliente_Padaria();
            dgvCliente.DataSource = cliente.DadosFinancaCliente(Id_Cliente);
        }
        private void tabelaRefresh()
        {
            Cliente_Padaria cliente = new Cliente_Padaria();
            dgvCliente.DataSource = cliente.DadosFinancaCliente();
        }

        private void ConsultarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            int ID = 0, Limite =0;
            string Nome,Data;
            codigo = Convert.ToInt16(dgvCliente.SelectedRows[0].Cells[0].Value);
            GastosCliente gastos = new GastosCliente();
            DataTable DadosFin = gastos.ConsultarGastos(codigo);
            ID = Convert.ToInt32(DadosFin.Rows[0]["Id_Gastos"].ToString());
            Id_Cliente = Convert.ToInt32(DadosFin.Rows[0]["Id_Cliente"].ToString());
            ValorAtual = Convert.ToDecimal(DadosFin.Rows[0]["ValorAtual"].ToString());
            ValorPago = Convert.ToDecimal(DadosFin.Rows[0]["ValorPago"].ToString());
            Data = Convert.ToString(DadosFin.Rows[0]["UltimaData"].ToString());

            Conexao con = new Conexao();
            Nome = con.NomeClienteFiado(Id_Cliente);
            Limite = con.LimiteCliente(Id_Cliente);

            lblNome.Text = Nome;
            lblUltimaData.Text = Data;
            lblLimite.Text = Limite.ToString("F");
            lblValorAtual.Text = Convert.ToString(ValorAtual);
            lbldata.Text = Convert.ToString(DateTime.Now);
            lblValorPago.Text = Convert.ToString(ValorPago);

            lblRece.Visible = true;
            txtRecebimento.Visible = true;
            btnBaixa.Enabled = true;

        }

        private void btnBaixa_Click(object sender, EventArgs e)
        {

            GastosCliente gastos = new GastosCliente(Id_Cliente);

            
        }

        private void txtRecebimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;


            if (e.KeyChar == 13)
            {
                valorRecibo = Convert.ToDecimal(txtRecebimento.Text);
                DateTime DataAtual = DateTime.Now;

                GastosCliente gastinho = new GastosCliente(Id_Cliente, ValorAtual, valorRecibo, DataAtual);
                if (gastinho.Att_Valor())
                {
                    dgvCliente_CellClick(this.dgvCliente, new DataGridViewCellEventArgs(this.dgvCliente.CurrentCell.ColumnIndex, this.dgvCliente.CurrentRow.Index));
                }
                txtRecebimento.Text = "";
            }
        }




    }
}
