using System;
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

        public bool ValidarUsuario()
        {
            bool status = true;

            if (usuarioTxt.Text == "")
            {
                status = false;
                LoginErrorProvider1.SetError(usuarioTxt, "Ingrese su usuario");
            }
            return status;
        }

        public bool ValidarContrasena()
        {
            bool status = true;

            if (contraseñaTxt.Text == "")
            {
                status = false;
                LoginErrorProvider1.SetError(contraseñaTxt, "Ingrese su contraseña");
            }
            return status;
        }

        public void AceptarBtn_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
            ValidarContrasena();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            usuarioTxt.Text = "";
            contraseñaTxt.Text = "";
   
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
            return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

     






    }
 }
