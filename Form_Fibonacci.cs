using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaObjetos
{
    public partial class Form_Fibonacci : Form
    {
        public Form_Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                int limite = Convert.ToInt32(textBox1.Text);
                if (limite < 0)

                    MessageBox.Show("Se ingreso un numero negativo");

                int a = 0, b = 1, c = 0;
                
                richTextBox1.Clear();
                for (; c <= limite;) 
                {
                    c = a + b;

                    if (c <= limite)
                    richTextBox1.Text += a + " + " + b + " = " + c +  "\n";

                    a = b;
                    b = c;
                
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Se ingreso un nu valor invalido");
            }

        }

        private void Form_Fibonacci_Load(object sender, EventArgs e)
        {

        }
    }
}
