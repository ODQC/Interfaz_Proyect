﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.GUI
{
    public partial class CedulaForm : Form
    {
        public CedulaForm()
        {
            InitializeComponent();
        }

        private void CedulaForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.Hide();
          DashBoardForm fmn = new DashBoardForm();
          fmn.Show();

        }
    }
}