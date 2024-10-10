namespace TrabajoPractico_2_Grupo14A
{
    partial class Frm8_Marcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAltaMarca = new System.Windows.Forms.Button();
            this.btnBajaMarca = new System.Windows.Forms.Button();
            this.btnModificacionMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 12);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(396, 106);
            this.dgvMarcas.TabIndex = 0;
            // 
            // btnAltaMarca
            // 
            this.btnAltaMarca.Location = new System.Drawing.Point(12, 149);
            this.btnAltaMarca.Name = "btnAltaMarca";
            this.btnAltaMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAltaMarca.TabIndex = 1;
            this.btnAltaMarca.Text = "Alta";
            this.btnAltaMarca.UseVisualStyleBackColor = true;
            this.btnAltaMarca.Click += new System.EventHandler(this.btnAltaMarca_Click);
            // 
            // btnBajaMarca
            // 
            this.btnBajaMarca.Location = new System.Drawing.Point(333, 149);
            this.btnBajaMarca.Name = "btnBajaMarca";
            this.btnBajaMarca.Size = new System.Drawing.Size(75, 23);
            this.btnBajaMarca.TabIndex = 2;
            this.btnBajaMarca.Text = "Baja";
            this.btnBajaMarca.UseVisualStyleBackColor = true;
            this.btnBajaMarca.Click += new System.EventHandler(this.btnBajaMarca_Click);
            // 
            // btnModificacionMarca
            // 
            this.btnModificacionMarca.Location = new System.Drawing.Point(166, 149);
            this.btnModificacionMarca.Name = "btnModificacionMarca";
            this.btnModificacionMarca.Size = new System.Drawing.Size(75, 23);
            this.btnModificacionMarca.TabIndex = 3;
            this.btnModificacionMarca.Text = "Modificacion";
            this.btnModificacionMarca.UseVisualStyleBackColor = true;
            this.btnModificacionMarca.Click += new System.EventHandler(this.btnModificacionMarca_Click);
            // 
            // Frm8_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 202);
            this.Controls.Add(this.btnModificacionMarca);
            this.Controls.Add(this.btnBajaMarca);
            this.Controls.Add(this.btnAltaMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "Frm8_Marcas";
            this.Text = "Frm8_Marcas";
            this.Load += new System.EventHandler(this.Frm8_Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAltaMarca;
        private System.Windows.Forms.Button btnBajaMarca;
        private System.Windows.Forms.Button btnModificacionMarca;
    }
}