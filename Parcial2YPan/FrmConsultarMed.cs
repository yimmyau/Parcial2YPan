using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2YPan
{
    public partial class FrmConsultarMed : Form
    {
        Medicamento objMed = new Medicamento();
        Validaciones validar = new Validaciones();
        public FrmConsultarMed()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            objMed.consultarMed(dgvMedicamentos, cmbNombre, picImagen);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            objMed.venderMed(numVender, cmbNombre);
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            objMed.reabastecerMed(numRebastecer, cmbNombre);
        }

        private void FrmConsultarMed_Load(object sender, EventArgs e)
        {
            objMed.cargarNombres(cmbNombre);
            pnlCentro.Left = this.Width / 2 - pnlCentro.Width / 2;
            pnlCentro.Top = this.Height / 2 - pnlCentro.Height / 2;
        }

        private void numVender_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numeroStock(e);

        }

        private void numRebastecer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numeroStock(e);
        }

        private void picImagen_Click(object sender, EventArgs e)
        {
        }
    }
}
