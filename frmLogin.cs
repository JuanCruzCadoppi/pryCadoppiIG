using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCadoppiIG
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "CadoppiJuan" && txtClave.Text == "12345")
            {
                MessageBox.Show("Ingreso exitoso!!","Bienvenido al sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                lblIncorrecto.Text = "❌Usuario o contraseña \n incorrectos";
            }
        }
    }
}
