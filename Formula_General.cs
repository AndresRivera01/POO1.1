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
    public partial class Formula_General : Form
    {
        public Formula_General()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formula_General_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {

                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);

                float x1 = (float)((-b + (Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))) / (2 * a));
                float x2 = (float)((-b - (Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))) / (2 * a));

                label4.Text = ("X1= " + x1);
                label5.Text = ("X2= " + x2);

            }
            catch  (Exception ex)
            {
                MessageBox.Show("Algunos de los datos no son validos");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
