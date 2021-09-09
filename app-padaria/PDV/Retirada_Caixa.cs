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
    public partial class Retirada_Caixa : Form
    {
        public Retirada_Caixa()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Retirada_Caixa_Load(object sender, EventArgs e)
        {
            string nomeFuncionario = SESSION.UserName;
            int turnoFuncionario = SESSION.TurnoUser;
            txtNomeUser.Text = nomeFuncionario;
            txtTurno.Text = Convert.ToString(turnoFuncionario);
        }

        private void Retirada_Caixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
            if(e.KeyChar == 116)
            {
                btnSalvar.PerformClick();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            decimal valor = npdValor.Value;
            if (valor > 0)
            {
                SESSION.ValorTotalDia = SESSION.ValorTotalDia - valor;
                SESSION.ValorRetiradaDia += valor;
            }
            else
                MessageBox.Show("Valor Invalido");



        }
    }
}
