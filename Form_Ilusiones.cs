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
    public partial class Form_Ilusiones : Form
    {
        Pen red = new Pen(Color.Red);
        Pen blue = new Pen(Color.Blue);
        Pen yellow = new Pen(Color.Yellow);
        Pen green = new Pen(Color.Green);
        Pen pink = new Pen(Color.Pink);
        Pen orange = new Pen(Color.Orange);
        Pen purple = new Pen(Color.Purple);
        Pen burgandy = new Pen(Color.BurlyWood);

        public Form_Ilusiones()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            e.Graphics.DrawLine(red, 0, 0, w, h);
            e.Graphics.DrawLine(blue, 0, h, w, 0);
            e.Graphics.DrawLine(yellow, w/2, 0, w/2, h);
            e.Graphics.DrawLine(green, 0, h/2, w, h/2);

            e.Graphics.DrawLine(pink, 0, h/2, w/2, 0);
            e.Graphics.DrawLine(orange, w/2, h, w, h/2);

            e.Graphics.DrawLine(purple, 0, h/2, w/2, h);
            e.Graphics.DrawLine(burgandy, w/2, 0 , w, h/2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, PaintEventArgs e)
        {
            

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox2.Width;
            int h = pictureBox2.Height;

            //Vertical
            for (int i = 0; i < w; i += 10)
            {
                e.Graphics.DrawLine(red, i, 0, i, w);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox3.Width;
            int h = pictureBox3.Height;

            //Horizontal
            for (int i = 0; i < w; i += 10)
            {
                e.Graphics.DrawLine(red, 0, i, w, i);

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox4.Width;
            int h = pictureBox4.Height;

            //Cuadricula
            for (int i = 0; i < w; i += 10)
            {
                e.Graphics.DrawLine(red, i, 0, i, w);
                e.Graphics.DrawLine(red, 0, i, w, i);

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox4.Width;
            int h = pictureBox4.Height;

            //Diagonal Izquierda Derecha
            for (int i = 0; i < w * 2; i += 10)
            {
               
                e.Graphics.DrawLine(red, 0, i, i, 0);

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox4.Width;
            int h = pictureBox4.Height;

            //Diagonal Derecha Izquierda
            for (int i = 0; i < w * 2; i += 10)
            {

                e.Graphics.DrawLine(red, w - i, 0, w, i);

            }
        }

        private void Form_Ilusiones_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            //Verticales a horizonte

            int w = pictureBox7.Width;
            int h = pictureBox7.Height;
            for (int i = 0; i < w; i += 10)
            {

                e.Graphics.DrawLine(red, i, 0, w / 2, h / 2);
                e.Graphics.DrawLine(red, i, h, w / 2, h / 2);
            }
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox8.Width;
            int h = pictureBox8.Height;

            for (int i = 0; i < w/2; i += 10)
            //Estrella
            {
                e.Graphics.DrawLine(red, i, h / 2, w / 2, h / 2 - i);
                e.Graphics.DrawLine(red, w - i, h / 2, w / 2, h / 2 - i);
                e.Graphics.DrawLine(red, w - i, h / 2, w / 2, h / 2  + i);
                e.Graphics.DrawLine(red, i, h / 2, w / 2, h / 2 + i);

            }

        }
    }
}


