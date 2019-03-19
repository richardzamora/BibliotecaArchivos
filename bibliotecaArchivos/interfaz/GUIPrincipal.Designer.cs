namespace bibliotecaArchivos
{
    partial class GUIPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volcarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grabarLibroToolStripMenuItem,
            this.leerLibroToolStripMenuItem,
            this.actualizarLibroToolStripMenuItem,
            this.eliminarLibroToolStripMenuItem,
            this.volcarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // grabarLibroToolStripMenuItem
            // 
            this.grabarLibroToolStripMenuItem.Name = "grabarLibroToolStripMenuItem";
            this.grabarLibroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grabarLibroToolStripMenuItem.Text = "Grabar Libro";
            this.grabarLibroToolStripMenuItem.Click += new System.EventHandler(this.grabarLibroToolStripMenuItem_Click);
            // 
            // leerLibroToolStripMenuItem
            // 
            this.leerLibroToolStripMenuItem.Name = "leerLibroToolStripMenuItem";
            this.leerLibroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.leerLibroToolStripMenuItem.Text = "Leer Libro";
            this.leerLibroToolStripMenuItem.Click += new System.EventHandler(this.leerLibroToolStripMenuItem_Click);
            // 
            // eliminarLibroToolStripMenuItem
            // 
            this.eliminarLibroToolStripMenuItem.Name = "eliminarLibroToolStripMenuItem";
            this.eliminarLibroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarLibroToolStripMenuItem.Text = "Eliminar Libro";
            this.eliminarLibroToolStripMenuItem.Click += new System.EventHandler(this.eliminarLibroToolStripMenuItem_Click);
            // 
            // volcarDatosToolStripMenuItem
            // 
            this.volcarDatosToolStripMenuItem.Name = "volcarDatosToolStripMenuItem";
            this.volcarDatosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.volcarDatosToolStripMenuItem.Text = "Volcar Datos";
            this.volcarDatosToolStripMenuItem.Click += new System.EventHandler(this.volcarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // actualizarLibroToolStripMenuItem
            // 
            this.actualizarLibroToolStripMenuItem.Name = "actualizarLibroToolStripMenuItem";
            this.actualizarLibroToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.actualizarLibroToolStripMenuItem.Text = "Actualizar Libro";
            this.actualizarLibroToolStripMenuItem.Click += new System.EventHandler(this.actualizarLibroToolStripMenuItem_Click);
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUIPrincipal";
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volcarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarLibroToolStripMenuItem;
    }
}

