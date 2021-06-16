using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            var lista = Cliente.ListarTodos();
            Cliente cliente = new Cliente("Zé","123","@sze","456",true);
           
            cliente.Endereco = new Endereco();
            cliente.Endereco.Logradouro = "Av Itaquera";
        }
    }
}
