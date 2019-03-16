namespace bibliotecaArchivos.interfaz
{
    partial class GUIEliminar
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
            this.textPos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.labFechaPublicacion = new System.Windows.Forms.Label();
            this.labPaginas = new System.Windows.Forms.Label();
            this.labISBN = new System.Windows.Forms.Label();
            this.labAutor = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(323, 21);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(30, 23);
            this.btnSeleccionarArchivo.TabIndex = 9;
            this.btnSeleccionarArchivo.Text = "...";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(21, 23);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(296, 20);
            this.txtRutaArchivo.TabIndex = 8;
            this.txtRutaArchivo.Text = "C:\\Users\\Richard\\Desktop\\variables.txt";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textPos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DTFechaPublicacion);
            this.panel1.Controls.Add(this.textNumero);
            this.panel1.Controls.Add(this.textISBN);
            this.panel1.Controls.Add(this.textAutor);
            this.panel1.Controls.Add(this.textTitulo);
            this.panel1.Controls.Add(this.btnLeer);
            this.panel1.Controls.Add(this.labFechaPublicacion);
            this.panel1.Controls.Add(this.labPaginas);
            this.panel1.Controls.Add(this.labISBN);
            this.panel1.Controls.Add(this.labAutor);
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Location = new System.Drawing.Point(21, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 167);
            this.panel1.TabIndex = 7;
            // 
            // textPos
            // 
            this.textPos.Location = new System.Drawing.Point(119, 137);
            this.textPos.Name = "textPos";
            this.textPos.Size = new System.Drawing.Size(86, 20);
            this.textPos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Posición: ";
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
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(238, 137);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(81, 23);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer(1)";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(131, 238);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GUIEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 282);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.panel1);
            this.Name = "GUIEliminar";
            this.Text = "GUIEliminar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTFechaPublicacion;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Label labFechaPublicacion;
        private System.Windows.Forms.Label labPaginas;
        private System.Windows.Forms.Label labISBN;
        private System.Windows.Forms.Label labAutor;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}