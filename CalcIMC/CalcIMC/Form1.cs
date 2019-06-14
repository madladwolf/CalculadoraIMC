using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_calcular.Enabled = false;
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                string altura = txt_altura.Text.Replace(',', '.');
                string peso = txt_peso.Text.Replace(',', '.');
                double pesoDouble = double.Parse(peso);
                double alturaDouble = double.Parse(altura);
                double resultado = pesoDouble / Math.Pow(alturaDouble, 2);
                lbl_resultado.Text = resultado.ToString();
            }
            catch
            {
                lbl_resultado.Text = "!!Insira Apenas Numeros!!";
            }
            
        }

        private void Txt_altura_TextChanged(object sender, EventArgs e)
        {
            btn_calcular.Enabled = !String.IsNullOrEmpty(txt_altura.Text) && !String.IsNullOrEmpty(txt_peso.Text);
        }

        private void Txt_peso_TextChanged(object sender, EventArgs e)
        {
            btn_calcular.Enabled = !String.IsNullOrEmpty(txt_altura.Text) && !String.IsNullOrEmpty(txt_peso.Text);
        }
    }
}
