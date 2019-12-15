using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaz.GUI;

namespace Interfaz
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm fmn = new LoginForm();
                fmn.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CuentasXCobrar fmn = new CuentasXCobrar();
            fmn.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CedulaForm fmn = new CedulaForm();
            fmn.Show();
        }

        private void login1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CuentasXCobrar fmn = new CuentasXCobrar();
            fmn.Show();
        }

        private void alarmBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoUser fmn = new InfoUser();
            fmn.Show();
        }

        private void alarmaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           ConfigAlarm fmn = new ConfigAlarm();
            fmn.Show();
        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoUser fmn = new InfoUser();
            fmn.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfigAlarm fmn = new ConfigAlarm();
            fmn.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CedulaForm fmn = new CedulaForm();
            fmn.Show();
        }
    }
}
