﻿using System;
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
    public partial class Form_Encuesta : Form
    {
        public Form_Encuesta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Encuesta_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procesando Encuesta");
            richTextBox1.Text = "Bienvenido " + textBox1.Text + " " +
                textBox2.Text + " " + textBox3.Text + "\n Fecha De Nacimiento" + " " + dateTimePicker1.Text;

        }
    }
}
