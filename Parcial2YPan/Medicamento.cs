using Npgsql;
using Parcial2YPan.ControlesPersonalizados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2YPan
{
    internal class Medicamento
    {
        private LogEventos log = new LogEventos();
        private Validaciones validar = new Validaciones();

        private TextBox txtNombre = new TextBox();
        private TextBox txtStock = new TextBox();
        private TextBox txtPrecio = new TextBox();

        public void set(TextBox txtNombre, TextBox txtStock, TextBox txtPrecio)
        {
            this.txtNombre = txtNombre;
            this.txtStock = txtStock;
            this.txtPrecio = txtPrecio;
        }

    public void cargarNombres(ComboBox cmbMedicamentos)
        {
            NpgsqlDataAdapter dataAdapter;
            DataTable dt = new DataTable();

            using (ConexionBD conexion = new ConexionBD())
            {
                conexion.conectar();
                if (conexion.getMiConexion().State == ConnectionState.Open)
                {
                    try
                    {
                        // Consulta SQL para obtener id y nombre de los medicamentos
                        string sql = "SELECT id, nombre FROM medicamento order by nombre";
                        dataAdapter = new NpgsqlDataAdapter(sql, conexion.getMiConexion());
                        dataAdapter.Fill(dt);

                        // Verificar si se obtuvieron datos y llenar 
                        if (dt.Rows.Count > 0)
                        {
                            cmbMedicamentos.DataSource = dt;
                            cmbMedicamentos.ValueMember = "id";      
                            cmbMedicamentos.DisplayMember = "nombre"; 
                        }
                        else
                        {
                            validar.mandarMensaje("No se encontraron medicamentos.", 0);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        log.setMensaje($"{typeof(FrmConsultarMed).Name}: Error al consultar la base de datos");
                        log.informacion(ex);
                        validar.mandarMensaje("Error al consultar la base de datos.", 1);
                    }
                    catch (Exception ex)
                    {
                        log.setMensaje($"{typeof(FrmConsultarMed).Name}: Error de conexión");
                        log.informacion(ex);
                        validar.mandarMensaje("Error de conexión.", 1);
                    }
                }
            }
        }
        public void consultarMed(DataGridView dgvMedicamentos, ComboBox cmbMedicamentos, PictureBox picImagen)
        {
            // Obtener el ID del medicamento seleccionado en el ComboBox
            int idMedicamento = Convert.ToInt32(cmbMedicamentos.SelectedValue);

            NpgsqlDataAdapter dataAdapter;
            DataTable dt = new DataTable();

            using (ConexionBD conexion = new ConexionBD())
            {
                conexion.conectar();
                if (conexion.getMiConexion().State == ConnectionState.Open)
                {
                    try
                    {
                        string sql = "SELECT id, nombre, cantidad AS stock, " +
                            "precio_por_unidad AS \"precio c/u\" FROM medicamento WHERE id = @Id";

                        dataAdapter = new NpgsqlDataAdapter(sql, conexion.getMiConexion());
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@Id", idMedicamento);
                        dataAdapter.Fill(dt);

                        // Verificar si se obtuvieron datos y llenar dgv
                        if (dt.Rows.Count > 0)
                        {
                            dgvMedicamentos.DataSource = dt;
                            dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            Size preferredSize = dgvMedicamentos.GetPreferredSize(new Size(0, 0));
                            log.setMensaje($"búsqueda de medicamento de {cmbMedicamentos.Text}");
                            log.informacion();

                            // Obtener la ruta de la imagen
                            string sqlImagen = "SELECT imagen_url FROM medicamento WHERE id = @Id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(sqlImagen, conexion.getMiConexion()))
                            {
                                cmd.Parameters.AddWithValue("@Id", idMedicamento);
                                string imagenUrl = cmd.ExecuteScalar()?.ToString();

                                if (!string.IsNullOrEmpty(imagenUrl))
                                {
                                    string rutaCompleta = Path.Combine(Application.StartupPath, imagenUrl);

                                    if (File.Exists(rutaCompleta))
                                    {
                                        picImagen.Image = new Bitmap(rutaCompleta);
                                    }
                                    else
                                    {
                                        validar.mandarMensaje("La imagen no existe en la ruta especificada.", 1);
                                        picImagen.Image = null;
                                    }
                                }
                            }
                        }
                        else
                        {
                            validar.mandarMensaje("No se encontró el medicamento.", 0);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        log.setMensaje($"{typeof(FrmConsultarMed).Name}: Error al consultar la base de datos");
                        log.informacion(ex);
                        validar.mandarMensaje("Error al consultar la base de datos.", 1);
                    }
                    catch (Exception ex)
                    {
                        log.setMensaje($"{typeof(FrmConsultarMed).Name}: Error de conexión");
                        log.informacion(ex);
                        validar.mandarMensaje("Error de conexión.", 1);
                    }
                }
            }

        }
        public void agregarMed(PictureBox picImagen)
        {
            string nombre = txtNombre.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                validar.mandarMensaje("El nombre no puede estar vacío.", 1);

            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                validar.mandarMensaje("El valor del stock debe ser un número entero válido y no puede ser negativo.", 1);
            }

            if (!double.TryParse(txtPrecio.Text, out double precio) || precio < 0)
            {
                validar.mandarMensaje("El valor del precio debe ser un número válido y no puede ser negativo.", 1);
            }

            if (picImagen.Tag == null)
            {
                validar.mandarMensaje("Por favor, seleccione una imagen.", 1);
                return;
            }

            using (ConexionBD conexion = new ConexionBD())
            {
                try
                {
                    conexion.conectar();

                    if (existeMed(nombre, conexion))
                    {
                        validar.mandarMensaje("El nombre del medicamento ya existe en la base de datos.", 0);
                        return;
                    }

                    string nombreImagen = cargarImagen(picImagen);

                    // Guardar el medicamento en la base de datos
                    string queryInsertar = "INSERT INTO medicamento (nombre, cantidad, precio_por_unidad, imagen_url) " +
                        "VALUES (@Nombre, @Cantidad, @PrecioPorUnidad, @ImagenURL)";
                    using (NpgsqlCommand cmdInsertar = new NpgsqlCommand(queryInsertar, conexion.getMiConexion()))
                    {
                        cmdInsertar.Parameters.AddWithValue("@Nombre", nombre);
                        cmdInsertar.Parameters.AddWithValue("@Cantidad", stock);
                        cmdInsertar.Parameters.AddWithValue("@PrecioPorUnidad", precio);
                        cmdInsertar.Parameters.AddWithValue("@ImagenURL", Path.Combine("Images", nombreImagen));
                        cmdInsertar.ExecuteNonQuery();
                    }

                    validar.mandarMensaje("Medicamento guardado con éxito.", 0);
                }
                catch (Exception ex)
                {
                    log.setMensaje($"{typeof(FrmAgregarYModificarMed).Name}: Error de conexión");
                    log.informacion(ex);
                    validar.mandarMensaje("Error al guardar el medicamento.", 1);
                }
            }
        }


        public void seleccionarImagen(PictureBox picImagen, Form frm)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Mostrar la imagen seleccionada en el PictureBox
                    picImagen.Image = Image.FromFile(openFileDialog.FileName);

                    // Guardar la ruta de la imagen en el PictureBox Tag para su uso posterior
                    picImagen.Tag = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    log.setMensaje($"{frm.GetType().Name}: Error al cargar la imagen");
                    log.informacion(ex);
                    validar.mandarMensaje("Error al cargar la imagen. Asegúrate de que el archivo es una imagen válida.", 1);
                }
            }
        }

        public void modificarMed(ComboBox cmbMedicamentos, PictureBox picImagen)
        {
            int idMedicamento = Convert.ToInt32(cmbMedicamentos.SelectedValue);
            string nuevoNombre = txtNombre.Text.Trim();
            double nuevoPrecio = 0;
            int stock = 0;
            string imagenUrl = null;

            if (!string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                if (!double.TryParse(txtPrecio.Text, out nuevoPrecio) || nuevoPrecio <= 0)
                {
                    validar.mandarMensaje("El precio no puede ser un valor negativo o no válido.", 1);
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(txtStock.Text))
            {
                if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
                {
                    validar.mandarMensaje("El stock no puede ser un valor negativo o no válido.", 1);
                    return;
                }
            }

            // Cargar imagen si está disponible
            if (picImagen.Tag != null)
            {
                string nombreImagen = cargarImagen(picImagen);
                imagenUrl = Path.Combine("Images", nombreImagen);
            }

            using (ConexionBD conexion = new ConexionBD())
            {
                try
                {
                    conexion.conectar();

                    // Validar si el nombre del medicamento ya existe
                    if (existeMed(nuevoNombre, conexion))
                    {
                        validar.mandarMensaje("El nombre del medicamento ya existe en la base de datos.", 0);
                        return;
                    }

                    List<string> cambios = new List<string>();
                    if (!string.IsNullOrWhiteSpace(nuevoNombre)) cambios.Add("nombre = @Nombre");
                    if (!string.IsNullOrWhiteSpace(txtStock.Text)) cambios.Add("cantidad = @Cantidad");
                    if (!string.IsNullOrWhiteSpace(txtPrecio.Text)) cambios.Add("precio_por_unidad = @PrecioPorUnidad");
                    if (imagenUrl != null) cambios.Add("imagen_url = @ImagenURL");

                    if (cambios.Count == 0)
                    {
                        validar.mandarMensaje("No hay cambios para modificar.", 1);
                        return;
                    }

                    string queryActualizar = $"UPDATE medicamento SET {string.Join(", ", cambios)} WHERE id = @Id";

                    using (NpgsqlCommand cmdActualizar = new NpgsqlCommand(queryActualizar, conexion.getMiConexion()))
                    {
                        cmdActualizar.Parameters.AddWithValue("@Id", idMedicamento);
                        if (!string.IsNullOrWhiteSpace(nuevoNombre)) cmdActualizar.Parameters.AddWithValue("@Nombre", nuevoNombre);
                        if (!string.IsNullOrWhiteSpace(txtStock.Text)) cmdActualizar.Parameters.AddWithValue("@Cantidad", stock);
                        if (!string.IsNullOrWhiteSpace(txtPrecio.Text)) cmdActualizar.Parameters.AddWithValue("@PrecioPorUnidad", nuevoPrecio);
                        if (imagenUrl != null) cmdActualizar.Parameters.AddWithValue("@ImagenURL", imagenUrl);

                        cmdActualizar.ExecuteNonQuery();
                    }

                    validar.mandarMensaje("Medicamento modificado con éxito.", 0);
                }
                catch (Exception ex)
                {
                    log.setMensaje($"{typeof(FrmAgregarYModificarMed).Name}: Error al modificar el medicamento");
                    log.informacion(ex);
                    validar.mandarMensaje("Error al modificar el medicamento.", 1);
                }
            }
        }


        private bool existeMed(string nombre, ConexionBD conexion)
        {
            string queryVerificar = "SELECT COUNT(*) FROM medicamento WHERE LOWER(nombre) = LOWER(@Nombre)";

            using (NpgsqlCommand cmdVerificar = new NpgsqlCommand(queryVerificar, conexion.getMiConexion()))
            {
                cmdVerificar.Parameters.AddWithValue("@Nombre", nombre);
                int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                return existe > 0;
            }
        }

        public string cargarImagen(PictureBox picImagen)
        {

            // Definir la ruta de destino en la carpeta Images
            string nombreImagen = Path.GetFileName(picImagen.Tag.ToString());
            string rutaDestino = Path.Combine(Application.StartupPath, "Images", nombreImagen);

            // Comprobar si la imagen ya existe
            int contador = 1;
            string nombreSinExtension = Path.GetFileNameWithoutExtension(nombreImagen);
            string extension = Path.GetExtension(nombreImagen);

            // Cambiar el nombreImagen a un nuevo formato si ya existe
            while (File.Exists(rutaDestino))
            {
                // Generar un nuevo nombre de archivo con un sufijo numérico
                nombreImagen = $"{nombreSinExtension}_{contador}{extension}";
                rutaDestino = Path.Combine(Application.StartupPath, "Images", nombreImagen);
                contador++;
            }

            // Copiar la imagen a la carpeta de destino
            File.Copy(picImagen.Tag.ToString(), rutaDestino, false);

            return nombreImagen;
        }


        public void venderMed(NumericUpDown numVender, ComboBox cmbMedicamentos)
        {
            int cantidadAVender = Convert.ToInt32(numVender.Value);
            int idMedicamento = Convert.ToInt32(cmbMedicamentos.SelectedValue);

            using (ConexionBD conexion = new ConexionBD())
            {
                try
                {
                    conexion.conectar();

                    // Consultar el stock actual del medicamento
                    string queryStock = "SELECT cantidad FROM medicamento WHERE id = @IdMedicamento";
                    using (NpgsqlCommand cmdStock = new NpgsqlCommand(queryStock, conexion.getMiConexion()))
                    {
                        cmdStock.Parameters.AddWithValue("@IdMedicamento", idMedicamento);
                        int stockActual = Convert.ToInt32(cmdStock.ExecuteScalar());

                        // Verificar si hay suficiente stock
                        if (stockActual < cantidadAVender)
                        {
                            validar.mandarMensaje("No hay suficiente stock para realizar la venta.", 0);
                            return;
                        }

                        // Restar la cantidad vendida del stock
                        string queryActualizar = "UPDATE medicamento SET cantidad = cantidad - @Cantidad WHERE id = @IdMedicamento";
                        using (NpgsqlCommand cmdActualizar = new NpgsqlCommand(queryActualizar, conexion.getMiConexion()))
                        {
                            cmdActualizar.Parameters.AddWithValue("@Cantidad", cantidadAVender);
                            cmdActualizar.Parameters.AddWithValue("@IdMedicamento", idMedicamento);
                            cmdActualizar.ExecuteNonQuery();
                        }

                        validar.mandarMensaje("Venta realizada con éxito.", 0);
                    }
                }
                catch (Exception ex)
                {
                    log.setMensaje($"{typeof(FrmConsultarMed).Name}: Error de conexión");
                    log.informacion(ex);
                    validar.mandarMensaje("Error al realizar la venta.", 1);
                }
            }
        }


        public void reabastecerMed(NumericUpDown nupStock, ComboBox cmbMedicamentos)
        {
            int stockAgregar;
            int idMedicamento = Convert.ToInt32(cmbMedicamentos.SelectedValue);
            if (!int.TryParse(nupStock.Text, out stockAgregar) || stockAgregar < 0)
            {
                validar.mandarMensaje("Ingrese una cantidad válida.", 1);
            }

            using (ConexionBD conexion = new ConexionBD())
            {
                try
                {
                    conexion.conectar();

                    // Actualizar el stock del medicamento sumando la cantidad ingresada
                    string queryActualizar = "UPDATE medicamento SET cantidad = cantidad + @Cantidad WHERE id = @IdMedicamento";
                    using (NpgsqlCommand cmdActualizar = new NpgsqlCommand(queryActualizar, conexion.getMiConexion()))
                    {
                        cmdActualizar.Parameters.AddWithValue("@Cantidad", stockAgregar);
                        cmdActualizar.Parameters.AddWithValue("@IdMedicamento", idMedicamento);
                        cmdActualizar.ExecuteNonQuery();
                    }

                    validar.mandarMensaje("Stock reabastecido con éxito.", 0);
                }
                catch (Exception ex)
                {
                    log.setMensaje($"{typeof(FrmConsultarMed).Name}: Error de conexión");
                    log.informacion(ex);
                    validar.mandarMensaje("Error al reabastecer el medicamento.", 1);
                }
            }
        }
    }
}
