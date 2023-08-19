using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaObjetos
{
    public partial class Form_Triangulos : Form
    {
        public Form_Triangulos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }   

        private void Form_Triangulos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try 
            {
                float lado1 = float.Parse(textBox1.Text);
                float lado2 = float.Parse(textBox2.Text);
                float lado3 = float.Parse(textBox3.Text);

              
                if (lado1 > 0 && lado2 > 0 && lado3 > 0)
                {
                    float mayor = lado1;

                    if (mayor < lado2) mayor = lado2;

                    if (mayor < lado3) mayor = lado3;

                    if (mayor <= (lado1 + lado2 + lado3 - mayor))

                    {
                        //MessageBox.Show("Con estas medidass SI es posible hacer un triangulo");

                        if (lado1 == lado2 && lado1 == lado3)
                        {
                            //MessageBox.Show("Es un Triangulo Equilatero");
                            label5.Text = "Es un Triangulo Equilatero";
                        }

                        else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)

                        {
                            //MessageBox.Show("Es un Triangulo Escaleno");
                            label5.Text = "Es un Triangulo Escaleno";
                        }
                        else
                        {
                            //MessageBox.Show("Es un Triangulo Isoceles");
                            label5.Text = "Es un Triangulo Isoceles";
                        }


                    }
                    else
                    {
             
                        label5.Text = "Con estas medidas NO es posible formar un triangulo";
                    }
                }
                else {
                    label5.Text = "Con estas medidas NO es posible formar un triangulo";
                }
                
            } catch(Exception Error) {
                MessageBox.Show("Error","Errorsito", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
