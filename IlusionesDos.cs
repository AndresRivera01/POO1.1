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
        Pen red = new Pen(Color.Red);
        Pen blue = new Pen(Color.Blue);
        Pen yellow = new Pen(Color.Yellow);
        Pen green = new Pen(Color.Green);
        Pen pink = new Pen(Color.Pink);
        Pen orange = new Pen(Color.Orange);
        Pen purple = new Pen(Color.Purple);
        Pen burgandy = new Pen(Color.BurlyWood);
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
            for (int i = 0; i <= w/2; i += 10)
            {
                //1stCuadrant
                e.Graphics.DrawLine(red , 0, i, i, h / 2);
                e.Graphics.DrawLine(red, i, 0, w/2, i);

                //2ndCuadrant
                e.Graphics.DrawLine(red, w - i, 0, w / 2, i);
                e.Graphics.DrawLine(red, w, i, w - i , h/2);

                //3rdCuadrant
                e.Graphics.DrawLine(red, 0 , h / 2 + i, w/2 - i, h/2 );
                e.Graphics.DrawLine(red, i, h , w / 2 , h - i);

                //4thCuadrant
                e.Graphics.DrawLine(red, w/2 , h/2 + i , w / 2 + i, h);
                e.Graphics.DrawLine(red, w , h/2 + i, w / 2 + i, h / 2);









            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
            {

            }
    }
}
