﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_IV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            using (conexionDB conexion = new conexionDB())
            {
                conexion.conectar();
                if (conexion.getSocket().State == ConnectionState.Open)
                {
                    MessageBox.Show("conexion abierta");

                }
                else
                {


                }
            }
        }
    }
}
