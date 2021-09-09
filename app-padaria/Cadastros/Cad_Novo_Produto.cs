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
    public partial class Cad_Novo_Produto : Form
    {
        public Cad_Novo_Produto()
        {
            InitializeComponent();
        }
        int listagem = 0;
        int fornecedoresprod=0;
        public Cad_Novo_Produto(int codigo,int fornecedores,decimal preco,string nome,string tipo,string unidade,string barcode,string estoque,DateTime data)
        {
            InitializeComponent();
            TxtCodigoProd.Text = Convert.ToString(codigo);
            CbFornec.SelectedItem = fornecedores;
            nudpreco_prod.Value = preco;
            txtnome_prod.Text = nome;
            cbtipo_prod.SelectedItem = tipo;
            cbunidade_prod.SelectedIndex = Convert.ToInt16(unidade);
            txtbarcode_prod.Text = barcode;
            txtestoque_prod.Text = estoque;
            dt_prod.Value = data;
            fornecedoresprod = fornecedores;
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cad_Novo_Produto_Load(object sender, EventArgs e)
        {          
            Fornecedores forec = new Fornecedores();
            DataTable dados = forec.ConsultaFornecedores();
            CbFornec.DataSource = dados;
            CbFornec.DisplayMember = "Nome_Fornecedores";
            CbFornec.ValueMember = "Id_Fornecedores";
            dt_prod.Enabled = false;
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            string nome, tipo,barcode;
            int estoque, Unidade,Id_Fornec;
            decimal preco;
            DateTime data;                            
            ValidarCampos();

            if (listagem == 7)
            {
                nome = txtnome_prod.Text;
                barcode = txtbarcode_prod.Text;
                tipo = Convert.ToString(cbtipo_prod.SelectedItem);
                estoque = Convert.ToInt32(txtestoque_prod.Text);
                preco = Convert.ToInt32(nudpreco_prod.Value);
                Unidade = cbunidade_prod.SelectedIndex;
                Id_Fornec = Convert.ToInt16(CbFornec.SelectedValue);
                data = dt_prod.Value;

                if (TxtCodigoProd.Text == "")
                {
                    Produtos produto = new Produtos(Id_Fornec, preco, nome, tipo, Unidade, barcode, estoque, data);
                    if (produto.Add_Produtos())
                    {
                        MessageBox.Show("Sucesso ao Cadastrar");
                        ResetCampos();
                        
                    }
                    else
                        MessageBox.Show("Falha ao Cadastrar");
                }
                else
                {
                    int codigo = int.Parse(TxtCodigoProd.Text);
                    Produtos cadprod = new Produtos(codigo, fornecedoresprod, preco, nome, tipo, Unidade, barcode, estoque, data);
                    if (cadprod.AttProduto())
                    {
                        MessageBox.Show("Sucesso ao Alterar");
                        Close();
                    }
                    else
                        MessageBox.Show("Falha ao Alterar");
                }
            }
            else
            {
                MessageBox.Show("Todos os campos precisam ser Preenchidos");
                listagem = 0;
            }
        }

        private void btnSairNovoProd_Click(object sender, EventArgs e)
        {
            Close();
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
            func(gpDadosProduto.Controls);         
        }

        public void ValidarCampos()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox || control is ComboBox || control is MaskedTextBox || control is NumericUpDown)
                    {
                        if (!String.IsNullOrWhiteSpace(control.Text))
                            listagem++;
                    }
                    else
                        func(control.Controls);
            };           
            func(gpDadosProduto.Controls);
        }

        private void txtbarcode_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtestoque_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }

}
