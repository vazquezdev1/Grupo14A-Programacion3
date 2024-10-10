namespace TrabajoPractico_2_Grupo14A
{
    partial class Frm11_AltaCategoria
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
            this.btnCancelarNuevaCategoria = new System.Windows.Forms.Button();
            this.btnAceptarNuevaCategoria = new System.Windows.Forms.Button();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.lblNuevaCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarNuevaCategoria
            // 
            this.btnCancelarNuevaCategoria.Location = new System.Drawing.Point(154, 121);
            this.btnCancelarNuevaCategoria.Name = "btnCancelarNuevaCategoria";
            this.btnCancelarNuevaCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNuevaCategoria.TabIndex = 7;
            this.btnCancelarNuevaCategoria.Text = "Cancelar";
            this.btnCancelarNuevaCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarNuevaCategoria.Click += new System.EventHandler(this.btnCancelarNuevaCategoria_Click);
            // 
            // btnAceptarNuevaCategoria
            // 
            this.btnAceptarNuevaCategoria.Location = new System.Drawing.Point(52, 121);
            this.btnAceptarNuevaCategoria.Name = "btnAceptarNuevaCategoria";
            this.btnAceptarNuevaCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevaCategoria.TabIndex = 6;
            this.btnAceptarNuevaCategoria.Text = "Aceptar";
            this.btnAceptarNuevaCategoria.UseVisualStyleBackColor = true;
            this.btnAceptarNuevaCategoria.Click += new System.EventHandler(this.btnAceptarNuevaCategoria_Click);
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Location = new System.Drawing.Point(52, 52);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(177, 20);
            this.txtNuevaCategoria.TabIndex = 5;
            // 
            // lblNuevaCategoria
            // 
            this.lblNuevaCategoria.AutoSize = true;
            this.lblNuevaCategoria.Location = new System.Drawing.Point(12, 15);
            this.lblNuevaCategoria.Name = "lblNuevaCategoria";
            this.lblNuevaCategoria.Size = new System.Drawing.Size(136, 13);
            this.lblNuevaCategoria.TabIndex = 4;
            this.lblNuevaCategoria.Text = "Ingrese la nueva categoria:";
            // 
            // Frm11_AltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 183);
            this.Controls.Add(this.btnCancelarNuevaCategoria);
            this.Controls.Add(this.btnAceptarNuevaCategoria);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.lblNuevaCategoria);
            this.Name = "Frm11_AltaCategoria";
            this.Text = "Frm11_AltaCategoria";
            this.Load += new System.EventHandler(this.Frm11_AltaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarNuevaCategoria;
        private System.Windows.Forms.Button btnAceptarNuevaCategoria;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
        private System.Windows.Forms.Label lblNuevaCategoria;
    }
}