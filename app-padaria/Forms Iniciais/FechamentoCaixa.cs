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
    public partial class FechamentoCaixa : Form
    {
        public FechamentoCaixa()
        {
            InitializeComponent();
        }

        private void FechamentoCaixa_Load(object sender, EventArgs e)
        {
            lblDinheiro.Text = Convert.ToString(SESSION.ValorDinheiroDia);
            lblRetirada.Text = Convert.ToString(SESSION.ValorRetiradaDia);
            lblPrazo.Text = Convert.ToString(SESSION.ValorFiadoDia);
            lblDebito.Text = Convert.ToString(SESSION.ValorDebitoDia);
            lblCredito.Text = Convert.ToString(SESSION.ValorCreditoDia);
            lblValorTotalDia.Text = Convert.ToString(SESSION.ValorTotalDia);
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");           
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            DialogResult Fechar = MessageBox.Show("Essa Ação não Pode ser Desfeita! Tem Certeza que Deseja Fechar o Caixa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Fechar == DialogResult.Yes)
            {
                DateTime data = DateTime.Now;
                FecharCaixa fechamento = new FecharCaixa(SESSION.ValorTotalDia, SESSION.ValorDinheiroDia, SESSION.ValorDebitoDia,SESSION.ValorCreditoDia,SESSION.ValorFiadoDia,SESSION.ValorRetiradaDia,data);
                if (fechamento.Add_Dia())
                {
                    MessageBox.Show("Fechamento Concluido com Sucesso");
                    Close();
                }
                else
                    MessageBox.Show("Falha ao Fechar o Caixa");
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FechamentoCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
