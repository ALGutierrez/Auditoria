namespace sistema_auditoria
{
    partial class Usuarios
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
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.cmbBuscarUsuario = new System.Windows.Forms.ComboBox();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.rbEliminarUsuario = new System.Windows.Forms.RadioButton();
            this.rbModificarUsuario = new System.Windows.Forms.RadioButton();
            this.rbIngresaUsuario = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeleccionarAuditor = new System.Windows.Forms.ComboBox();
            this.txtIDAuditorUsuarios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAceptarUsuario = new System.Windows.Forms.Button();
            this.btnCancelarUsuario = new System.Windows.Forms.Button();
            this.txtAliasUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUsuario.Location = new System.Drawing.Point(639, 125);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(80, 21);
            this.txtIDUsuario.TabIndex = 43;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(542, 118);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 42;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // cmbBuscarUsuario
            // 
            this.cmbBuscarUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarUsuario.FormattingEnabled = true;
            this.cmbBuscarUsuario.Location = new System.Drawing.Point(185, 119);
            this.cmbBuscarUsuario.Name = "cmbBuscarUsuario";
            this.cmbBuscarUsuario.Size = new System.Drawing.Size(308, 23);
            this.cmbBuscarUsuario.TabIndex = 41;
            this.cmbBuscarUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarUsuario_SelectedIndexChanged);
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuario.Location = new System.Drawing.Point(44, 122);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(51, 15);
            this.lblBuscarUsuario.TabIndex = 40;
            this.lblBuscarUsuario.Text = "Buscar:";
            // 
            // rbEliminarUsuario
            // 
            this.rbEliminarUsuario.AutoSize = true;
            this.rbEliminarUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEliminarUsuario.Location = new System.Drawing.Point(619, 61);
            this.rbEliminarUsuario.Name = "rbEliminarUsuario";
            this.rbEliminarUsuario.Size = new System.Drawing.Size(71, 19);
            this.rbEliminarUsuario.TabIndex = 38;
            this.rbEliminarUsuario.TabStop = true;
            this.rbEliminarUsuario.Text = "Eliminar";
            this.rbEliminarUsuario.UseVisualStyleBackColor = true;
            this.rbEliminarUsuario.CheckedChanged += new System.EventHandler(this.rbEliminarUsuario_CheckedChanged);
            // 
            // rbModificarUsuario
            // 
            this.rbModificarUsuario.AutoSize = true;
            this.rbModificarUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModificarUsuario.Location = new System.Drawing.Point(417, 61);
            this.rbModificarUsuario.Name = "rbModificarUsuario";
            this.rbModificarUsuario.Size = new System.Drawing.Size(76, 19);
            this.rbModificarUsuario.TabIndex = 37;
            this.rbModificarUsuario.TabStop = true;
            this.rbModificarUsuario.Text = "Modificar";
            this.rbModificarUsuario.UseVisualStyleBackColor = true;
            this.rbModificarUsuario.CheckedChanged += new System.EventHandler(this.rbModificarUsuario_CheckedChanged);
            // 
            // rbIngresaUsuario
            // 
            this.rbIngresaUsuario.AutoSize = true;
            this.rbIngresaUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresaUsuario.Location = new System.Drawing.Point(230, 61);
            this.rbIngresaUsuario.Name = "rbIngresaUsuario";
            this.rbIngresaUsuario.Size = new System.Drawing.Size(74, 19);
            this.rbIngresaUsuario.TabIndex = 36;
            this.rbIngresaUsuario.TabStop = true;
            this.rbIngresaUsuario.Text = "Ingresar";
            this.rbIngresaUsuario.UseVisualStyleBackColor = true;
            this.rbIngresaUsuario.CheckedChanged += new System.EventHandler(this.rbIngresaUsuario_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Seleccione una opción:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(198, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 56);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Seleccione un auditor:";
            // 
            // cmbSeleccionarAuditor
            // 
            this.cmbSeleccionarAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeleccionarAuditor.FormattingEnabled = true;
            this.cmbSeleccionarAuditor.Location = new System.Drawing.Point(185, 177);
            this.cmbSeleccionarAuditor.Name = "cmbSeleccionarAuditor";
            this.cmbSeleccionarAuditor.Size = new System.Drawing.Size(350, 23);
            this.cmbSeleccionarAuditor.TabIndex = 47;
            this.cmbSeleccionarAuditor.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccionarAuditor_SelectedIndexChanged);
            // 
            // txtIDAuditorUsuarios
            // 
            this.txtIDAuditorUsuarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAuditorUsuarios.Location = new System.Drawing.Point(639, 175);
            this.txtIDAuditorUsuarios.Name = "txtIDAuditorUsuarios";
            this.txtIDAuditorUsuarios.Size = new System.Drawing.Size(80, 21);
            this.txtIDAuditorUsuarios.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nivel de acceso:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 143);
            this.dataGridView1.TabIndex = 50;
            // 
            // btnAceptarUsuario
            // 
            this.btnAceptarUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarUsuario.Location = new System.Drawing.Point(644, 358);
            this.btnAceptarUsuario.Name = "btnAceptarUsuario";
            this.btnAceptarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarUsuario.TabIndex = 51;
            this.btnAceptarUsuario.Text = "Aceptar";
            this.btnAceptarUsuario.UseVisualStyleBackColor = true;
            this.btnAceptarUsuario.Click += new System.EventHandler(this.btnAceptarUsuario_Click);
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarUsuario.Location = new System.Drawing.Point(644, 406);
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarUsuario.TabIndex = 52;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarUsuario.Click += new System.EventHandler(this.btnCancelarUsuario_Click);
            // 
            // txtAliasUsuario
            // 
            this.txtAliasUsuario.Location = new System.Drawing.Point(185, 224);
            this.txtAliasUsuario.Name = "txtAliasUsuario";
            this.txtAliasUsuario.Size = new System.Drawing.Size(173, 20);
            this.txtAliasUsuario.TabIndex = 53;
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(473, 224);
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(173, 20);
            this.txtContraseñaUsuario.TabIndex = 54;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(185, 277);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(173, 21);
            this.cmbTipoUsuario.TabIndex = 55;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 483);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.txtContraseñaUsuario);
            this.Controls.Add(this.txtAliasUsuario);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.btnAceptarUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDAuditorUsuarios);
            this.Controls.Add(this.cmbSeleccionarAuditor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.cmbBuscarUsuario);
            this.Controls.Add(this.lblBuscarUsuario);
            this.Controls.Add(this.rbEliminarUsuario);
            this.Controls.Add(this.rbModificarUsuario);
            this.Controls.Add(this.rbIngresaUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.ComboBox cmbBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.RadioButton rbEliminarUsuario;
        private System.Windows.Forms.RadioButton rbModificarUsuario;
        private System.Windows.Forms.RadioButton rbIngresaUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeleccionarAuditor;
        private System.Windows.Forms.TextBox txtIDAuditorUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAceptarUsuario;
        private System.Windows.Forms.Button btnCancelarUsuario;
        private System.Windows.Forms.TextBox txtAliasUsuario;
        private System.Windows.Forms.TextBox txtContraseñaUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
    }
}