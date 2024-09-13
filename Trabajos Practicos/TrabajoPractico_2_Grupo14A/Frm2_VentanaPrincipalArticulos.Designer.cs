namespace TrabajoPractico_2_Grupo14A
{
    partial class Frm2_VentanaPrincipalArticulos
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
            this.mnsAcciones = new System.Windows.Forms.MenuStrip();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosLosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslDatosEstadoSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsAcciones.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAcciones
            // 
            this.mnsAcciones.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsAcciones.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnsAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnsAcciones.Location = new System.Drawing.Point(0, 0);
            this.mnsAcciones.Name = "mnsAcciones";
            this.mnsAcciones.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.mnsAcciones.Size = new System.Drawing.Size(2809, 58);
            this.mnsAcciones.TabIndex = 0;
            this.mnsAcciones.Text = "menuStrip1";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(144, 48);
            this.articuloToolStripMenuItem.Text = "&Articulo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.agregarToolStripMenuItem.Text = "A&gregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.modificaToolStripMenuItem.Text = "&Modifica";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosLosArticulosToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(160, 48);
            this.articulosToolStripMenuItem.Text = "Articulo&S";
            // 
            // listarTodosLosArticulosToolStripMenuItem
            // 
            this.listarTodosLosArticulosToolStripMenuItem.Name = "listarTodosLosArticulosToolStripMenuItem";
            this.listarTodosLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(503, 54);
            this.listarTodosLosArticulosToolStripMenuItem.Text = "&Listar todos los articulos";
            this.listarTodosLosArticulosToolStripMenuItem.Click += new System.EventHandler(this.listarTodosLosArticulosToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 48);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDatosEstadoSesion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 37, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2809, 54);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslDatosEstadoSesion
            // 
            this.tsslDatosEstadoSesion.Name = "tsslDatosEstadoSesion";
            this.tsslDatosEstadoSesion.Size = new System.Drawing.Size(240, 41);
            this.tsslDatosEstadoSesion.Text = "USUARIO FECHA";
            // 
            // Frm2_VentanaPrincipalArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(2809, 1490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnsAcciones);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsAcciones;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Frm2_VentanaPrincipalArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Articulos";
            this.mnsAcciones.ResumeLayout(false);
            this.mnsAcciones.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAcciones;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosLosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatosEstadoSesion;
    }
}