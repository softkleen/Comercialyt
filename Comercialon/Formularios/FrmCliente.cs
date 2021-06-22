using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercialon.Classes;

namespace Comercialon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnInserir_Click(object sender, EventArgs e)
        {   
                        
            // essa linha a seguir remove pontos e traços do cpf
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Cliente cliente = new Cliente(
              txtNome.Text,
              mskCpf.Text,
              txtEmail.Text,
              txtTelefone.Text
          );
            cliente.Inserir();
            Endereco endereco = new Endereco
                (txtLogradouro.Text, txtNumero.Text, txtComplemento.Text
                ,txtCep.Text, txtBairro.Text,txtCidade.Text,cmbTipo.Text,
                txtEstado.Text,txtUf.Text );
            endereco.Inserir(cliente.Id);
            MessageBox.Show("Cliente " + cliente.Id + " inserido.");
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (rg.IsMatch(email)) 
            {
                btnInserir.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
                txtEmail.Focus();
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text.Length==8)
            {
                var cep = Cep.Obter(txtCep.Text);
                txtBairro.Text = cep.Bairro;
                txtCidade.Text = cep.Localidade;
                txtLogradouro.Text = cep.Logradouro;
                txtUf.Text = cep.Uf;
            }
        }
    }
}
