using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // prueba comentario
            string a;
            a = "hola";
            Console.WriteLine("ADIOS MUN");
        
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
    }
}
