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
    public partial class PDV : Form
    {
        public PDV()
        {
            InitializeComponent();
        }
        decimal ValorCompra = 0;
        int cod = 1,qtde = 0, codigo = 0, numeroitens=0;
        public static int IdCliente = 1;
        public static string Lista;
        int NivelAcesso = SESSION.NivelUser;
        string SenhaG = SESSION.SenhaGerente;

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            
                string Produtos = rtbDescricao.Text;
                PDV.Lista = Produtos;

                int Id_Produto = 1;
                decimal SubTotal = Convert.ToDecimal(ValorCompra);
                string DataVenda = lblDataAtual.Text;
                string HoraVenda = lblHoraAtual.Text;


                FinalizarVenda FmFinalizar = new FinalizarVenda(Id_Produto, SubTotal, DataVenda, HoraVenda);
                FmFinalizar.ShowDialog();


                int valorLimpar = FmFinalizar.SucessoCadastro();
                if (valorLimpar == 1)
                {
                    rtbListaProdutos.Text = "";
                    rtbDescricao.Text = "";
                    valorDaCompra.Text = "0,00";
                    txtQuantidade.Text = "1";
                    lblnumeroitems.Text = "";
                    numeroitens = 0;
                    qtde = 0;
                    lblquantidade.Text = "";
                    cod = 1;
                    ValorCompra = 0;
                }           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValorCompra == 0)
            {
                Close();
                SESSION.TurnoUser = 0;
            }
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            if (ValorCompra == 0)
            {
                Close();
                SESSION.TurnoUser = 0;
            }
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void PDV_Load(object sender, EventArgs e)
        {

            lblDataAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblUsername.Text = SESSION.UserName;
            tabelaRefresh();
            

        }

        private void tabelaRefresh()
        {
            Produtos ConsultaProd = new Produtos();
            dgConsulta.DataSource = ConsultaProd.ConsultarProdutos();
        }

        private void tabelaRefresh(string Nome_Produto)
        {
            Produtos ConsultaProd = new Produtos();
            dgConsulta.DataSource = ConsultaProd.ConsultarProdutos(Nome_Produto);
        }

        private void txtInsersaoProdutos_TextChanged(object sender, EventArgs e)
        {
            txtForaEstoque.Visible = false;
            if (!string.IsNullOrEmpty(txtInsersaoProdutos.Text))
            {
                dgConsulta.Visible = true;
                tabelaRefresh(txtInsersaoProdutos.Text);

            }

            else
            {
                dgConsulta.Visible = false;
            }

        }

        private void PDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 118)
            {
                if (txtForaEstoque.Visible == true)
                    txtForaEstoque.Visible = false;
                else
                    txtForaEstoque.Visible = true;
            }

        }

        private void txtInsersaoProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexao con = new Conexao();         
            decimal r = 0;
            if (e.KeyChar == 13)
            {
                int consulta = con.Produto(txtInsersaoProdutos.Text);
                if (consulta > 0)
                {
               
                    string CodigoInserido = txtInsersaoProdutos.Text;
                    string CodigoVer = "";
                    if (CodigoInserido[0] == '2' && CodigoInserido.Length > 6)
                    {
                        CodigoVer = CodigoInserido.Substring(0, 6);
                    }
                    else
                    {
                        CodigoVer = CodigoInserido;
                    }
                    
                    Produtos InserirCod = new Produtos();
                    DataTable Inserir = InserirCod.ConsultarBarcode(CodigoVer);
                    //MessageBox.Show("Consulta realizada: "+ CodigoVer + " /  Quantidade encontrada:" + Inserir.Rows.Count);
                    int Id = Convert.ToInt32(Inserir.Rows[0]["Id_Produto"].ToString());
                    string Nome = Inserir.Rows[0]["Nome_Produto"].ToString();
                    decimal Preco = Convert.ToDecimal(Inserir.Rows[0]["Preco"].ToString());
                    string CodBarras = Inserir.Rows[0]["Cod_Barras"].ToString();
                    int Unidade = Convert.ToInt32(Inserir.Rows[0]["Unidade"].ToString());

                    string UnidadeKg;
                    int Inserirqtde = Convert.ToInt32(txtQuantidade.Text);
                    if (Unidade == 2)
                    {
                        UnidadeKg = "KG";
                        //string Peso = CodBarras[6].ToString() + CodBarras[7].ToString() + CodBarras[8].ToString() + CodBarras[9].ToString() + CodBarras[10].ToString() + CodBarras[11].ToString();
                        string Peso = CodigoInserido.Substring(CodigoInserido.Length - 6);
                        decimal Peso2 = Convert.ToDecimal(Peso);
                        r = ((Preco / 1000) * Peso2) / 10;
                    }
                    else
                    {
                        UnidadeKg = "UN";
                        r = Preco;
                    }

                    decimal Valor = 0;
                    Valor = Inserirqtde * r;
                    int repetir = 1;

                    if (Unidade == 4) { }
                    else
                    {
                        if (cod == 1)
                        {
                            Conexao maxid = new Conexao();
                            int max = maxid.MaxPedido();
                            string variavel = "Oficina de Pães e Doces Vitoria " + "\n" + "CPNJ: 1234567891011" + " \n" + "Odorico Martins do Amaral, 1495 " + "\n" + "Tel Fixo: 3283-4583" + "\n" + "Data: " + lblDataAtual.Text + " Horario: " + lblHoraAtual.Text + " N° Pedido: " + max + "\n" + "==================================================================" + "\n" + "\t \t \t \t CUPOM NÃO FISCAL" + "\n" + "==================================================================" + "\n" + "Cód  \t Nome \t \t Qtde \t \t Tipo \t  Preço \t CodBarras " + "\n" + "==================================================================" + "\n";
                            rtbListaProdutos.Text += variavel;
                        }

                        while (repetir != 0)
                        {
                            string variavel = (" " + cod + " \t " + Nome + " \t " + Inserirqtde + "   \t " + UnidadeKg + " \t \t " + " \t " + r.ToString("F") + "  " + CodBarras + "\n");
                            rtbListaProdutos.Text += variavel;
                            rtbDescricao.Text += variavel;
                            cod++;
                            repetir--;
                            numeroitens++;
                        }
                        ValorCompra += Valor;
                        valorDaCompra.Text = ValorCompra.ToString("F");
                        qtde += Inserirqtde;
                        lblquantidade.Text = Convert.ToString(qtde);
                        lblnumeroitems.Text = Convert.ToString(numeroitens);
                    }
                    dgConsulta.Visible = false;
                    txtInsersaoProdutos.Text = "";
                }
            }
        }

        private void dgConsulta_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.dgConsulta.Visible = false;
            txtInsersaoProdutos.Text = "";
            codigo = Convert.ToInt16(dgConsulta.SelectedRows[0].Cells[0].Value);
            Produtos InserirValor = new Produtos();
            DataTable Inserir = InserirValor.ConsultarProdutos(codigo);
            int Id_Produto = Convert.ToInt32(Inserir.Rows[0]["Id_Produto"].ToString());
            int Unidade = Convert.ToInt32(Inserir.Rows[0]["Unidade"].ToString());
            string Nome = Inserir.Rows[0]["Nome_Produto"].ToString();
            decimal Preco = Convert.ToDecimal(Inserir.Rows[0]["Preco"].ToString());
            string CodBarras = Inserir.Rows[0]["Cod_Barras"].ToString();
            string UnidadeKg;

            if (Unidade == 2)
                UnidadeKg = "KG";

            else
                UnidadeKg = "UN";

            InserirProduto insersao = new InserirProduto(Id_Produto, Nome, Preco, CodBarras);
            insersao.ShowDialog();
            int Inserirqtde = insersao.Quantidade();
            decimal Valor = 0;
            Valor = Inserirqtde * Preco;
            

            if (cod == 1)
            {
                Conexao maxid = new Conexao();
                int max = maxid.MaxPedido();
                string variavel = "Oficina de Pães e Doces Vitoria " + "\n" + "CPNJ: 1234567891011" + " \n" + "Odorico Martins do Amaral, 1495 " + "\n" + "Tel Fixo: 3283-4583" + "\n" + "Data: " + lblDataAtual.Text + " Horario: " + lblHoraAtual.Text + " N° Pedido: " + max + "\n" + "==================================================================" + "\n" + "\t \t \t \t CUPOM NÃO FISCAL" + "\n" + "==================================================================" + "\n" + "Cód  \t Nome \t \t Qtde \t \t Tipo \t  Preço \t CodBarras " + "\n" + "==================================================================" + "\n";
                rtbListaProdutos.Text += variavel;
            }


            int repetir = 1;
            while (repetir != 0)
            {
                //string variavel = (" " + cod + " " + Nome + " " + Inserirqtde + " " + UnidadeKg + " " + Preco + " " + CodBarras + "\n");
                string variavel = (" "+cod + " \t " + Nome + " \t " + Inserirqtde+"   \t "+ UnidadeKg +" \t \t "+" \t "+ Preco + "  " + CodBarras + "\n");
                rtbListaProdutos.Text += variavel;
                cod++;
                repetir--;
                numeroitens++;
            }

            ValorCompra += Valor;
            valorDaCompra.Text = Convert.ToString(ValorCompra);
            qtde += Inserirqtde;
            lblquantidade.Text = Convert.ToString(qtde);
            lblnumeroitems.Text = Convert.ToString(numeroitens);
        }



        private void btnRetirarCaixa_Click(object sender, EventArgs e)
        {
            Retirada_Caixa retirada = new Retirada_Caixa();
            retirada.ShowDialog();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente cliente = new ConsultarCliente();
            cliente.ShowDialog();
        }

        private void btnConsultaPreco_Click(object sender, EventArgs e)
        {
            ConsultarPreco preco = new ConsultarPreco();
            preco.ShowDialog();
        }

        private void btnAnotacoes_Click(object sender, EventArgs e)
        {
            Anotacoes anotacao = new Anotacoes();
            anotacao.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NivelAcesso == 1)
            {
                CancelarItem cancelar = new CancelarItem();
                cancelar.ShowDialog();
                int valor = (cancelar.ValorApagar() +9);
                DeleteLine(valor);
                cod--;
            }
            else
            {
                AutorizacaoSenha autorizar = new AutorizacaoSenha();
                autorizar.ShowDialog();

                if (autorizar.Autorizado())
                {
                    CancelarItem cancelar = new CancelarItem();
                    cancelar.ShowDialog();
                    int valor = (cancelar.ValorApagar() - 1);
                    DeleteLine(valor);
                    cod--;
                }              
            }
        }

        private void DeleteLine(int a_line)
        {
            int start_index = rtbListaProdutos.GetFirstCharIndexFromLine(a_line);
            int count = rtbListaProdutos.Lines[a_line].Length;

            // Eat new line chars
            if (a_line < rtbListaProdutos.Lines.Length - 1)
            {
                count += rtbListaProdutos.GetFirstCharIndexFromLine(a_line + 1) -
                    ((start_index + count - 1) + 1);
            }

            rtbListaProdutos.Text = rtbListaProdutos.Text.Remove(start_index, count);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtForaEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (cod == 1)
                {
                    Conexao maxid = new Conexao();
                    int max = maxid.MaxPedido();
                    string variavel = "Oficina de Pães e Doces Vitoria " + "\n" + "CPNJ: 1234567891011" + " \n" + "Odorico Martins do Amaral, 1495 " + "\n" + "Tel Fixo: 3283-4583" + "\n" + "Data: " + lblDataAtual.Text + " Horario: " + lblHoraAtual.Text + " N° Pedido: " + max + "\n" + "==================================================================" + "\n" + "\t \t \t \t CUPOM NÃO FISCAL" + "\n" + "==================================================================" + "\n" + "Cód  \t Nome \t \t Qtde \t \t Tipo \t  Preço \t CodBarras " + "\n" + "==================================================================" + "\n";
                    rtbListaProdutos.Text += variavel;
                }
                decimal valorInserido = Convert.ToDecimal(txtForaEstoque.Text);
                string to = valorInserido.ToString("F");
                
                int repetir = 1;

                while (repetir != 0)
                {
                    string variavel = (" " + cod + " \t " + "ITEM NAO CADASTRADO" + " \t " + txtQuantidade.Text + "\t \t  UN \t \t"+to+ "\t"+ "000000" + "\n");
                    rtbListaProdutos.Text += variavel;
                    cod++;
                    numeroitens++;
                    repetir--;
                }

                ValorCompra += Convert.ToDecimal(valorInserido);
                valorDaCompra.Text = Convert.ToString(ValorCompra);
                qtde += Convert.ToInt32(txtQuantidade.Text);
                lblquantidade.Text = Convert.ToString(qtde);
                lblnumeroitems.Text = Convert.ToString(numeroitens);
                txtForaEstoque.Text = "";
                txtInsersaoProdutos.Text = "";
                txtForaEstoque.Visible = false;
            }
        }

        private void txtForaEstoque_TextChanged(object sender, EventArgs e)
        {
            dgConsulta.Visible = false;
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            if (NivelAcesso == 1)
            {
                rtbListaProdutos.Text = "";
                rtbDescricao.Text = "";
                valorDaCompra.Text = "0,00";
                txtQuantidade.Text = "1";
                lblnumeroitems.Text = "";
                numeroitens = 0;
                qtde = 0;
                lblquantidade.Text = "";              
                cod = 1;
                ValorCompra = 0;
            }
            else
            {
                AutorizacaoSenha autorizar = new AutorizacaoSenha();
                autorizar.ShowDialog();

                if (autorizar.Autorizado())
                {
                    rtbListaProdutos.Text = "";
                    rtbDescricao.Text = "";
                    valorDaCompra.Text = "0,00";
                    txtQuantidade.Text = "1";
                    lblnumeroitems.Text = "";
                    numeroitens = 0;
                    qtde = 0;
                    lblquantidade.Text = "";
                    cod = 1;
                    ValorCompra = 0;
                }
                
            }
        }
    }
}
