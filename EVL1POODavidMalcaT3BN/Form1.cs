using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace EVL1POODavidMalcaT3BN
{
    public partial class frmPostulante : Form
    {
        public frmPostulante()
        {
            InitializeComponent();
        }
        List<Postulantes> listaPostulante = new List<Postulantes>();
        Postulantes obj = new Postulantes();

        void listado()
        {
            lvwpost.Items.Clear();
            foreach(Postulantes reg in listaPostulante)
            {
                ListViewItem item = new ListViewItem(reg.codigo);
                item.SubItems.Add(reg.dni.ToUpper());
                item.SubItems.Add(reg.nombre);
                item.SubItems.Add(reg.apellido);
                item.SubItems.Add(reg.grado);
                item.SubItems.Add(reg.correo);
                lvwpost.Items.Add(item);
            }
        }
        void limpiar()
        {
            //limpiar objetos
            cbogrado.SelectedIndex = -1;
            txtcodigo.Text = obj.GeneraCodigo();
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            txtdni.Clear();
            txtdni.Focus();


        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //controlar la duplicidad de Dni
            Boolean encuentra = false;
            foreach(Postulantes reg in listaPostulante)
            {
                if (reg.dni == txtdni.Text.ToUpper())
                {
                    MessageBox.Show("Ya se encuentra ese DNI registrado...", "AVISO");
                    encuentra = true;
                    break;
                }
            }
            if (encuentra == false)
            {
                obj = new Postulantes();
                obj.codigo = txtcodigo.Text;
                obj.dni = txtdni.Text.ToUpper();
                obj.nombre = txtnombre.Text;
                obj.apellido = txtapellido.Text;
                obj.grado =cbogrado.Text;
                obj.correo = txtcorreo.Text;
                listaPostulante.Add(obj);
                listado();
                limpiar();
            }
        }

        private void frmPostulante_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = obj.GeneraCodigo();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string codigoBuscando = Interaction.InputBox("ingresar Codigo a eliminar:", "AVISO");
            Boolean encuentra = true;
            foreach(Postulantes reg in listaPostulante)
            {
                if (reg.codigo == codigoBuscando)
                {
                    encuentra = true;
                    listaPostulante.Remove(reg);
                    break;
                }
                else
                {
                    encuentra = false;
                }
            }
            if (encuentra == false)
            {
                MessageBox.Show("El codigo no existe...", "AVISO");
                return;
            }
            listado();

        }
    }
}
