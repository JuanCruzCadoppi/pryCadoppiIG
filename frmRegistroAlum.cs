using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCadoppiIG
{
    public partial class frmRegistroAlum : Form
    {
        public frmRegistroAlum()
        {
            InitializeComponent();
        }

        private void LimpiarComponentes()
        {
            txtNom.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            optFemenino.Checked = false;
            optMasculino.Checked = false;
            chkMañana.Checked = false;
            chkNoche.Checked = false;
            chkTarde.Checked = false;
            cmbCarrera.SelectedIndex = -1;
        }
        private void frmRegistroAlum_Load(object sender, EventArgs e)
        {
            //Creamos vector con las carreras

            string[] carreras = new string[6];
            carreras[0] = "Programación";
            carreras[1] = "Ciberseguridad";
            carreras[2] = "Inteligencia Artificial";
            carreras[3] = "Administración";
            carreras[4] = "Ingenieria en Computación";
            carreras[5] = "Analista en Sistema";
            cmbCarrera.Items.Clear();

            //Iteramos el vector para mostrar las carreras guardadas

            for (int i = 0; i < 6; i++)
            {
                cmbCarrera.Items.Add(carreras[i]);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string turnoSeleccionado = "";
            string generoSeleccionado = "";

            //Evaluamos género
            if (optFemenino.Checked)
            {
                generoSeleccionado = "Femenino";
            }
            else if (optMasculino.Checked)
            {
                generoSeleccionado = "Masculino";
            }
            else
            {
                generoSeleccionado = "No seleccionado";
            }

            //Evaluamos turno
            if (chkMañana.Checked)
            {
                turnoSeleccionado = "Mañana";
            }
            else if (chkTarde.Checked)
            {
                turnoSeleccionado = "Tarde";
            }
            else if (chkNoche.Checked)
            {
                turnoSeleccionado = "Noche";
            }
            else
            {
                turnoSeleccionado = "No seleccionado";
            }

            //Cargamos el mensaje a mostrar luego de Registrar
            //En caso de no completar todos los campos salta este mensaje

            if (turnoSeleccionado == "No seleccionado" || generoSeleccionado == "No seleccionado" || txtApellido.Text == "" || txtDni.Text == "" || txtNom.Text == "" || cmbCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa las opciones antes de registrar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Si esta todo completo muestra Registro exitoso
            else
            {
                string mensaje = $"¡Registro Exitoso\n\nNombre: {txtNom.Text} \nApellido: {txtApellido.Text} \nDNI: {txtDni.Text} \nTurno: {turnoSeleccionado}\nGénero:{generoSeleccionado} \nCarrera: {cmbCarrera.Text}";
                MessageBox.Show(mensaje, "Datos Regsitrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarComponentes();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            { 

            }
        }
    }
}
