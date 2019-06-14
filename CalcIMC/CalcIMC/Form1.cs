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
        if(resultado < 16)
        {
            lbl_resultado.Text = resultado.ToString() + " - " + "Baixo peso, Muito grave";
        }else if(resultado > 16 && resultado < 16.99){
            lbl_resultado.Text = resultado.ToString() + " - " + "Baixo peso, Grave";
        }else if(resultado >17 && resultado < 18.49){
            lbl_resultado.Text = resultado.ToString() + " - " + "Baixo peso";
        }else if(resultado > 18.5 && resultado < 24.99){
            lbl_resultado.Text = resultado.ToString() + " - " + "Peso Normal";
        }else if(resultado > 25 && resultado < 29.99){
            lbl_resultado.Text = resultado.ToString() + " - " + "Sobrepeso";
        }else if(resultado > 30 && resultado < 34.99){
            lbl_resultado.Text = resultado.ToString() + " - " + "Obesidade grau I";
        }else if(resultado > 35 && resultado < 39.99){
            lbl_resultado.Text = resultado.ToString() + " - " + "Obesidade grau II";
        }else{
            lbl_resultado.Text = resultado.ToString() + " - " +"Obesidade grau III";
        }
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
