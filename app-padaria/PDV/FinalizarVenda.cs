using MySql.Data.MySqlClient.Memcached;
using SistemaPadoca.Classes;
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
    public partial class FinalizarVenda : Form
    {
        public FinalizarVenda()
        {
            InitializeComponent();

        }
        public int Limpar = 0,Gcodigo =0;
        int G_Id_Produto=0;
        decimal G_SubTotal=0;
        string G_DataVenda, G_HoraVenda;
        public static decimal Subtotal = 0;

        public FinalizarVenda(int Id_Produto,decimal SubTotal,string  DataVenda, string HoraVenda)
        {
            InitializeComponent();        
            G_Id_Produto = Id_Produto;          
            G_SubTotal = SubTotal;
            G_DataVenda = DataVenda;
            G_HoraVenda = HoraVenda;     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FinalizarVenda_Load(object sender, EventArgs e)
        {
            lblFormaPagamento.Text = "Dinheiro";
            lblValorFinal.Text = Convert.ToString(G_SubTotal);

        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {

            Conexao max = new Conexao();
            int max2 = max.MaxPedido();
            string Pagamento = lblFormaPagamento.Text;
            int Id_Funcionario = SESSION.IdUser;
            int Turno = SESSION.TurnoUser;
            int Cliente=0;

            if(Fiados.Idzin < 1)
            {
                Cliente = 1;
            }
            else
            {
                Cliente = Fiados.Idzin;
            }
            //Verificando se o valor no texbox dinherio é menor que o da compra ou em branco
            if (!String.IsNullOrWhiteSpace(txtDinheiro.Text))
            {
                decimal txtDinheiro1 = Convert.ToDecimal(txtDinheiro.Text);


                if (txtDinheiro1 >= G_SubTotal && txtDinheiro.Text != "")
                {

                    //Executa um cadastro ou uma atualizaçao caso o cliente nao tenha pendencias no comercio
                    if (max.Gastos(Cliente) > 0)
                    {
                        GastosCliente gastoAtt = new GastosCliente(Cliente, G_SubTotal, 0, DateTime.Now);
                        if (gastoAtt.Att_Gastos()) { }

                        else
                            MessageBox.Show("Falha ao Alterar");
                    }
                    else
                    {
                        GastosCliente gastoAdd = new GastosCliente(Cliente, G_SubTotal);
                        if (gastoAdd.Add_Gastos()) { }

                        else
                            MessageBox.Show("Falha ao Cadastrar");

                    }


                    Venda_Efetuada salvarVenda = new Venda_Efetuada(Id_Funcionario, Cliente, max2, Pagamento, G_SubTotal, G_DataVenda, Turno, G_HoraVenda);
                    Pedido cadastro = new Pedido(G_SubTotal, PDV.Lista);
                    if (cadastro.AddPedido() && salvarVenda.Add_Venda())
                    {
                        Limpar++;
                        Fiados.Idzin = 1;
                        SESSION.ValorTotalDia += G_SubTotal;
                        switch (lblFormaPagamento.Text)
                        {
                            case "Dinheiro":
                                SESSION.ValorDinheiroDia += G_SubTotal;
                                break;
                            case "Débito":
                                SESSION.ValorDebitoDia += G_SubTotal;
                                break;
                            case "Crédito":
                                SESSION.ValorCreditoDia += G_SubTotal;
                                break;
                            case "A Prazo":
                                SESSION.ValorFiadoDia += G_SubTotal;
                                break;
                            default:
                                break;
                        }
                        Close();
                    }
                    else
                        MessageBox.Show("Falha ao Cadastrar");
                }
                else
                {
                    MessageBox.Show("O Valor do Dinheiro não pode ser menor que o da compra!");
                }
            }
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            lblFormaPagamento.Text = "Dinheiro";
            txtDinheiro.Text = Convert.ToString(G_SubTotal);          
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            lblFormaPagamento.Text = "Débito";
            txtDinheiro.Text = Convert.ToString(G_SubTotal);
            txtTroco.Text = "";
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            lblFormaPagamento.Text = "Crédito";
            txtDinheiro.Text = Convert.ToString(G_SubTotal);
            txtTroco.Text = "";
        }


        private void FinalizarVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
           

        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal dinheiro = 0, valorsalvar = 0;
                decimal verificar = Convert.ToInt32(lblValorFinal.Text);
                dinheiro = Convert.ToDecimal(txtDinheiro.Text);
                if (dinheiro >= verificar) {

                    valorsalvar = dinheiro - G_SubTotal;
                    txtTroco.Text = Convert.ToString(valorsalvar);
                }
                else
                {
                    MessageBox.Show("O Dinheiro não pode ser menor que o VALOR da compra");
                }             
                
            }
        }

        private void FinalizarVenda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                lblFormaPagamento.Text = "Dinheiro";
            }
            if (e.KeyCode == Keys.F7)
            {
                lblFormaPagamento.Text = "Débito";
            }
            if (e.KeyCode == Keys.F8)
            {
                lblFormaPagamento.Text = "Crédito";
            }
            if (e.KeyCode == Keys.F9)
            {
                lblFormaPagamento.Text = "A Prazo";
            }


        }

        private void btnFiado_Click(object sender, EventArgs e)
        {
            Fiados fiado = new Fiados();
            fiado.ShowDialog();
            lblFormaPagamento.Text = "A Prazo";
            txtDinheiro.Text = Convert.ToString(G_SubTotal);
            txtTroco.Text = "";
        }

        public int SucessoCadastro()
        {
            int Limpar2 = Limpar;
            return Limpar2;
        }

 
    }
}
