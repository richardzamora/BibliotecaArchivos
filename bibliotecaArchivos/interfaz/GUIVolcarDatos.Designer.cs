namespace bibliotecaArchivos.interfaz
{
    partial class GUIVolcarDatos
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
            this.txtRutaArchivoOrigen = new System.Windows.Forms.TextBox();
            this.btnVolcarDatos = new System.Windows.Forms.Button();
            this.btnSeleccionarArchivoDestino = new System.Windows.Forms.Button();
            this.txtRutaArchivoDestino = new System.Windows.Forms.TextBox();
            this.labArchivoDestino = new System.Windows.Forms.Label();
            this.labArchivoOrigen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(314, 25);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(30, 23);
            this.btnSeleccionarArchivo.TabIndex = 13;
            this.btnSeleccionarArchivo.Text = "...";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // txtRutaArchivoOrigen
            // 
            this.txtRutaArchivoOrigen.Location = new System.Drawing.Point(12, 28);
            this.txtRutaArchivoOrigen.Name = "txtRutaArchivoOrigen";
            this.txtRutaArchivoOrigen.Size = new System.Drawing.Size(296, 20);
            this.txtRutaArchivoOrigen.TabIndex = 12;
            this.txtRutaArchivoOrigen.Text = "C:\\Users\\Richard\\Desktop\\variables.txt";
            // 
            // btnVolcarDatos
            // 
            this.btnVolcarDatos.Location = new System.Drawing.Point(129, 119);
            this.btnVolcarDatos.Name = "btnVolcarDatos";
            this.btnVolcarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnVolcarDatos.TabIndex = 14;
            this.btnVolcarDatos.Text = "Volcar Datos";
            this.btnVolcarDatos.UseVisualStyleBackColor = true;
            this.btnVolcarDatos.Click += new System.EventHandler(this.btnVolcarDatos_Click);
            // 
            // btnSeleccionarArchivoDestino
            // 
            this.btnSeleccionarArchivoDestino.Location = new System.Drawing.Point(314, 81);
            this.btnSeleccionarArchivoDestino.Name = "btnSeleccionarArchivoDestino";
            this.btnSeleccionarArchivoDestino.Size = new System.Drawing.Size(30, 23);
            this.btnSeleccionarArchivoDestino.TabIndex = 16;
            this.btnSeleccionarArchivoDestino.Text = "...";
            this.btnSeleccionarArchivoDestino.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivoDestino.Click += new System.EventHandler(this.btnSeleccionarArchivoDestino_Click);
            // 
            // txtRutaArchivoDestino
            // 
            this.txtRutaArchivoDestino.Location = new System.Drawing.Point(12, 83);
            this.txtRutaArchivoDestino.Name = "txtRutaArchivoDestino";
            this.txtRutaArchivoDestino.Size = new System.Drawing.Size(296, 20);
            this.txtRutaArchivoDestino.TabIndex = 15;
            this.txtRutaArchivoDestino.Text = "C:\\Users\\Richard\\Desktop\\variables.txt";
            // 
            // labArchivoDestino
            // 
            this.labArchivoDestino.AutoSize = true;
            this.labArchivoDestino.Location = new System.Drawing.Point(13, 64);
            this.labArchivoDestino.Name = "labArchivoDestino";
            this.labArchivoDestino.Size = new System.Drawing.Size(97, 13);
            this.labArchivoDestino.TabIndex = 17;
            this.labArchivoDestino.Text = "Archivo de Destino";
            // 
            // labArchivoOrigen
            // 
            this.labArchivoOrigen.AutoSize = true;
            this.labArchivoOrigen.Location = new System.Drawing.Point(13, 12);
            this.labArchivoOrigen.Name = "labArchivoOrigen";
            this.labArchivoOrigen.Size = new System.Drawing.Size(92, 13);
            this.labArchivoOrigen.TabIndex = 18;
            this.labArchivoOrigen.Text = "Archivo de Origen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 19);
            this.button1.TabIndex = 19;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GUIVolcarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labArchivoOrigen);
            this.Controls.Add(this.labArchivoDestino);
            this.Controls.Add(this.btnSeleccionarArchivoDestino);
            this.Controls.Add(this.txtRutaArchivoDestino);
            this.Controls.Add(this.btnVolcarDatos);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.txtRutaArchivoOrigen);
            this.Name = "GUIVolcarDatos";
            this.Text = "GUIVolcarDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivoOrigen;
        private System.Windows.Forms.Button btnVolcarDatos;
        private System.Windows.Forms.Button btnSeleccionarArchivoDestino;
        private System.Windows.Forms.TextBox txtRutaArchivoDestino;
        private System.Windows.Forms.Label labArchivoDestino;
        private System.Windows.Forms.Label labArchivoOrigen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}