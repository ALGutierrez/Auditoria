namespace sistema_auditoria
{
    partial class Procesos
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
            this.rbEliminarProceso = new System.Windows.Forms.RadioButton();
            this.rbModificarProceso = new System.Windows.Forms.RadioButton();
            this.rbIngresaProceso = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBuscarProceso = new System.Windows.Forms.Label();
            this.cmbBuscarTipo = new System.Windows.Forms.ComboBox();
            this.lblBuscarTipo = new System.Windows.Forms.Label();
            this.lblBuscaNombre = new System.Windows.Forms.Label();
            this.cmbNombreProceso = new System.Windows.Forms.ComboBox();
            this.btnMostrarInformacionProceso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAceptarProceso = new System.Windows.Forms.Button();
            this.btnCancelarProceso = new System.Windows.Forms.Button();
            this.cmbTipoProceso = new System.Windows.Forms.ComboBox();
            this.txtNombreProceso = new System.Windows.Forms.TextBox();
            this.txtResponsableProceso = new System.Windows.Forms.TextBox();
            this.txtCodigoProceso = new System.Windows.Forms.TextBox();
            this.txtIDProceso = new System.Windows.Forms.TextBox();
            this.txtIDTipo = new System.Windows.Forms.TextBox();
            this.txtIDTipo2 = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEliminarProceso
            // 
            this.rbEliminarProceso.AutoSize = true;
            this.rbEliminarProceso.BackColor = System.Drawing.Color.DarkGray;
            this.rbEliminarProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEliminarProceso.Location = new System.Drawing.Point(619, 53);
            this.rbEliminarProceso.Name = "rbEliminarProceso";
            this.rbEliminarProceso.Size = new System.Drawing.Size(79, 19);
            this.rbEliminarProceso.TabIndex = 21;
            this.rbEliminarProceso.TabStop = true;
            this.rbEliminarProceso.Text = "Eliminar";
            this.rbEliminarProceso.UseVisualStyleBackColor = false;
            this.rbEliminarProceso.CheckedChanged += new System.EventHandler(this.rbEliminarProceso_CheckedChanged);
            // 
            // rbModificarProceso
            // 
            this.rbModificarProceso.AutoSize = true;
            this.rbModificarProceso.BackColor = System.Drawing.Color.DarkGray;
            this.rbModificarProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModificarProceso.Location = new System.Drawing.Point(417, 53);
            this.rbModificarProceso.Name = "rbModificarProceso";
            this.rbModificarProceso.Size = new System.Drawing.Size(136, 19);
            this.rbModificarProceso.TabIndex = 20;
            this.rbModificarProceso.TabStop = true;
            this.rbModificarProceso.Text = "Modificar/Buscar";
            this.rbModificarProceso.UseVisualStyleBackColor = false;
            this.rbModificarProceso.CheckedChanged += new System.EventHandler(this.rbModificarProceso_CheckedChanged);
            // 
            // rbIngresaProceso
            // 
            this.rbIngresaProceso.AutoSize = true;
            this.rbIngresaProceso.BackColor = System.Drawing.Color.DarkGray;
            this.rbIngresaProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresaProceso.Location = new System.Drawing.Point(230, 53);
            this.rbIngresaProceso.Name = "rbIngresaProceso";
            this.rbIngresaProceso.Size = new System.Drawing.Size(82, 19);
            this.rbIngresaProceso.TabIndex = 19;
            this.rbIngresaProceso.TabStop = true;
            this.rbIngresaProceso.Text = "Ingresar";
            this.rbIngresaProceso.UseVisualStyleBackColor = false;
            this.rbIngresaProceso.CheckedChanged += new System.EventHandler(this.rbIngresaProceso_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Seleccione una opción:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(198, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 56);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // lblBuscarProceso
            // 
            this.lblBuscarProceso.AutoSize = true;
            this.lblBuscarProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProceso.Location = new System.Drawing.Point(12, 96);
            this.lblBuscarProceso.Name = "lblBuscarProceso";
            this.lblBuscarProceso.Size = new System.Drawing.Size(115, 15);
            this.lblBuscarProceso.TabIndex = 23;
            this.lblBuscarProceso.Text = "Buscar proceso:";
            this.lblBuscarProceso.Click += new System.EventHandler(this.lblBuscarProceso_Click);
            // 
            // cmbBuscarTipo
            // 
            this.cmbBuscarTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarTipo.FormattingEnabled = true;
            this.cmbBuscarTipo.Location = new System.Drawing.Point(110, 136);
            this.cmbBuscarTipo.Name = "cmbBuscarTipo";
            this.cmbBuscarTipo.Size = new System.Drawing.Size(234, 23);
            this.cmbBuscarTipo.TabIndex = 24;
            this.cmbBuscarTipo.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarTipo_SelectedIndexChanged);
            // 
            // lblBuscarTipo
            // 
            this.lblBuscarTipo.AutoSize = true;
            this.lblBuscarTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarTipo.Location = new System.Drawing.Point(12, 136);
            this.lblBuscarTipo.Name = "lblBuscarTipo";
            this.lblBuscarTipo.Size = new System.Drawing.Size(36, 15);
            this.lblBuscarTipo.TabIndex = 26;
            this.lblBuscarTipo.Text = "Tipo:";
            // 
            // lblBuscaNombre
            // 
            this.lblBuscaNombre.AutoSize = true;
            this.lblBuscaNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaNombre.Location = new System.Drawing.Point(12, 173);
            this.lblBuscaNombre.Name = "lblBuscaNombre";
            this.lblBuscaNombre.Size = new System.Drawing.Size(57, 15);
            this.lblBuscaNombre.TabIndex = 27;
            this.lblBuscaNombre.Text = "Nombre:";
            // 
            // cmbNombreProceso
            // 
            this.cmbNombreProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreProceso.FormattingEnabled = true;
            this.cmbNombreProceso.Location = new System.Drawing.Point(110, 167);
            this.cmbNombreProceso.Name = "cmbNombreProceso";
            this.cmbNombreProceso.Size = new System.Drawing.Size(521, 23);
            this.cmbNombreProceso.TabIndex = 28;
            this.cmbNombreProceso.SelectedIndexChanged += new System.EventHandler(this.cmbNombreProceso_SelectedIndexChanged);
            // 
            // btnMostrarInformacionProceso
            // 
            this.btnMostrarInformacionProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInformacionProceso.Location = new System.Drawing.Point(644, 148);
            this.btnMostrarInformacionProceso.Name = "btnMostrarInformacionProceso";
            this.btnMostrarInformacionProceso.Size = new System.Drawing.Size(107, 42);
            this.btnMostrarInformacionProceso.TabIndex = 29;
            this.btnMostrarInformacionProceso.Text = "Mostrar Información";
            this.btnMostrarInformacionProceso.UseVisualStyleBackColor = true;
            this.btnMostrarInformacionProceso.Click += new System.EventHandler(this.btnMostrarInformacionProceso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Responsable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Código:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // btnAceptarProceso
            // 
            this.btnAceptarProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarProceso.Location = new System.Drawing.Point(657, 341);
            this.btnAceptarProceso.Name = "btnAceptarProceso";
            this.btnAceptarProceso.Size = new System.Drawing.Size(82, 23);
            this.btnAceptarProceso.TabIndex = 35;
            this.btnAceptarProceso.Text = "Aceptar";
            this.btnAceptarProceso.UseVisualStyleBackColor = true;
            this.btnAceptarProceso.Click += new System.EventHandler(this.btnAceptarProceso_Click);
            // 
            // btnCancelarProceso
            // 
            this.btnCancelarProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProceso.Location = new System.Drawing.Point(657, 403);
            this.btnCancelarProceso.Name = "btnCancelarProceso";
            this.btnCancelarProceso.Size = new System.Drawing.Size(82, 23);
            this.btnCancelarProceso.TabIndex = 36;
            this.btnCancelarProceso.Text = "Cancelar";
            this.btnCancelarProceso.UseVisualStyleBackColor = true;
            this.btnCancelarProceso.Click += new System.EventHandler(this.btnCancelarProceso_Click);
            // 
            // cmbTipoProceso
            // 
            this.cmbTipoProceso.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoProceso.FormattingEnabled = true;
            this.cmbTipoProceso.Location = new System.Drawing.Point(110, 210);
            this.cmbTipoProceso.Name = "cmbTipoProceso";
            this.cmbTipoProceso.Size = new System.Drawing.Size(234, 23);
            this.cmbTipoProceso.TabIndex = 37;
            this.cmbTipoProceso.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProceso_SelectedIndexChanged);
            // 
            // txtNombreProceso
            // 
            this.txtNombreProceso.Location = new System.Drawing.Point(110, 243);
            this.txtNombreProceso.Name = "txtNombreProceso";
            this.txtNombreProceso.Size = new System.Drawing.Size(521, 20);
            this.txtNombreProceso.TabIndex = 38;
            // 
            // txtResponsableProceso
            // 
            this.txtResponsableProceso.Location = new System.Drawing.Point(110, 272);
            this.txtResponsableProceso.Name = "txtResponsableProceso";
            this.txtResponsableProceso.Size = new System.Drawing.Size(298, 20);
            this.txtResponsableProceso.TabIndex = 39;
            // 
            // txtCodigoProceso
            // 
            this.txtCodigoProceso.Location = new System.Drawing.Point(472, 273);
            this.txtCodigoProceso.Name = "txtCodigoProceso";
            this.txtCodigoProceso.Size = new System.Drawing.Size(159, 20);
            this.txtCodigoProceso.TabIndex = 40;
            // 
            // txtIDProceso
            // 
            this.txtIDProceso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDProceso.ForeColor = System.Drawing.Color.White;
            this.txtIDProceso.Location = new System.Drawing.Point(546, 134);
            this.txtIDProceso.Name = "txtIDProceso";
            this.txtIDProceso.Size = new System.Drawing.Size(84, 13);
            this.txtIDProceso.TabIndex = 41;
            // 
            // txtIDTipo
            // 
            this.txtIDTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDTipo.ForeColor = System.Drawing.Color.White;
            this.txtIDTipo.Location = new System.Drawing.Point(421, 134);
            this.txtIDTipo.Name = "txtIDTipo";
            this.txtIDTipo.Size = new System.Drawing.Size(100, 13);
            this.txtIDTipo.TabIndex = 42;
            // 
            // txtIDTipo2
            // 
            this.txtIDTipo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDTipo2.ForeColor = System.Drawing.Color.White;
            this.txtIDTipo2.Location = new System.Drawing.Point(382, 211);
            this.txtIDTipo2.Name = "txtIDTipo2";
            this.txtIDTipo2.Size = new System.Drawing.Size(100, 13);
            this.txtIDTipo2.TabIndex = 43;
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(365, 138);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(43, 19);
            this.OK.TabIndex = 44;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.CheckedChanged += new System.EventHandler(this.OK_CheckedChanged);
            // 
            // Procesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 477);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtIDTipo2);
            this.Controls.Add(this.txtIDTipo);
            this.Controls.Add(this.txtIDProceso);
            this.Controls.Add(this.txtCodigoProceso);
            this.Controls.Add(this.txtResponsableProceso);
            this.Controls.Add(this.txtNombreProceso);
            this.Controls.Add(this.cmbTipoProceso);
            this.Controls.Add(this.btnCancelarProceso);
            this.Controls.Add(this.btnAceptarProceso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarInformacionProceso);
            this.Controls.Add(this.cmbNombreProceso);
            this.Controls.Add(this.lblBuscaNombre);
            this.Controls.Add(this.lblBuscarTipo);
            this.Controls.Add(this.cmbBuscarTipo);
            this.Controls.Add(this.lblBuscarProceso);
            this.Controls.Add(this.rbEliminarProceso);
            this.Controls.Add(this.rbModificarProceso);
            this.Controls.Add(this.rbIngresaProceso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Procesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesos";
            this.Load += new System.EventHandler(this.Procesos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEliminarProceso;
        private System.Windows.Forms.RadioButton rbModificarProceso;
        private System.Windows.Forms.RadioButton rbIngresaProceso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBuscarProceso;
        private System.Windows.Forms.ComboBox cmbBuscarTipo;
        private System.Windows.Forms.Label lblBuscarTipo;
        private System.Windows.Forms.Label lblBuscaNombre;
        private System.Windows.Forms.ComboBox cmbNombreProceso;
        private System.Windows.Forms.Button btnMostrarInformacionProceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAceptarProceso;
        private System.Windows.Forms.Button btnCancelarProceso;
        private System.Windows.Forms.ComboBox cmbTipoProceso;
        private System.Windows.Forms.TextBox txtNombreProceso;
        private System.Windows.Forms.TextBox txtResponsableProceso;
        private System.Windows.Forms.TextBox txtCodigoProceso;
        private System.Windows.Forms.TextBox txtIDProceso;
        private System.Windows.Forms.TextBox txtIDTipo;
        private System.Windows.Forms.TextBox txtIDTipo2;
        private System.Windows.Forms.CheckBox OK;
    }
}