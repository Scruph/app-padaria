using SistemaPadoca.Classes;
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
    public partial class Inicio : Form
    {

       public Inicio()
        {
            InitializeComponent();
            panel3.Height = btnCadastros.Height;
            panel3.Top = btnCadastros.Top;        
        }
        bool diaexiste;
        int Id_Dia;
        int Nivel = SESSION.NivelUser;

        private void btnCloseAllForms_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            Cad_Inicio cadinicio = new Cad_Inicio();
            cadinicio.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
            lblUser.Text = "Funcionário: " + SESSION.UserName;
            Conexao con = new Conexao();
            if(con.IdDiaCount() > 0){
                SESSION.DataDia = DateTime.Now;
                diaexiste = true;
                Id_Dia = con.IdDia();
            }
            else
            {
                diaexiste = false;
            }             
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: "+DateTime.Now.ToString("HH:mm:ss");
        }

        
        private void btnCadastros_MouseEnter(object sender, EventArgs e)
        {
            panel3.Height = btnCadastros.Height;
            panel3.Top = btnCadastros.Top;
        }

        private void btnRelatorios_MouseEnter(object sender, EventArgs e)
        {
            panel3.Height = btnRelatorios.Height;
            panel3.Top = btnRelatorios.Top;
        }

       

        private void btnFechamentoCaixa_MouseEnter(object sender, EventArgs e)
        {
            panel3.Height = btnFechamentoCaixa.Height;
            panel3.Top = btnFechamentoCaixa.Top;
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            Inicio_PDV ini_pdv = new Inicio_PDV();
            ini_pdv.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Close();

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (Nivel == 1)
            {
                BuscaRelatorio buscar = new BuscaRelatorio();
                buscar.ShowDialog();
            }
            else
            {
                AutorizacaoSenha auto = new AutorizacaoSenha();
                auto.ShowDialog();
                if (auto.Autorizado())
                {
                    BuscaRelatorio buscar = new BuscaRelatorio();
                    buscar.ShowDialog();
                }
            }
        }

        private void Inicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                DialogResult Fechar = MessageBox.Show("Deseja realmente Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Fechar == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void pbPdv_Click(object sender, EventArgs e)
        {
            PDV gerenciar = new PDV();
            gerenciar.ShowDialog();
        }

        private void pbFuncionarios_Click(object sender, EventArgs e)
        {
            if(Nivel == 1)
            {
                Cad_Funcionario gerenciar = new Cad_Funcionario();
                gerenciar.ShowDialog();
            }
            else
            {
                AutorizacaoSenha auto = new AutorizacaoSenha();
                auto.ShowDialog();
                if (auto.Autorizado())
                {
                    Cad_Funcionario gerenciar = new Cad_Funcionario();
                    gerenciar.ShowDialog();
                }
             }
            
            
        }

        private void pbClientes_Click(object sender, EventArgs e)
        {
            Cad_Cliente gerenciar = new Cad_Cliente();
            gerenciar.ShowDialog();
        }

        private void pbProdutos_Click(object sender, EventArgs e)
        {
            Cad_Produto gerenciar = new Cad_Produto();
            gerenciar.ShowDialog();
        }

        private void btnFechamentoCaixa_Click(object sender, EventArgs e)
        {
            if (Nivel == 1)
            {
                FechamentoCaixa fechamento = new FechamentoCaixa();
                fechamento.ShowDialog();
            }
            else
            {
                AutorizacaoSenha auto = new AutorizacaoSenha();
                auto.ShowDialog();
                if (auto.Autorizado())
                {
                    FechamentoCaixa fechamento = new FechamentoCaixa();
                    fechamento.ShowDialog();
                }
            }
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexao con = new Conexao();
            decimal ValorDia = 0, ValorDinheiro = 0, ValorDebito = 0, ValorCredito = 0, ValorRetirada = 0, ValorFiado = 0;
            DateTime Data = DateTime.Now;
            
            ValorDia = SESSION.ValorTotalDia;
            ValorDinheiro = SESSION.ValorDinheiroDia;
            ValorCredito = SESSION.ValorCreditoDia;
            ValorDebito = SESSION.ValorDebitoDia;
            ValorRetirada = SESSION.ValorRetiradaDia;
            ValorFiado = SESSION.ValorFiadoDia;
                                      
            if(diaexiste)
            {
                FecharCaixa att = new FecharCaixa(Id_Dia, ValorDia, ValorDinheiro, ValorDebito, ValorCredito, ValorFiado, ValorRetirada);
                if (att.Att_Dia()) { }

            }
            else
            {
                FecharCaixa add = new FecharCaixa(ValorDia, ValorDinheiro, ValorDebito, ValorCredito, ValorFiado, ValorRetirada, Data);
                if (add.Add_Dia()) { }

            }

        

        }
    }
}
