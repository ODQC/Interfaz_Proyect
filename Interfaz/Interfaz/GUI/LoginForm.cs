﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contraseñaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoardForm fmn = new DashBoardForm();
            fmn.Show();

        }
    }
}
