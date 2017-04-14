namespace sistema_auditoria
{
    partial class InicioSesion
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
            this.txtUsuarioInicioSesion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseñaIncioSesion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresarInicioSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarioInicioSesion
            // 
            this.txtUsuarioInicioSesion.Location = new System.Drawing.Point(107, 44);
            this.txtUsuarioInicioSesion.Name = "txtUsuarioInicioSesion";
            this.txtUsuarioInicioSesion.Size = new System.Drawing.Size(134, 20);
            this.txtUsuarioInicioSesion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // txtContraseñaIncioSesion
            // 
            this.txtContraseñaIncioSesion.Location = new System.Drawing.Point(107, 86);
            this.txtContraseñaIncioSesion.Name = "txtContraseñaIncioSesion";
            this.txtContraseñaIncioSesion.PasswordChar = '*';
            this.txtContraseñaIncioSesion.Size = new System.Drawing.Size(134, 20);
            this.txtContraseñaIncioSesion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // btnIngresarInicioSesion
            // 
            this.btnIngresarInicioSesion.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarInicioSesion.Location = new System.Drawing.Point(89, 146);
            this.btnIngresarInicioSesion.Name = "btnIngresarInicioSesion";
            this.btnIngresarInicioSesion.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarInicioSesion.TabIndex = 4;
            this.btnIngresarInicioSesion.Text = "Ingresar";
            this.btnIngresarInicioSesion.UseVisualStyleBackColor = true;
            this.btnIngresarInicioSesion.Click += new System.EventHandler(this.btnIngresarInicioSesion_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 189);
            this.Controls.Add(this.btnIngresarInicioSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseñaIncioSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuarioInicioSesion);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioInicioSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseñaIncioSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresarInicioSesion;
    }
}