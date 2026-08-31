using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCadoppiIG
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void frmConversor_Load(object sender, EventArgs e)
        {
            cmbDesde.Items.Clear();
            cmbDesde.Items.Add("km");
            cmbDesde.Items.Add("m");
            cmbDesde.Items.Add("cm");
            cmbDesde.Items.Add("mm");
            cmbHacia.Items.Clear();
            cmbHacia.Items.Add("km");
            cmbHacia.Items.Add("m");
            cmbHacia.Items.Add("cm");
            cmbHacia.Items.Add("mm");
        }
        private void LimpiarResultado()
        {
            lblResultado.Text = "Resultado:";

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {


            if (cmbDesde.SelectedIndex == -1 || cmbHacia.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los datos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double resultado = 0;
            double valor = double.Parse(txtValor.Text);

            if (cmbDesde.Text == "km" && cmbHacia.Text == "m")
            {
                resultado = valor * 1000;
            }
            if (cmbDesde.Text == "km" && cmbHacia.Text == "cm")
            {
                resultado = valor * 100000;
            }
            if (cmbDesde.Text == "km" && cmbHacia.Text == "mm")
            {
                resultado = valor * 1000000;
            }
            if (cmbDesde.Text == "m" && cmbHacia.Text == "km")
            {
                resultado = valor / 1000;
            }
            if (cmbDesde.Text == "m" && cmbHacia.Text == "cm")
            {
                resultado = valor * 100;
            }
            if (cmbDesde.Text == "m" && cmbHacia.Text == "mm")
            {
                resultado = valor * 1000;
            }
            if (cmbDesde.Text == "cm" && cmbHacia.Text == "km")
            {
                resultado = valor / 100000;
            }
            if (cmbDesde.Text == "cm" && cmbHacia.Text == "m")
            {
                resultado = valor / 100;
            }
            if (cmbDesde.Text == "cm" && cmbHacia.Text == "mm")
            {
                resultado = valor * 10;
            }
            if (cmbDesde.Text == "mm" && cmbHacia.Text == "km")
            {
                resultado = valor / 1000000;
            }
            if (cmbDesde.Text == "mm" && cmbHacia.Text == "m")
            {
                resultado = valor / 1000;
            }
            if (cmbDesde.Text == "mm" && cmbHacia.Text == "cm")
            {
                resultado = valor / 10;
            }

            LimpiarResultado();
            lblResultado.Text = lblResultado.Text + resultado.ToString() + cmbHacia.Text;

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
