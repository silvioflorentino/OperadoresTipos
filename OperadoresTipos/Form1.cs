using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresTipos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a = 200;
            int b = 300;

            lblA.Text = "O valor de A é " + a;
            lblB.Text = "O valor de B é " + b;

            int total = a + b;

            lblResultado.Text = "A soma dos valores é: " + total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 200;
            int b = 300;

            listBoxPrincipal.Items.Add("Valor A: " + a);
            listBoxPrincipal.Items.Add("Valor B: " + b);
            listBoxPrincipal.Items.Add("Mais 30 na A " + (30 + ++a));
            listBoxPrincipal.Items.Add("Menos 1 de A " + (2 + --a));

        }

        private void btnFormatacao_Click(object sender, EventArgs e)
        {
            string produto = "Celular";
            float preco = 1290.88f;

            lblFormatacao.Text = string.Format("Produto: {0} \n Preço: {1:c}", produto, preco);
        }
    }
}
