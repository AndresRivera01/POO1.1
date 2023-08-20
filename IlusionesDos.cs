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
    public partial class IlusionesDos : Form
    {
        Pen[] colores = {
         red = new Pen(Color.Red) ,
         new Pen(Color.Blue),
         new Pen(Color.Yellow),
         new Pen(Color.Green),
         new Pen(Color.Pink),
         new Pen(Color.Orange),
         new Pen(Color.Purple),
         new Pen(Color.BurlyWood) };
        private static Pen red;

        public IlusionesDos()
        {
            InitializeComponent();
        }

        private void IlusionesDos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Trebol
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            for (int i = 0; i <= w / 2; i += 10)
            {
                //1stCuadrant
                e.Graphics.DrawLine(red, 0, i, i, h / 2);
                e.Graphics.DrawLine(red, i, 0, w / 2, i);

                //2ndCuadrant
                e.Graphics.DrawLine(red, w - i, 0, w / 2, i);
                e.Graphics.DrawLine(red, w, i, w - i, h / 2);

                //3rdCuadrant
                e.Graphics.DrawLine(red, 0, h / 2 + i, w / 2 - i, h / 2);
                e.Graphics.DrawLine(red, i, h, w / 2, h - i);

                //4thCuadrant
                e.Graphics.DrawLine(red, w / 2, h / 2 + i, w / 2 + i, h);
                e.Graphics.DrawLine(red, w, h / 2 + i, w / 2 + i, h / 2);









            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox6.Width;
            int h = pictureBox6.Height;
            for (int i = 0; i <= w / 2; i += 10)
                e.Graphics.DrawEllipse(colores[0], i, i, w / 2, h / 2);

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox4.Width;
            int h = pictureBox4.Height;
            for (int i = 0; i < w - 20; i += 10)


                e.Graphics.DrawEllipse(colores[0], ((w - i) / 2), ((h - i) / 2), i, i);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {

            int w = pictureBox3.Width;
            int h = pictureBox3.Height;

            for (int i = 0; i < w; i += 10)
            {
                e.Graphics.DrawLine(colores[0], w / 2, i, i, h - i);
                e.Graphics.DrawLine(colores[0], w / 2, i, w - i, h - i);
                e.Graphics.DrawLine(colores[0], i, h - i, w - i, h - i);
            }
        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {

            int w = pictureBox7.Width;
            int h = pictureBox7.Height;

            for (int i = 0; i < w / 2; i += 10)
            {
                e.Graphics.DrawLine(colores[0], w / 2, i, i, h - i);
                e.Graphics.DrawLine(colores[0], w / 2, i, w - i, h - i);
                e.Graphics.DrawLine(colores[0], i, h - i, w - i, h - i);
            }
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox5.Width;
            int h = pictureBox5.Height;

            for (int i = 0; i <= w / 2; i += 10)
            {
                e.Graphics.DrawLine(colores[0], i, 0, w / 2, i);
                e.Graphics.DrawLine(colores[0], i, h, w / 2, h - i);
                e.Graphics.DrawLine(colores[0], w / 2 + i, 0, w / 2, h/2 - i);
                e.Graphics.DrawLine(colores[0], w / 2 , h - i, w - i, h);
                e.Graphics.DrawLine(colores[0], i, h - i, w / 2 - i, h/2 - i);
                e.Graphics.DrawLine(colores[0], w - i, h - i, w / 2 + i, h/2 - i);


            }
        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox8.Width;
            int h = pictureBox8.Height;
            for (int i = 0; i <= w / 2; i += 10)
            {
                
                e.Graphics.DrawEllipse(colores[0], i, 0, w / 2, h / 2);
                e.Graphics.DrawEllipse(colores[0], 0, i, w / 2, h / 2);
      


            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox2.Width;
            int h = pictureBox2.Height;
            for (int i = 0; i <= w/2 ; i += 10)
            {

               
                e.Graphics.DrawRectangle(colores[0], i, 0, w , h );
                e.Graphics.DrawRectangle(colores[0], i, 0, w/2, h);




            }

        }
    }
}

        
    


