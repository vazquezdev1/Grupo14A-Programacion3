namespace TrabajoPractico_2_Grupo14A
{
    partial class Frm10_Categorias
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
            this.btnModificacionCategoria = new System.Windows.Forms.Button();
            this.btnBajaCategoria = new System.Windows.Forms.Button();
            this.btnAltacategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificacionCategoria
            // 
            this.btnModificacionCategoria.Location = new System.Drawing.Point(166, 149);
            this.btnModificacionCategoria.Name = "btnModificacionCategoria";
            this.btnModificacionCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificacionCategoria.TabIndex = 7;
            this.btnModificacionCategoria.Text = "Modificacion";
            this.btnModificacionCategoria.UseVisualStyleBackColor = true;
            this.btnModificacionCategoria.Click += new System.EventHandler(this.btnModificacionCategoria_Click);
            // 
            // btnBajaCategoria
            // 
            this.btnBajaCategoria.Location = new System.Drawing.Point(333, 149);
            this.btnBajaCategoria.Name = "btnBajaCategoria";
            this.btnBajaCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnBajaCategoria.TabIndex = 6;
            this.btnBajaCategoria.Text = "Baja";
            this.btnBajaCategoria.UseVisualStyleBackColor = true;
            this.btnBajaCategoria.Click += new System.EventHandler(this.btnBajaCategoria_Click);
            // 
            // btnAltacategoria
            // 
            this.btnAltacategoria.Location = new System.Drawing.Point(12, 149);
            this.btnAltacategoria.Name = "btnAltacategoria";
            this.btnAltacategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAltacategoria.TabIndex = 5;
            this.btnAltacategoria.Text = "Alta";
            this.btnAltacategoria.UseVisualStyleBackColor = true;
            this.btnAltacategoria.Click += new System.EventHandler(this.btnAltacategoria_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 12);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(396, 106);
            this.dgvCategorias.TabIndex = 4;
            // 
            // Frm10_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 196);
            this.Controls.Add(this.btnModificacionCategoria);
            this.Controls.Add(this.btnBajaCategoria);
            this.Controls.Add(this.btnAltacategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Name = "Frm10_Categorias";
            this.Text = "Frm10_Categorias";
            this.Load += new System.EventHandler(this.Frm10_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificacionCategoria;
        private System.Windows.Forms.Button btnBajaCategoria;
        private System.Windows.Forms.Button btnAltacategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}