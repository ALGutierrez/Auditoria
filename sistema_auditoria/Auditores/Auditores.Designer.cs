namespace sistema_auditoria
{
    partial class Auditores
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
            this.rbEliminarAuditor = new System.Windows.Forms.RadioButton();
            this.rbModificarAuditor = new System.Windows.Forms.RadioButton();
            this.rbIngresaAuditor = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBuscarAuditor = new System.Windows.Forms.Label();
            this.cmbBuscarAuditor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarAuditor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAceptarAuditor = new System.Windows.Forms.Button();
            this.btnCancelarAuditor = new System.Windows.Forms.Button();
            this.txtNombreAuditor = new System.Windows.Forms.TextBox();
            this.txtApellidoAuditor = new System.Windows.Forms.TextBox();
            this.txtMailAuditor = new System.Windows.Forms.TextBox();
            this.txtCompetenciasAuditor = new System.Windows.Forms.TextBox();
            this.txtIDAuditor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEliminarAuditor
            // 
            this.rbEliminarAuditor.AutoSize = true;
            this.rbEliminarAuditor.BackColor = System.Drawing.Color.DarkGray;
            this.rbEliminarAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEliminarAuditor.Location = new System.Drawing.Point(619, 58);
            this.rbEliminarAuditor.Name = "rbEliminarAuditor";
            this.rbEliminarAuditor.Size = new System.Drawing.Size(79, 19);
            this.rbEliminarAuditor.TabIndex = 16;
            this.rbEliminarAuditor.TabStop = true;
            this.rbEliminarAuditor.Text = "Eliminar";
            this.rbEliminarAuditor.UseVisualStyleBackColor = false;
            this.rbEliminarAuditor.CheckedChanged += new System.EventHandler(this.rbEliminarAuditor_CheckedChanged);
            // 
            // rbModificarAuditor
            // 
            this.rbModificarAuditor.AutoSize = true;
            this.rbModificarAuditor.BackColor = System.Drawing.Color.DarkGray;
            this.rbModificarAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModificarAuditor.Location = new System.Drawing.Point(393, 58);
            this.rbModificarAuditor.Name = "rbModificarAuditor";
            this.rbModificarAuditor.Size = new System.Drawing.Size(136, 19);
            this.rbModificarAuditor.TabIndex = 15;
            this.rbModificarAuditor.TabStop = true;
            this.rbModificarAuditor.Text = "Modificar/Buscar";
            this.rbModificarAuditor.UseVisualStyleBackColor = false;
            this.rbModificarAuditor.CheckedChanged += new System.EventHandler(this.rbModificarAuditor_CheckedChanged);
            // 
            // rbIngresaAuditor
            // 
            this.rbIngresaAuditor.AutoSize = true;
            this.rbIngresaAuditor.BackColor = System.Drawing.Color.DarkGray;
            this.rbIngresaAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresaAuditor.Location = new System.Drawing.Point(230, 58);
            this.rbIngresaAuditor.Name = "rbIngresaAuditor";
            this.rbIngresaAuditor.Size = new System.Drawing.Size(82, 19);
            this.rbIngresaAuditor.TabIndex = 14;
            this.rbIngresaAuditor.TabStop = true;
            this.rbIngresaAuditor.Text = "Ingresar";
            this.rbIngresaAuditor.UseVisualStyleBackColor = false;
            this.rbIngresaAuditor.CheckedChanged += new System.EventHandler(this.rbIngresaAuditor_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Seleccione una opción:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(198, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 56);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblBuscarAuditor
            // 
            this.lblBuscarAuditor.AutoSize = true;
            this.lblBuscarAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarAuditor.Location = new System.Drawing.Point(44, 119);
            this.lblBuscarAuditor.Name = "lblBuscarAuditor";
            this.lblBuscarAuditor.Size = new System.Drawing.Size(51, 15);
            this.lblBuscarAuditor.TabIndex = 18;
            this.lblBuscarAuditor.Text = "Buscar:";
            // 
            // cmbBuscarAuditor
            // 
            this.cmbBuscarAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarAuditor.FormattingEnabled = true;
            this.cmbBuscarAuditor.Location = new System.Drawing.Point(102, 116);
            this.cmbBuscarAuditor.Name = "cmbBuscarAuditor";
            this.cmbBuscarAuditor.Size = new System.Drawing.Size(391, 23);
            this.cmbBuscarAuditor.TabIndex = 19;
            this.cmbBuscarAuditor.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarAuditor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Competencias:";
            // 
            // btnBuscarAuditor
            // 
            this.btnBuscarAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAuditor.Location = new System.Drawing.Point(531, 119);
            this.btnBuscarAuditor.Name = "btnBuscarAuditor";
            this.btnBuscarAuditor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAuditor.TabIndex = 25;
            this.btnBuscarAuditor.Text = "Buscar";
            this.btnBuscarAuditor.UseVisualStyleBackColor = true;
            this.btnBuscarAuditor.Click += new System.EventHandler(this.btnBuscarAuditor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnAceptarAuditor
            // 
            this.btnAceptarAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarAuditor.Location = new System.Drawing.Point(619, 370);
            this.btnAceptarAuditor.Name = "btnAceptarAuditor";
            this.btnAceptarAuditor.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAuditor.TabIndex = 27;
            this.btnAceptarAuditor.Text = "Aceptar";
            this.btnAceptarAuditor.UseVisualStyleBackColor = true;
            this.btnAceptarAuditor.Click += new System.EventHandler(this.btnAceptarAuditor_Click);
            // 
            // btnCancelarAuditor
            // 
            this.btnCancelarAuditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAuditor.Location = new System.Drawing.Point(619, 422);
            this.btnCancelarAuditor.Name = "btnCancelarAuditor";
            this.btnCancelarAuditor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAuditor.TabIndex = 28;
            this.btnCancelarAuditor.Text = "Cancelar";
            this.btnCancelarAuditor.UseVisualStyleBackColor = true;
            this.btnCancelarAuditor.Click += new System.EventHandler(this.btnCancelarAuditor_Click);
            // 
            // txtNombreAuditor
            // 
            this.txtNombreAuditor.Location = new System.Drawing.Point(102, 166);
            this.txtNombreAuditor.Name = "txtNombreAuditor";
            this.txtNombreAuditor.Size = new System.Drawing.Size(283, 20);
            this.txtNombreAuditor.TabIndex = 29;
            // 
            // txtApellidoAuditor
            // 
            this.txtApellidoAuditor.Location = new System.Drawing.Point(486, 166);
            this.txtApellidoAuditor.Name = "txtApellidoAuditor";
            this.txtApellidoAuditor.Size = new System.Drawing.Size(233, 20);
            this.txtApellidoAuditor.TabIndex = 30;
            // 
            // txtMailAuditor
            // 
            this.txtMailAuditor.Location = new System.Drawing.Point(102, 213);
            this.txtMailAuditor.Name = "txtMailAuditor";
            this.txtMailAuditor.Size = new System.Drawing.Size(283, 20);
            this.txtMailAuditor.TabIndex = 31;
            // 
            // txtCompetenciasAuditor
            // 
            this.txtCompetenciasAuditor.Location = new System.Drawing.Point(137, 254);
            this.txtCompetenciasAuditor.Multiline = true;
            this.txtCompetenciasAuditor.Name = "txtCompetenciasAuditor";
            this.txtCompetenciasAuditor.Size = new System.Drawing.Size(582, 56);
            this.txtCompetenciasAuditor.TabIndex = 33;
            // 
            // txtIDAuditor
            // 
            this.txtIDAuditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDAuditor.ForeColor = System.Drawing.Color.White;
            this.txtIDAuditor.Location = new System.Drawing.Point(639, 122);
            this.txtIDAuditor.Name = "txtIDAuditor";
            this.txtIDAuditor.Size = new System.Drawing.Size(80, 13);
            this.txtIDAuditor.TabIndex = 34;
            // 
            // Auditores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 494);
            this.Controls.Add(this.txtIDAuditor);
            this.Controls.Add(this.txtCompetenciasAuditor);
            this.Controls.Add(this.txtMailAuditor);
            this.Controls.Add(this.txtApellidoAuditor);
            this.Controls.Add(this.txtNombreAuditor);
            this.Controls.Add(this.btnCancelarAuditor);
            this.Controls.Add(this.btnAceptarAuditor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarAuditor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBuscarAuditor);
            this.Controls.Add(this.lblBuscarAuditor);
            this.Controls.Add(this.rbEliminarAuditor);
            this.Controls.Add(this.rbModificarAuditor);
            this.Controls.Add(this.rbIngresaAuditor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Auditores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditores";
            this.Load += new System.EventHandler(this.Auditores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEliminarAuditor;
        private System.Windows.Forms.RadioButton rbModificarAuditor;
        private System.Windows.Forms.RadioButton rbIngresaAuditor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBuscarAuditor;
        private System.Windows.Forms.ComboBox cmbBuscarAuditor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarAuditor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAceptarAuditor;
        private System.Windows.Forms.Button btnCancelarAuditor;
        private System.Windows.Forms.TextBox txtNombreAuditor;
        private System.Windows.Forms.TextBox txtApellidoAuditor;
        private System.Windows.Forms.TextBox txtMailAuditor;
        private System.Windows.Forms.TextBox txtCompetenciasAuditor;
        private System.Windows.Forms.TextBox txtIDAuditor;
    }
}