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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void practicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void practica1TriangulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Triangulos().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void practica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Operaciones().ShowDialog();
        }

        private void practica3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formula_General().ShowDialog();
        }

        private void practica4FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Fibonacci().ShowDialog();
        }

        private void practica5IlusionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IlusionesDos().ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Form_Catalogo().ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form_Encuesta().ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Form_Ilusiones().ShowDialog();  
        }
    }
}
