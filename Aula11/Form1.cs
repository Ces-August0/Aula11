using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }
        Funcionario f = new Funcionario();
        private void button1_Click(object sender, EventArgs e)
        {
            f.Nome = txtNome.Text;
            f.Salario = double.Parse(txtSalario.Text);
            txtvalor.Text = "Valor das férias = " +
                f.Calcular(int.Parse(txtTempo.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.Nome = txtNome.Text;
            f.Salario = double.Parse(txtSalario.Text);
            txtvalor.Text = "Valor das INSS = " +
                f.Calcular().ToString();
        }

        private void btncomissao_Click(object sender, EventArgs e)
        {
            Vendedor v = new Vendedor();
            v.Nome = txtNome.Text;
            v.Salario = double.Parse(txtSalario.Text);
            txtvalor.Text = "Valor da comissãoo =" +
                v.Calcular(6).ToString();
        }
    }
}
