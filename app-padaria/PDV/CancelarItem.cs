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
    public partial class CancelarItem : Form
    {
        public CancelarItem()
        {
            InitializeComponent();
        }
        string valor;
        public int ValorApagar()
        {                                   
            int apagar = Convert.ToInt32(valor);
            return apagar;
          
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtApagar.Text))
            {
                lblaviso.Text = "";
                valor = txtApagar.Text;
                ValorApagar();
                Close();
            }
            else
            {
                lblaviso.Text = "* Insira um valor!";
            }
        }

        private void CancelarItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }

        }
    }
}
