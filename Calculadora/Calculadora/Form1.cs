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

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Hola mundo!!
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            try
            {
                txtresultado.Text = Convert.ToString(Add(Convert.ToDouble(txtnum1.Text, provider), Convert.ToDouble(txtnum2.Text, provider)));
            }
            catch (Exception)
            {

                MessageBox.Show("Unicamente se aceptan numeros");
            }
        }

        public static String createMessage()
        {

            int a = 10;
            int b = 10;
            int c = a + b;
            Console.WriteLine(c);
            return "ADIOS MUN";
        }

        public static String PruebaSuma()
        {
            return "HOLA";
        }

        public static String PruebaResta()
        {
            return "MUNDO";
        }

        public static Double Add(Double a, Double b){
            return a + b;
        }
        
        public static Double Resta(Double a, Double b){
            return a - b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        public static Double Division(Double a, Double b)
        {
            return a / b;
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            try
            {
                txtresultado.Text = Convert.ToString(Resta(Convert.ToDouble(txtnum1.Text, provider), Convert.ToDouble(txtnum2.Text, provider)));
            }
            catch (Exception)
            {

                MessageBox.Show("Unicamente se aceptan numeros");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;

            try
            {
                a = Double.Parse(txtnum1.Text.ToString());
                b = Double.Parse(txtnum2.Text.ToString());

                txtresultado.Text = multiplicacion(a, b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Uno de los valores ingresados no es válido");
            }


            
        }

        public static double multiplicacion(double a, double b)
        {
            return a * b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            try
            {
                txtresultado.Text = Convert.ToString(Resta(Convert.ToDouble(txtnum1.Text, provider), Convert.ToDouble(txtnum2.Text, provider)));
            }
            catch (Exception)
            {

                MessageBox.Show("Unicamente se aceptan numeros"); 
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            try
            {
                txtresultado.Text = Convert.ToString(Division(Convert.ToDouble(txtnum1.Text, provider), Convert.ToDouble(txtnum2.Text, provider)));
            }
            catch (Exception)
            {

                MessageBox.Show("Unicamente se aceptan numeros");
            }
        }
    }
}
