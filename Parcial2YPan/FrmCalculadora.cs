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
    public partial class FrmCalculadora : Form
    {
        Ecuacion ecuacion = new Ecuacion();
        Validaciones validar = new Validaciones();

        public FrmCalculadora()
        {
            InitializeComponent();
            validar.set(erpErrores);
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);

                ecuacion.set(a, b, c);

                lblResultado.Text = ecuacion.calcularRaiz(); ;

                ecuacion.graficar(chart1);
            }
            catch (FormatException)
            {
                validar.mandarMensaje("Por favor, ingrese valores numéricos válidos.", 1);
            }
            catch (Exception ex)
            {
                validar.mandarMensaje($"Ocurrió un error: {ex.Message}", 1);
            }
        }
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numeroDecimal(txtA, e);
        }

        private void txtA_Validating(object sender, CancelEventArgs e)
        {
            validar.verificarCampo(sender);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numeroDecimal(txtB, e);
        }

        private void txtB_Validating(object sender, CancelEventArgs e)
        {
            validar.verificarCampo(sender);
        }

        private void txtC_Validating(object sender, CancelEventArgs e)
        {
            validar.verificarCampo(sender);

        }
        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numeroDecimal(txtC, e);

        }
    }
}
