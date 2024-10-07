namespace TrabajoPractico_2
{
    partial class Form1
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.LblMsgBienvenida = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblIngreseUserName = new System.Windows.Forms.Label();
            this.btnDevsBy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(295, 249);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(146, 52);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Iniciar Sistema";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // LblMsgBienvenida
            // 
            this.LblMsgBienvenida.AutoSize = true;
            this.LblMsgBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgBienvenida.Location = new System.Drawing.Point(160, 53);
            this.LblMsgBienvenida.Name = "LblMsgBienvenida";
            this.LblMsgBienvenida.Size = new System.Drawing.Size(390, 33);
            this.LblMsgBienvenida.TabIndex = 0;
            this.LblMsgBienvenida.Text = "Bienvenido al sistema SAA";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(284, 192);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(165, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // lblIngreseUserName
            // 
            this.lblIngreseUserName.AutoSize = true;
            this.lblIngreseUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseUserName.Location = new System.Drawing.Point(271, 150);
            this.lblIngreseUserName.Name = "lblIngreseUserName";
            this.lblIngreseUserName.Size = new System.Drawing.Size(197, 18);
            this.lblIngreseUserName.TabIndex = 1;
            this.lblIngreseUserName.Text = "Ingrese el usuario de acceso";
            // 
            // btnDevsBy
            // 
            this.btnDevsBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevsBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevsBy.Location = new System.Drawing.Point(581, 393);
            this.btnDevsBy.Name = "btnDevsBy";
            this.btnDevsBy.Size = new System.Drawing.Size(138, 24);
            this.btnDevsBy.TabIndex = 4;
            this.btnDevsBy.Text = "Desarrollado por...";
            this.btnDevsBy.UseVisualStyleBackColor = true;
            this.btnDevsBy.Click += new System.EventHandler(this.btnDevsBy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(731, 429);
            this.Controls.Add(this.btnDevsBy);
            this.Controls.Add(this.lblIngreseUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.LblMsgBienvenida);
            this.Controls.Add(this.btnInicio);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(747, 468);
            this.MinimumSize = new System.Drawing.Size(747, 468);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAA - Sistema Administrador de Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label LblMsgBienvenida;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblIngreseUserName;
        private System.Windows.Forms.Button btnDevsBy;
    }
}

