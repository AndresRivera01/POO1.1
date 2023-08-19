using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramacionOrientadaObjetos
{
    public partial class Form_Operaciones : Form
    {
        public Form_Operaciones()
        {
            InitializeComponent();
        }

        private void Form_Operaciones_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);

                float suma = num1 + num2;
                float resta = num1 - num2;
                float multiplicacion = num1 * num2;
                float division = num1 / num2;


                label4.Text = num1 + " + " + num2 + " = " + suma + "\n";
                label4.Text += num1 + " - " + num2 + " = " + resta + "\n";
                label4.Text += num1 + " x " + num2 + " = " + multiplicacion + "\n";
                label4.Text += num1 + " / " + num2 + " = " + division + "\n";


            }
            catch 
            { 

            }
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
