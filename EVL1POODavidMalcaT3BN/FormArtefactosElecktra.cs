using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVL1POODavidMalcaT3BN
{
    public partial class FormArtefactosElecktra : Form
    {
        public FormArtefactosElecktra()
        {
            InitializeComponent();
        }

        Elecktra obj = new Elecktra();
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            obj.cantidad = int.Parse(txtcantidad.Text);
            obj.precio = double.Parse(txtprecio.Text);
            obj.linea = cbolinea.Text;

            txtflete.Text = obj.flete().ToString("n2");
            txtimporte.Text = obj.importe().ToString("n2");
            txtdescuento.Text = obj.descuento().ToString("n2");
            txtneto.Text = obj.Neto().ToString("n2");
        }

        private void FormArtefactosElecktra_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = obj.GeneraCodigo();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            cbolinea.SelectedIndex = -1;
            txtcodigo.Text = obj.GeneraCodigo();
            txtcliente.Clear();
            txtproducto.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            txtcliente.Clear();
            txtflete.Clear();
            txtimporte.Clear();
            txtdescuento.Clear();
            txtneto.Clear();

        }
    }
}
