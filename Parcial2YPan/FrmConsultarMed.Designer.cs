namespace Parcial2YPan
{
    partial class FrmConsultarMed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numVender = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVender = new Parcial2YPan.BotonPersonalizado.BotonRedondo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonRedondo1 = new Parcial2YPan.BotonPersonalizado.BotonRedondo();
            this.numRebastecer = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConsultar = new Parcial2YPan.BotonPersonalizado.BotonRedondo();
            this.opdImagen = new System.Windows.Forms.OpenFileDialog();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVender)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRebastecer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicamentos.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvMedicamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicamentos.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMedicamentos.GridColor = System.Drawing.Color.DarkBlue;
            this.dgvMedicamentos.Location = new System.Drawing.Point(51, 159);
            this.dgvMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMedicamentos.RowHeadersWidth = 51;
            this.dgvMedicamentos.Size = new System.Drawing.Size(707, 101);
            this.dgvMedicamentos.TabIndex = 0;
            // 
            // cmbNombre
            // 
            this.cmbNombre.BackColor = System.Drawing.Color.DarkBlue;
            this.cmbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNombre.ForeColor = System.Drawing.Color.White;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(51, 104);
            this.cmbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(544, 37);
            this.cmbNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Medicamento";
            // 
            // numVender
            // 
            this.numVender.BackColor = System.Drawing.Color.Navy;
            this.numVender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVender.ForeColor = System.Drawing.Color.White;
            this.numVender.Location = new System.Drawing.Point(95, 26);
            this.numVender.Margin = new System.Windows.Forms.Padding(4);
            this.numVender.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVender.Name = "numVender";
            this.numVender.Size = new System.Drawing.Size(119, 41);
            this.numVender.TabIndex = 4;
            this.numVender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numVender.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numVender_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Controls.Add(this.numVender);
            this.panel1.Location = new System.Drawing.Point(51, 286);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 158);
            this.panel1.TabIndex = 6;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVender.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnVender.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnVender.BorderColor1 = System.Drawing.Color.SteelBlue;
            this.btnVender.BorderRadius = 10;
            this.btnVender.BorderRadius1 = 10;
            this.btnVender.BorderSize = 3;
            this.btnVender.BorderSize1 = 3;
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(95, 87);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(119, 45);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.TextColor = System.Drawing.Color.White;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botonRedondo1);
            this.panel2.Controls.Add(this.numRebastecer);
            this.panel2.Location = new System.Drawing.Point(443, 286);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 158);
            this.panel2.TabIndex = 7;
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
            this.botonRedondo1.Location = new System.Drawing.Point(89, 87);
            this.botonRedondo1.Margin = new System.Windows.Forms.Padding(4);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(152, 45);
            this.botonRedondo1.TabIndex = 5;
            this.botonRedondo1.Text = "Rebastecer";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // numRebastecer
            // 
            this.numRebastecer.BackColor = System.Drawing.Color.Navy;
            this.numRebastecer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numRebastecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRebastecer.ForeColor = System.Drawing.Color.White;
            this.numRebastecer.Location = new System.Drawing.Point(107, 26);
            this.numRebastecer.Margin = new System.Windows.Forms.Padding(4);
            this.numRebastecer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRebastecer.Name = "numRebastecer";
            this.numRebastecer.Size = new System.Drawing.Size(119, 41);
            this.numRebastecer.TabIndex = 4;
            this.numRebastecer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRebastecer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRebastecer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numRebastecer_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbNombre);
            this.panel3.Controls.Add(this.btnConsultar);
            this.panel3.Controls.Add(this.dgvMedicamentos);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(25, 124);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 465);
            this.panel3.TabIndex = 9;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsultar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsultar.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnConsultar.BorderColor1 = System.Drawing.Color.SteelBlue;
            this.btnConsultar.BorderRadius = 10;
            this.btnConsultar.BorderRadius1 = 10;
            this.btnConsultar.BorderSize = 3;
            this.btnConsultar.BorderSize1 = 3;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(619, 97);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(139, 49);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // opdImagen
            // 
            this.opdImagen.FileName = "openFileDialog1";
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.AliceBlue;
            this.picImagen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picImagen.Location = new System.Drawing.Point(881, 124);
            this.picImagen.Margin = new System.Windows.Forms.Padding(4);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(396, 465);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 8;
            this.picImagen.TabStop = false;
            this.picImagen.Click += new System.EventHandler(this.picImagen_Click);
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.Transparent;
            this.pnlCentro.Controls.Add(this.label2);
            this.pnlCentro.Controls.Add(this.picImagen);
            this.pnlCentro.Controls.Add(this.pictureBox1);
            this.pnlCentro.Controls.Add(this.panel3);
            this.pnlCentro.Location = new System.Drawing.Point(67, 24);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(1326, 643);
            this.pnlCentro.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(132, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(845, 91);
            this.label2.TabIndex = 22;
            this.label2.Text = "FARMACIAS DR.SIMI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Parcial2YPan.Properties.Resources.similogo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsultarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial2YPan.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1505, 718);
            this.Controls.Add(this.pnlCentro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultarMed";
            this.Load += new System.EventHandler(this.FrmConsultarMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVender)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRebastecer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private BotonPersonalizado.BotonRedondo btnConsultar;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numVender;
        private BotonPersonalizado.BotonRedondo btnVender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private BotonPersonalizado.BotonRedondo botonRedondo1;
        private System.Windows.Forms.NumericUpDown numRebastecer;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog opdImagen;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}