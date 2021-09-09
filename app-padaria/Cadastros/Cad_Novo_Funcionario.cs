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
    public partial class Cad_Novo_Funcionario : Form
    {
        public Cad_Novo_Funcionario()
        {
            InitializeComponent();
        }
        public Cad_Novo_Funcionario(int Codigo,int NivelUsuario, string Username,string Password,string CPFFuncionario, string NomeFuncionario, string BairroFuncionario, string RuaFuncionario, string NmrResidenciaFuncionario, string TelFixoFuncionario, string TelCelFuncionario)
        {
            InitializeComponent();
            txtCod.Text = Convert.ToString(Codigo);         
            mtxtCPF.Text = CPFFuncionario;
            txtNome.Text = NomeFuncionario;
            txtBairro.Text = BairroFuncionario;
            txtRua.Text = RuaFuncionario;
            txtNrm.Text = NmrResidenciaFuncionario;
            mtxtTelFixo.Text = TelFixoFuncionario;
            mtxtTelCel.Text = TelCelFuncionario;
            cbNivelUsuario.SelectedIndex = NivelUsuario;
            txtUsername.Text = Username;
            txtSenha.Text = Password;
        }
        private static string ItemFormatadoString(string Item)
        {
            return Item.Replace(".", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Replace(",", string.Empty);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSairNovoFunc_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            //Declarando Variaveis
            string Username,Password,CPF, Nome, Bairro, Rua, Numero, TelFixo, TelCel,ConfirmarSenha;
            int Nivel_Usuario;

            //Atribuindo valores a variaveis

            CPF = ItemFormatadoString(mtxtCPF.Text);
            Nome = txtNome.Text;
            Bairro = txtBairro.Text;
            Rua = txtRua.Text;
            Numero = txtNrm.Text;
            TelFixo = ItemFormatadoString(mtxtTelFixo.Text);    
            TelCel = ItemFormatadoString(mtxtTelCel.Text);          
            Username = txtUsername.Text;
            Password = txtSenha.Text;
            ConfirmarSenha = txtConfirmPass.Text;
            Nivel_Usuario = cbNivelUsuario.SelectedIndex;

            if ((txtCod.Text == "")&& Password == ConfirmarSenha)
            {
                Funcionario_Padaria funcionario = new Funcionario_Padaria(Nivel_Usuario,Username,Password,CPF, Nome, Bairro, Rua, Numero, TelFixo, TelCel);                    
                Permissoes permi = new Permissoes(Nivel_Usuario);

                if (funcionario.Add_Funcionarios())
                {
                    MessageBox.Show("Sucesso");
                    ResetCampos();
                }
                else
                    MessageBox.Show("Nao deu");
                
            }
            else if(Password != ConfirmarSenha)
            {
                MessageBox.Show("Senhas Incompativeis, Verifique-as");
            }
            else
            {
                int codigo = int.Parse(txtCod.Text);
                Funcionario_Padaria funcionario = new Funcionario_Padaria(codigo, Nivel_Usuario,Username,Password,CPF, Nome, Bairro, Rua, Numero, TelFixo, TelCel);
                if (funcionario.AttFuncionarios())
                    MessageBox.Show("Sucesso");
                else
                    MessageBox.Show("SSSSSS Não Deu");                                 
            }
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            ResetCampos();
        }

        public void ResetCampos()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(gpbInfo.Controls);
            func(gpbCadLogin.Controls);
        }

        private void txtNrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
