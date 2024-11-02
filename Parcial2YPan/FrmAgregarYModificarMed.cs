using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Collections;

namespace Parcial2YPan
{
    public partial class FrmAgregarYModificarMed : Form
    {
        Medicamento objMed =  new Medicamento();
        Validaciones validar = new Validaciones();

        public FrmAgregarYModificarMed()
        {
            InitializeComponent();
        }


        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            objMed.set(txtNombre, txtStock, txtPrec);

            if (chkCambio.Checked)
            {
                objMed.modificarMed(cboMedicamentos, picImagen);
                objMed.cargarNombres(cboMedicamentos);

            }
            else
            {
                objMed.agregarMed(picImagen);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            objMed.seleccionarImagen(picImagen, this);
        }

        private void chkCambio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCambio.Checked)
            {
                botonRedondo1.Text = "Modificar";
                lblTitulo.Text = "Modificar Medicamento";
                pnlModificar.Visible = true;
                lblEstado.Text = "Modificar";
                validar.limpiarValidaciones(pnlContenido);

            }
            else
            {
                botonRedondo1.Text = "Agregar";
                lblTitulo.Text = "Agregar Medicamento";
                pnlModificar.Visible = false;
                lblEstado.Text = "Agregar";

            }
        }

        private void FrmAgregarMed_Load(object sender, EventArgs e)
        {
            objMed.cargarNombres(cboMedicamentos);
            validar.set(erpErrores);
            objMed.set(txtNombre, txtStock, txtPrec);

            pnlCentro.Left = this.Width / 2 - pnlCentro.Width / 2;
            pnlCentro.Top = this.Height / 2 - pnlCentro.Height / 2;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!chkCambio.Checked)
            {
                validar.verificarCampo(sender);
            }
        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            if (!chkCambio.Checked)
            {
                validar.verificarCampo(sender);
            }
        }

        private void txtPrec_Validating(object sender, CancelEventArgs e)
        {
            if (!chkCambio.Checked)
            {
                validar.verificarCampo(sender);
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numeroStock(e);
        }

        private void txtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numeroPrecio(txtPrec, e);
        }
    }
}
