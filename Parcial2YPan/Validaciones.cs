using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2YPan
{
    internal class Validaciones
    {
        private ErrorProvider erpErrores = new ErrorProvider();

        public void set(ErrorProvider erpErrores)
        {
            this.erpErrores = erpErrores;
        }

        public void numeroDecimal(TextBox cajaDeTexto, KeyPressEventArgs e)
        {
            //Se admite la pulsacion (escribir uno por uno) y que sea un digito numerico
            if (char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }

            //se admite un . y que sea solo uno
            if (e.KeyChar == '.' && !cajaDeTexto.Text.Contains('.'))
            {
                return;
            }

            // Permitir el signo negativo solo al inicio
            if (e.KeyChar == '-' && cajaDeTexto.Text.Length == 0)
            {
                return;
            }
            e.Handled = true;
        }
        public void numeroPrecio(TextBox cajaDeTexto, KeyPressEventArgs e)
        {
            //Se admite la pulsacion (escribir uno por uno) y que sea un digito numerico
            if (char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            //se admite un . y que sea solo uno
            if (e.KeyChar == '.' && !cajaDeTexto.Text.Contains('.'))
            {
                return;
            }
            e.Handled = true;
        }
        public void numeroStock(KeyPressEventArgs e)
        {
            //Se admite la pulsacion (escribir uno por uno) y que sea un digito numerico
            if (char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        public void verificarCampo(Object sender)
        {
            //validar que el campo no este vacio o nulo, le indica la informacion
            if (((TextBox)sender).Text.Length > 0)
            {
                erpErrores.SetError((Control)sender, "");

            }
            else
            {
                erpErrores.SetError((Control)sender, "No puede estar en blanco el campo. ");
            }
        }

        public void limpiarValidaciones(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                erpErrores.SetError(control, "");
            }
        }

        public void mandarMensaje(string mensaje, int esError)
        {
            if (esError == 1)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
