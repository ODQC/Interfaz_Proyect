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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contraseñaTxtTextChanged(object sender, EventArgs e)
        {

        }

        private void usuarioTxtTextChanged(object sender, EventArgs e)
        {

        }


        private void BorrarUsuario(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                usuarioTxt.Text = "";
            }
        }

        private void BorrarContraseña(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                contraseñaTxt.Text = "";
            }
        }

        private bool ValidarUsuario()
        {
            bool status = true;

            if (usuarioTxt.Text == "")
            {
                status = false;
                errorProvider1.SetError(usuarioTxt, "Ingrese su usuario");
            }
            return status;
        }

        private bool ValidarContrasena()
        {
            bool status = true;

            if (contraseñaTxt.Text == "")
            {
                status = false;
                errorProvider1.SetError(contraseñaTxt, "Ingrese su contraseña");
            }
            return status;
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
            ValidarContrasena();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            usuarioTxt.Text = "";
            contraseñaTxt.Text = "";
        }
    }
 }
