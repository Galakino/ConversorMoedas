using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Converte o valor digitado no TextBox para um número inteiro
                double i = double.Parse(txbNumConvert.Text);

                // Verifica qual moeda foi selecionada no combo1 e combo2 e realiza a conversão
                if (combo1.SelectedItem.ToString() == "Real" && combo2.SelectedItem.ToString() == "Dolar")
                {
                    double result = i / 5; // Supondo que 1 Dólar = 5 Reais
                    lblConvertido.Text = "Valor convertido: $" + result.ToString("N2");
                }
                else if (combo1.SelectedItem.ToString() == "Real" && combo2.SelectedItem.ToString() == "Euro")
                {
                    double result = i / 5.5; // Supondo que 1 Euro = 5.5 Reais
                    lblConvertido.Text = "Valor convertido: €" + result.ToString("N2");
                }
                else if (combo1.SelectedItem.ToString() == "Real" && combo2.SelectedItem.ToString() == "Pesos Argentinos")
                {
                    double result = i * 70; // Supondo que 1 Real = 70 Pesos Argentinos
                    lblConvertido.Text = "Valor convertido: $" + result.ToString("N2") + " ARS";
                }
                else if (combo1.SelectedItem.ToString() == "Dolar" && combo2.SelectedItem.ToString() == "Real")
                {
                    double result = i * 5; // Supondo que 1 Dólar = 5 Reais
                    lblConvertido.Text = "Valor convertido: R$" + result.ToString("N2");
                }
                else if (combo1.SelectedItem.ToString() == "Dolar" && combo2.SelectedItem.ToString() == "Euro")
                {
                    double result = i * 0.91; // Supondo que 1 Dólar = 0.91 Euros
                    lblConvertido.Text = "Valor convertido: €" + result.ToString("N2");
                }
                else if (combo1.SelectedItem.ToString() == "Dolar" && combo2.SelectedItem.ToString() == "Pesos Argentinos")
                {
                    double result = i * 350; // Supondo que 1 Dólar = 350 Pesos Argentinos
                    lblConvertido.Text = "Valor convertido: $" + result.ToString("N2") + " ARS";
                }
                else if (combo1.SelectedItem.ToString() == "Euro" && combo2.SelectedItem.ToString() == "Real")
                {
                    double result = i * 5.5; // Supondo que 1 Euro = 5.5 Reais
                    lblConvertido.Text = "Valor convertido: R$" + result.ToString("N2");
                }
                else if (combo1.SelectedItem.ToString() == "Euro" && combo2.SelectedItem.ToString() == "Dolar")
                {
                    double result = i / 0.91; // Supondo que 1 Euro = 1.1 Dólares
                    lblConvertido.Text = "Valor convertido: $" + result.ToString("N2");
                }
                else if (combo1.SelectedItem.ToString() == "Euro" && combo2.SelectedItem.ToString() == "Pesos Argentinos")
                {
                    double result = i * 385; // Supondo que 1 Euro = 385 Pesos Argentinos
                    lblConvertido.Text = "Valor convertido: $" + result.ToString("N2") + " ARS";
                }
                else if (combo1.SelectedItem.ToString() == "Pesos Argentinos" && combo2.SelectedItem.ToString() == "Real")
                {
                    double result = i / 70; // Supondo que 70 Pesos Argentinos = 1 Real
                    lblConvertido.Text = "Valor convertido: R$" + result.ToString("N2");
                }
                else if (combo1.SelectedItem.ToString() == "Pesos Argentinos" && combo2.SelectedItem.ToString() == "Euro")
                {
                    double result = i / 385; // Supondo que 385 Pesos Argentinos = 1 Euro
                    lblConvertido.Text = "Valor convertido: €" + result.ToString("N2");
                }
                else if (combo1.SelectedItem.ToString() == "Pesos Argentinos" && combo2.SelectedItem.ToString() == "Dolar")
                {
                    double result = i / 350; // Supondo que 350 Pesos Argentinos = 1 Dólar
                    lblConvertido.Text = "Valor convertido: $" + result.ToString("N2");
                }
                else
                {
                    lblConvertido.Text = "Selecione uma conversão válida.";
                }
            }
            catch (FormatException)
            {
                lblConvertido.Text = "Por favor, insira um número válido.";
            }
        }
    }
}
