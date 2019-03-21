namespace bibliotecaArchivos.interfaz
{
    partial class GUIActualizar
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
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.labFechaPublicacion = new System.Windows.Forms.Label();
            this.labPaginas = new System.Windows.Forms.Label();
            this.labISBN = new System.Windows.Forms.Label();
            this.labAutor = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.textCriterio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBPos = new System.Windows.Forms.RadioButton();
            this.rBIsbn = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(314, 17);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(30, 23);
            this.btnSeleccionarArchivo.TabIndex = 9;
            this.btnSeleccionarArchivo.Text = "...";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(12, 17);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(296, 20);
            this.txtRutaArchivo.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DTFechaPublicacion);
            this.panel1.Controls.Add(this.textNumero);
            this.panel1.Controls.Add(this.textISBN);
            this.panel1.Controls.Add(this.textAutor);
            this.panel1.Controls.Add(this.textTitulo);
            this.panel1.Controls.Add(this.labFechaPublicacion);
            this.panel1.Controls.Add(this.labPaginas);
            this.panel1.Controls.Add(this.labISBN);
            this.panel1.Controls.Add(this.labAutor);
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 129);
            this.panel1.TabIndex = 7;
            // 
            // DTFechaPublicacion
            // 
            this.DTFechaPublicacion.Enabled = false;
            this.DTFechaPublicacion.Location = new System.Drawing.Point(119, 96);
            this.DTFechaPublicacion.Name = "DTFechaPublicacion";
            this.DTFechaPublicacion.Size = new System.Drawing.Size(200, 20);
            this.DTFechaPublicacion.TabIndex = 10;
            // 
            // textNumero
            // 
            this.textNumero.Enabled = false;
            this.textNumero.Location = new System.Drawing.Point(119, 70);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(200, 20);
            this.textNumero.TabIndex = 9;
            // 
            // textISBN
            // 
            this.textISBN.Enabled = false;
            this.textISBN.Location = new System.Drawing.Point(119, 48);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(200, 20);
            this.textISBN.TabIndex = 8;
            // 
            // textAutor
            // 
            this.textAutor.Enabled = false;
            this.textAutor.Location = new System.Drawing.Point(119, 26);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(200, 20);
            this.textAutor.TabIndex = 7;
            // 
            // textTitulo
            // 
            this.textTitulo.Enabled = false;
            this.textTitulo.Location = new System.Drawing.Point(119, 4);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(200, 20);
            this.textTitulo.TabIndex = 6;
            // 
            // labFechaPublicacion
            // 
            this.labFechaPublicacion.AutoSize = true;
            this.labFechaPublicacion.Location = new System.Drawing.Point(4, 102);
            this.labFechaPublicacion.Name = "labFechaPublicacion";
            this.labFechaPublicacion.Size = new System.Drawing.Size(112, 13);
            this.labFechaPublicacion.TabIndex = 4;
            this.labFechaPublicacion.Text = "Fecha de publicacion:";
            // 
            // labPaginas
            // 
            this.labPaginas.AutoSize = true;
            this.labPaginas.Location = new System.Drawing.Point(4, 73);
            this.labPaginas.Name = "labPaginas";
            this.labPaginas.Size = new System.Drawing.Size(105, 13);
            this.labPaginas.TabIndex = 3;
            this.labPaginas.Text = "Número de páginas: ";
            // 
            // labISBN
            // 
            this.labISBN.AutoSize = true;
            this.labISBN.Location = new System.Drawing.Point(3, 51);
            this.labISBN.Name = "labISBN";
            this.labISBN.Size = new System.Drawing.Size(35, 13);
            this.labISBN.TabIndex = 2;
            this.labISBN.Text = "ISBN:";
            // 
            // labAutor
            // 
            this.labAutor.AutoSize = true;
            this.labAutor.Location = new System.Drawing.Point(4, 29);
            this.labAutor.Name = "labAutor";
            this.labAutor.Size = new System.Drawing.Size(35, 13);
            this.labAutor.TabIndex = 1;
            this.labAutor.Text = "Autor:";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Location = new System.Drawing.Point(3, 7);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(41, 13);
            this.labTitulo.TabIndex = 0;
            this.labTitulo.Text = "Título: ";
            // 
            // textCriterio
            // 
            this.textCriterio.Location = new System.Drawing.Point(3, 35);
            this.textCriterio.Name = "textCriterio";
            this.textCriterio.Size = new System.Drawing.Size(230, 20);
            this.textCriterio.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(239, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBPos);
            this.panel2.Controls.Add(this.rBIsbn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textCriterio);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Location = new System.Drawing.Point(13, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 66);
            this.panel2.TabIndex = 14;
            // 
            // rBPos
            // 
            this.rBPos.AutoSize = true;
            this.rBPos.Checked = true;
            this.rBPos.Location = new System.Drawing.Point(89, 12);
            this.rBPos.Name = "rBPos";
            this.rBPos.Size = new System.Drawing.Size(65, 17);
            this.rBPos.TabIndex = 14;
            this.rBPos.TabStop = true;
            this.rBPos.Text = "Posición";
            this.rBPos.UseVisualStyleBackColor = true;
            // 
            // rBIsbn
            // 
            this.rBIsbn.AutoSize = true;
            this.rBIsbn.Location = new System.Drawing.Point(160, 12);
            this.rBIsbn.Name = "rBIsbn";
            this.rBIsbn.Size = new System.Drawing.Size(50, 17);
            this.rBIsbn.TabIndex = 13;
            this.rBIsbn.Text = "ISBN";
            this.rBIsbn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(217, 266);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(55, 266);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(101, 23);
            this.btnHabilitar.TabIndex = 16;
            this.btnHabilitar.Text = "Habilitar edición";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // GUIActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 306);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.panel1);
            this.Name = "GUIActualizar";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.GUIActualizar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTFechaPublicacion;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Label labFechaPublicacion;
        private System.Windows.Forms.Label labPaginas;
        private System.Windows.Forms.Label labISBN;
        private System.Windows.Forms.Label labAutor;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.TextBox textCriterio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.RadioButton rBIsbn;
        private System.Windows.Forms.RadioButton rBPos;
    }
}