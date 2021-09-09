using SistemaPadoca.Forms_Iniciais;
using System;
using System.CodeDom.Compiler;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            string User, Password;
            User = txtUsername.Text;
            Password = txtPassword.Text;                      
            Funcionario_Padaria login = new Funcionario_Padaria();
            login.LoginFuncionarios(User, Password);
           
            if (login.Cadastrado)
            {                           
                Inicio inicio = new Inicio();
                this.Visible = false;
                SESSION.IdUser = Convert.ToInt32(con.IdFun(User, Password));
                SESSION.UserName = con.NomeFun(User, Password);
                SESSION.SenhaGerente = con.SenhaGerente();          
                SESSION.NivelUser = con.Nivel(SESSION.IdUser);              
                inicio.ShowDialog();                         
            }
            else
            {
                MessageBox.Show("Falha no login");
                ZerarCampos();
            }
            ZerarCampos();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            ZerarCampos();


        }

        private void ZerarCampos()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
