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
    public partial class Cad_Novo_Cliente : Form
    {
        public Cad_Novo_Cliente()
        {
            InitializeComponent();
        }

        int Situacao = 0;
        int listagem = 0;

        //recebendo as informaçoes passadas pelo double click no outro formulario (Cad_Cliente)
        public Cad_Novo_Cliente(int Cod, string CPF, string Nome, string Bairro, string Rua, string NmrResidencia, string TelFixo, string TelCel, int situacao, int Limite)
        {
            InitializeComponent();
            //campos de texto recebendo as informaçoes passadas
            txtCodCliente.Text = Convert.ToString(Cod);
            txtCpfCliente.Text = CPF;
            txtNomeCliente.Text = Nome;
            txtBairroCliente.Text = Bairro;
            txtRuaCliente.Text = Rua;
            txtNumeroCliente.Text = NmrResidencia;
            txtTelFixo.Text = TelFixo;
            txtTelCel.Text = TelCel;
            npdLimiteCliente.Value = Convert.ToInt32(Limite);
            Situacao = situacao;
        }

        //funçao responsavel remover as mascaras 
        private static string ItemFormatadoString(string Item)
        {
            return Item.Replace(".", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Replace(",", string.Empty);
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSairNovoCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        //botao responsavel por realizar o cadastro
        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            string NomeCliente, CpfCliente, Bairro, Rua, Numero, Telfixo, Telcel;
            int Limite = 0, Cod;
            ValidarCampos();

            if (listagem == 8)
            {
                //pegando os valores dos campos
                NomeCliente = txtNomeCliente.Text;
                CpfCliente = ItemFormatadoString(txtCpfCliente.Text);
                Bairro = txtBairroCliente.Text;
                Rua = txtRuaCliente.Text;
                Numero = txtNumeroCliente.Text;
                Telfixo = ItemFormatadoString(txtTelFixo.Text);
                Telcel = ItemFormatadoString(txtTelCel.Text);
                Limite = Convert.ToInt32(npdLimiteCliente.Value);

                //if responsavel diferenciar novos cadastros de atualizaçoes 
                if (txtCodCliente.Text == "")
                {
                    //instanciando metodo de cadastro
                    Cliente_Padaria cliente = new Cliente_Padaria(CpfCliente, NomeCliente, Bairro, Rua, Numero, Telfixo, Telcel, Situacao, Limite);
                    //por se tratar de uma funçao que retorna true ou false faz se a verificaçao para saber se o cadastro foi realizado com sucesso 
                    if (cliente.Add_Cliente())
                    {
                        MessageBox.Show("Sucesso Cadastrar");
                        ResetCampos();
                    }
                    else
                        MessageBox.Show("Erro Cadastrar");
                }
                //caso nao for cadastro novo é uma alteraçao
                else
                {
                    Cod = int.Parse(txtCodCliente.Text);
                    Cliente_Padaria cliente = new Cliente_Padaria(Cod, CpfCliente, NomeCliente, Bairro, Rua, Numero, Telfixo, Telcel, Situacao, Limite);
                    if (cliente.AttCliente())
                    {
                        MessageBox.Show("Sucesso Alterar");
                    }
                    else
                        MessageBox.Show("Erro ao Alterar");
                }
            }
            else
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos!");
                listagem = 0;
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
                        (control as ComboBox).SelectedIndex = 0;
                    else if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(gpbInfoCli.Controls);
        }

        public void ValidarCampos()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox || control is MaskedTextBox || control is NumericUpDown)
                    {
                        if (!String.IsNullOrWhiteSpace(control.Text))
                            listagem++;
                    }
                    else
                        func(control.Controls);
            };
            func(gpbInfoCli.Controls);
        }

        private void txtNumeroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
