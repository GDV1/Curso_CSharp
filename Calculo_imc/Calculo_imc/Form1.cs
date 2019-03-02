using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            txtImc.Text = imc.ToString("0.00");


            if(imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do peso ideal", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           else if(imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com o peso dentro da normalidade", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           else if(imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do peso ideal", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           else if(imc <34.99)
                MessageBox.Show("ATENÇÃO: Você está com obesidade Grau I", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           else if(imc < 39.99)
                MessageBox.Show("SITUAÇÃO: Você está com obesidade Grau II (Severa)", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("SITUAÇÃO: Você está com obesidade Grau III (Mórbida", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtImc.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
