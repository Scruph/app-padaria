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
    public partial class Inicio_PDV : Form
    {
        public Inicio_PDV()
        {
            InitializeComponent();
        }

        private void btnIniciarPdv_Click(object sender, EventArgs e)
        {
            int listagem = 0;

            if (cbTurno.SelectedIndex >= 0)
            {
                listagem++;
                lblalerta.Text = "";
            }
            else
            {
                lblalerta.Text = "* Campo Obrigatório";
            }

            if(listagem == 1)
            {
                int turno = cbTurno.SelectedIndex;
                turno += 1;
                SESSION.TurnoUser = turno;             
                PDV Pdv = new PDV();
                Pdv.ShowDialog();
                Close();
                
            }
           
        }

        private void Inicio_PDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
