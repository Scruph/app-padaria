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

namespace SistemaPadoca
{
    public partial class BuscaRelatorio : Form
    {
        public BuscaRelatorio()
        {
            InitializeComponent();
        }
        int codigo = 0;

        private void btnSairBusca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime DiaInicio = dtpDe.Value;
            DateTime DiaTermino = dtpAte.Value;

            FecharCaixa consulta = new FecharCaixa();
            dgvConsulta.DataSource =  consulta.ConsultaRelatorio(DiaInicio,DiaTermino);
                      

        }
    }
}
