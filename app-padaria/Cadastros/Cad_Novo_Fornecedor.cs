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
    public partial class Cad_Novo_Fornecedor : Form
    {
        public Cad_Novo_Fornecedor()
        {
            InitializeComponent();
        }
        int listagem = 0;
        public Cad_Novo_Fornecedor(int id ,string nomefornec,string nomevende,string telemp,string telcel)
        {
            InitializeComponent();
            txtCodFornec.Text = Convert.ToString(id);
            txtNomeFornec.Text = nomefornec;
            txtNomeVendeFornc.Text = nomevende;
            txtTelEmpFornec.Text = telemp;
            txtTelCelFornec.Text = telcel;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSairNovoFornec_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ResetForm()
        {
            txtNomeVendeFornc.Text = "";
            txtNomeFornec.Text = "";
            txtTelCelFornec.Text = "";
            txtTelEmpFornec.Text = "";
        }

        private static string ItemFormatadoString(string Item)
        {
            return Item.Replace(".", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Replace(",", string.Empty);
        }

        private void btnSalvarFornec_Click(object sender, EventArgs e)
        {
            string nomevende, nomefornec, telcel, telemp;
            ValidarCampos();

            if (listagem == 4)
            {
                nomevende = txtNomeVendeFornc.Text;
                nomefornec = txtNomeFornec.Text;
                telcel = ItemFormatadoString(txtTelCelFornec.Text);
                telemp = ItemFormatadoString(txtTelEmpFornec.Text);

                if (txtCodFornec.Text == "")
                {
                    Fornecedores fornec = new Fornecedores(nomefornec, nomevende, telemp, telcel);
                    if (fornec.Add_Fornecedores())
                    {
                        MessageBox.Show("Sucesso ao Cadastrar!");
                        ResetForm();
                    }
                    else
                        MessageBox.Show("Falha ao Cadastrar");
                }
                else if (txtCodFornec.Text != "")
                {
                    int codigo = int.Parse(txtCodFornec.Text);
                    Fornecedores fornec = new Fornecedores(codigo, nomefornec, nomevende, telemp, telcel);
                    if (fornec.AttFornec())
                    {
                        MessageBox.Show("Sucesso ao Cadastrar!");
                        ResetForm();
                    }
                    else
                        MessageBox.Show("Falha ao Cadastrar");
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
            func(gpCadFornecedor.Controls);
        }
        public void ValidarCampos()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox || control is MaskedTextBox)
                    {
                        if (!String.IsNullOrWhiteSpace(control.Text))
                            listagem++;
                    }
                    else
                        func(control.Controls);
            };
            func(gpCadFornecedor.Controls);
        }
    }
}
