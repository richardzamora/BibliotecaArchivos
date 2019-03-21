namespace bibliotecaArchivos.interfaz
{
    partial class GUIGrabar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.labFechaPublicacion = new System.Windows.Forms.Label();
            this.labPaginas = new System.Windows.Forms.Label();
            this.labISBN = new System.Windows.Forms.Label();
            this.labAutor = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DTFechaPublicacion);
            this.panel1.Controls.Add(this.textNumero);
            this.panel1.Controls.Add(this.textISBN);
            this.panel1.Controls.Add(this.textAutor);
            this.panel1.Controls.Add(this.textTitulo);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.labFechaPublicacion);
            this.panel1.Controls.Add(this.labPaginas);
            this.panel1.Controls.Add(this.labISBN);
            this.panel1.Controls.Add(this.labAutor);
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Location = new System.Drawing.Point(18, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 167);
            this.panel1.TabIndex = 1;
            // 
            // DTFechaPublicacion
            // 
            this.DTFechaPublicacion.Location = new System.Drawing.Point(119, 96);
            this.DTFechaPublicacion.Name = "DTFechaPublicacion";
            this.DTFechaPublicacion.Size = new System.Drawing.Size(200, 20);
            this.DTFechaPublicacion.TabIndex = 10;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(119, 70);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(200, 20);
            this.textNumero.TabIndex = 9;
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(119, 48);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(200, 20);
            this.textISBN.TabIndex = 8;
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(119, 26);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(200, 20);
            this.textAutor.TabIndex = 7;
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(119, 4);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(200, 20);
            this.textTitulo.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(131, 137);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Grabar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(18, 30);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(296, 20);
            this.txtRutaArchivo.TabIndex = 2;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(320, 28);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(30, 23);
            this.btnSeleccionarArchivo.TabIndex = 3;
            this.btnSeleccionarArchivo.Text = "...";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // GUIGrabar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.panel1);
            this.Name = "GUIGrabar";
            this.Text = "Grabar Libro";
            this.Load += new System.EventHandler(this.GUIGrabar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTFechaPublicacion;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label labFechaPublicacion;
        private System.Windows.Forms.Label labPaginas;
        private System.Windows.Forms.Label labISBN;
        private System.Windows.Forms.Label labAutor;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
    }
}