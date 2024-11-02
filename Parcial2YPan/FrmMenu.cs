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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void problema1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora frmEcuacion = new FrmCalculadora();
            frmEcuacion.MdiParent = this;
            frmEcuacion.WindowState = FormWindowState.Maximized;
            frmEcuacion.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarMed frmConsultar = new FrmConsultarMed();
            frmConsultar.MdiParent = this;
            frmConsultar.WindowState = FormWindowState.Maximized;
            frmConsultar.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarYModificarMed frmAgregarMed = new FrmAgregarYModificarMed();
            frmAgregarMed.MdiParent = this;
            frmAgregarMed.WindowState = FormWindowState.Maximized;
            frmAgregarMed.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void problema2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
