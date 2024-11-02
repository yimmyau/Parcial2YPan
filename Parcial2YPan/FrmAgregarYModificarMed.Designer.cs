namespace Parcial2YPan
{
    partial class FrmAgregarYModificarMed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMedicamentos = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opdImagen = new System.Windows.Forms.OpenFileDialog();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkCambio = new Parcial2YPan.ControlesPersonalizados.ToggleButton();
            this.botonRedondo1 = new Parcial2YPan.BotonPersonalizado.BotonRedondo();
            this.pnlContenido.SuspendLayout();
            this.pnlModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNombre.Location = new System.Drawing.Point(89, 234);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(184, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nuevo nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(472, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio por unidad";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlContenido.Controls.Add(this.txtStock);
            this.pnlContenido.Controls.Add(this.pnlModificar);
            this.pnlContenido.Controls.Add(this.lblTitulo);
            this.pnlContenido.Controls.Add(this.lblEstado);
            this.pnlContenido.Controls.Add(this.txtNombre);
            this.pnlContenido.Controls.Add(this.chkCambio);
            this.pnlContenido.Controls.Add(this.picImagen);
            this.pnlContenido.Controls.Add(this.txtPrec);
            this.pnlContenido.Controls.Add(this.label3);
            this.pnlContenido.Controls.Add(this.botonRedondo1);
            this.pnlContenido.Controls.Add(this.label2);
            this.pnlContenido.Controls.Add(this.lblNombre);
            this.pnlContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContenido.Location = new System.Drawing.Point(65, 111);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1192, 486);
            this.pnlContenido.TabIndex = 6;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtStock.Location = new System.Drawing.Point(366, 262);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(69, 34);
            this.txtStock.TabIndex = 17;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            this.txtStock.Validating += new System.ComponentModel.CancelEventHandler(this.txtStock_Validating);
            // 
            // pnlModificar
            // 
            this.pnlModificar.Controls.Add(this.label6);
            this.pnlModificar.Controls.Add(this.label5);
            this.pnlModificar.Controls.Add(this.label4);
            this.pnlModificar.Controls.Add(this.cboMedicamentos);
            this.pnlModificar.Location = new System.Drawing.Point(49, 80);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(678, 147);
            this.pnlModificar.TabIndex = 16;
            this.pnlModificar.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(40, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(466, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ingrese solamente en los campos que va a modificar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(40, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nuevos datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(37, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Medicamento a modificar";
            // 
            // cboMedicamentos
            // 
            this.cboMedicamentos.BackColor = System.Drawing.Color.MidnightBlue;
            this.cboMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboMedicamentos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboMedicamentos.FormattingEnabled = true;
            this.cboMedicamentos.Location = new System.Drawing.Point(45, 37);
            this.cboMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.cboMedicamentos.Name = "cboMedicamentos";
            this.cboMedicamentos.Size = new System.Drawing.Size(599, 37);
            this.cboMedicamentos.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(162, 26);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 39);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Agregar Medicamento";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(1026, 366);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 20);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Agregar";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNombre.Location = new System.Drawing.Point(94, 262);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 34);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // picImagen
            // 
            this.picImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImagen.Image = global::Parcial2YPan.Properties.Resources.subirr;
            this.picImagen.Location = new System.Drawing.Point(765, 80);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(372, 336);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 9;
            this.picImagen.TabStop = false;
            this.picImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtPrec
            // 
            this.txtPrec.BackColor = System.Drawing.Color.White;
            this.txtPrec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPrec.Location = new System.Drawing.Point(477, 262);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(216, 34);
            this.txtPrec.TabIndex = 8;
            this.txtPrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrec_KeyPress);
            this.txtPrec.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrec_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(362, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock";
            // 
            // opdImagen
            // 
            this.opdImagen.FileName = "openFileDialog1";
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.Transparent;
            this.pnlCentro.Controls.Add(this.label1);
            this.pnlCentro.Controls.Add(this.pictureBox1);
            this.pnlCentro.Controls.Add(this.pnlContenido);
            this.pnlCentro.Location = new System.Drawing.Point(39, 12);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(1287, 657);
            this.pnlCentro.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(172, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 91);
            this.label1.TabIndex = 20;
            this.label1.Text = "FARMACIAS DR.SIMI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial2YPan.Properties.Resources.similogo;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // chkCambio
            // 
            this.chkCambio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkCambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCambio.ForeColor = System.Drawing.Color.Transparent;
            this.chkCambio.Location = new System.Drawing.Point(1030, 389);
            this.chkCambio.MinimumSize = new System.Drawing.Size(45, 22);
            this.chkCambio.Name = "chkCambio";
            this.chkCambio.OffBackColor = System.Drawing.Color.SteelBlue;
            this.chkCambio.OffToggleColor = System.Drawing.Color.White;
            this.chkCambio.OnBackColor = System.Drawing.Color.MidnightBlue;
            this.chkCambio.OnToggleColor = System.Drawing.Color.White;
            this.chkCambio.Size = new System.Drawing.Size(97, 43);
            this.chkCambio.TabIndex = 10;
            this.chkCambio.UseVisualStyleBackColor = false;
            this.chkCambio.CheckedChanged += new System.EventHandler(this.chkCambio_CheckedChanged);
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botonRedondo1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.botonRedondo1.BorderColor = System.Drawing.Color.SteelBlue;
            this.botonRedondo1.BorderColor1 = System.Drawing.Color.SteelBlue;
            this.botonRedondo1.BorderRadius = 10;
            this.botonRedondo1.BorderRadius1 = 10;
            this.botonRedondo1.BorderSize = 3;
            this.botonRedondo1.BorderSize1 = 3;
            this.botonRedondo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(323, 355);
            this.botonRedondo1.Margin = new System.Windows.Forms.Padding(4);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(166, 49);
            this.botonRedondo1.TabIndex = 1;
            this.botonRedondo1.Text = "Agregar";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // FrmAgregarYModificarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial2YPan.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1359, 718);
            this.Controls.Add(this.pnlCentro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregarYModificarMed";
            this.Load += new System.EventHandler(this.FrmAgregarMed_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BotonPersonalizado.BotonRedondo botonRedondo1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.OpenFileDialog opdImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.TextBox txtNombre;
        private ControlesPersonalizados.ToggleButton chkCambio;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMedicamentos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}