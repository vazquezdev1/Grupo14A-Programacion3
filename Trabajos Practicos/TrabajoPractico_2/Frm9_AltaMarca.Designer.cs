namespace TrabajoPractico_2_Grupo14A
{
    partial class Frm9_AltaMarca
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
            this.lblNuevaMarca = new System.Windows.Forms.Label();
            this.txtNuevaMarca = new System.Windows.Forms.TextBox();
            this.btnAceptarNuevaMarca = new System.Windows.Forms.Button();
            this.btnCancelarNuevaMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevaMarca
            // 
            this.lblNuevaMarca.AutoSize = true;
            this.lblNuevaMarca.Location = new System.Drawing.Point(12, 18);
            this.lblNuevaMarca.Name = "lblNuevaMarca";
            this.lblNuevaMarca.Size = new System.Drawing.Size(121, 13);
            this.lblNuevaMarca.TabIndex = 0;
            this.lblNuevaMarca.Text = "Ingrese la nueva marca:";
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.Location = new System.Drawing.Point(52, 55);
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(177, 20);
            this.txtNuevaMarca.TabIndex = 1;
            // 
            // btnAceptarNuevaMarca
            // 
            this.btnAceptarNuevaMarca.Location = new System.Drawing.Point(52, 124);
            this.btnAceptarNuevaMarca.Name = "btnAceptarNuevaMarca";
            this.btnAceptarNuevaMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevaMarca.TabIndex = 2;
            this.btnAceptarNuevaMarca.Text = "Aceptar";
            this.btnAceptarNuevaMarca.UseVisualStyleBackColor = true;
            this.btnAceptarNuevaMarca.Click += new System.EventHandler(this.btnAceptarNuevaMarca_Click);
            // 
            // btnCancelarNuevaMarca
            // 
            this.btnCancelarNuevaMarca.Location = new System.Drawing.Point(154, 124);
            this.btnCancelarNuevaMarca.Name = "btnCancelarNuevaMarca";
            this.btnCancelarNuevaMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNuevaMarca.TabIndex = 3;
            this.btnCancelarNuevaMarca.Text = "Cancelar";
            this.btnCancelarNuevaMarca.UseVisualStyleBackColor = true;
            this.btnCancelarNuevaMarca.Click += new System.EventHandler(this.btnCancelarNuevaMarca_Click);
            // 
            // Frm9_AltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 181);
            this.Controls.Add(this.btnCancelarNuevaMarca);
            this.Controls.Add(this.btnAceptarNuevaMarca);
            this.Controls.Add(this.txtNuevaMarca);
            this.Controls.Add(this.lblNuevaMarca);
            this.Name = "Frm9_AltaMarca";
            this.Text = "Frm9_AltaMarca";
            this.Load += new System.EventHandler(this.Frm9_AltaMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaMarca;
        private System.Windows.Forms.TextBox txtNuevaMarca;
        private System.Windows.Forms.Button btnAceptarNuevaMarca;
        private System.Windows.Forms.Button btnCancelarNuevaMarca;
    }
}