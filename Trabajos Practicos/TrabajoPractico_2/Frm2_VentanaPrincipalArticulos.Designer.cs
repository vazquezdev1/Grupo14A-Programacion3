﻿namespace TrabajoPractico_2
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
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslDatosEstadoSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsAcciones.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAcciones
            // 
            this.mnsAcciones.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnsAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.articulosToolStripMenuItem});
            this.mnsAcciones.Location = new System.Drawing.Point(0, 0);
            this.mnsAcciones.Name = "mnsAcciones";
            this.mnsAcciones.Size = new System.Drawing.Size(722, 24);
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
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.articuloToolStripMenuItem.Text = "&Artículo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "A&gregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaToolStripMenuItem.Text = "&Modificar";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosLosArticulosToolStripMenuItem,
            this.filtrosToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.articulosToolStripMenuItem.Text = "&Listados";
            // 
            // listarTodosLosArticulosToolStripMenuItem
            // 
            this.listarTodosLosArticulosToolStripMenuItem.Name = "listarTodosLosArticulosToolStripMenuItem";
            this.listarTodosLosArticulosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listarTodosLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.listarTodosLosArticulosToolStripMenuItem.Text = "&Listar todos los artículos";
            this.listarTodosLosArticulosToolStripMenuItem.Click += new System.EventHandler(this.listarTodosLosArticulosToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            this.filtrosToolStripMenuItem.Click += new System.EventHandler(this.filtrosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDatosEstadoSesion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslDatosEstadoSesion
            // 
            this.tsslDatosEstadoSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslDatosEstadoSesion.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslDatosEstadoSesion.Name = "tsslDatosEstadoSesion";
            this.tsslDatosEstadoSesion.Size = new System.Drawing.Size(39, 17);
            this.tsslDatosEstadoSesion.Text = "Fecha";
            // 
            // Frm2_VentanaPrincipalArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnsAcciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsAcciones;
            this.Name = "Frm2_VentanaPrincipalArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatosEstadoSesion;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
    }
}