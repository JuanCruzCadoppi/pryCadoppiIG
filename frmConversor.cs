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
            cmbDesde.Items.Add("hm");
            cmbDesde.Items.Add("dam");
            cmbDesde.Items.Add("m");
            cmbDesde.Items.Add("dm");
            cmbDesde.Items.Add("cm");
            cmbDesde.Items.Add("mm");
            cmbHacia.Items.Clear();
            cmbHacia.Items.Add("km");
            cmbHacia.Items.Add("hm");
            cmbHacia.Items.Add("dam");
            cmbHacia.Items.Add("m");
            cmbHacia.Items.Add("dm");
            cmbHacia.Items.Add("cm");
            cmbHacia.Items.Add("mm");
        }

       
    }
}
