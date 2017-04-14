namespace sistema_auditoria.Otros
{
    partial class Sugerencias
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSugerencias = new System.Windows.Forms.DataGridView();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnEmitirReportesSugerencias = new System.Windows.Forms.Button();
            this.btnGuardarSugerencias = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDSugerencia = new System.Windows.Forms.TextBox();
            this.cmbBuscarSugerencia = new System.Windows.Forms.ComboBox();
            this.lblBuscarSugerencia = new System.Windows.Forms.Label();
            this.rbEliminarSugerencia = new System.Windows.Forms.RadioButton();
            this.rbIngresaSugerencia = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.data = new sistema_auditoria.Data();
            this.sugerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sugerTableAdapter = new sistema_auditoria.DataTableAdapters.SugerTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugerencias)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sugerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSugerencias);
            this.tabPage1.Controls.Add(this.btnMostrarInformacion);
            this.tabPage1.Controls.Add(this.cmbTipo);
            this.tabPage1.Controls.Add(this.txtFecha);
            this.tabPage1.Controls.Add(this.btnEmitirReportesSugerencias);
            this.tabPage1.Controls.Add(this.btnGuardarSugerencias);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtIDSugerencia);
            this.tabPage1.Controls.Add(this.cmbBuscarSugerencia);
            this.tabPage1.Controls.Add(this.lblBuscarSugerencia);
            this.tabPage1.Controls.Add(this.rbEliminarSugerencia);
            this.tabPage1.Controls.Add(this.rbIngresaSugerencia);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sugerencias/Errores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSugerencias
            // 
            this.dgvSugerencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugerencias.Location = new System.Drawing.Point(24, 258);
            this.dgvSugerencias.Name = "dgvSugerencias";
            this.dgvSugerencias.Size = new System.Drawing.Size(547, 150);
            this.dgvSugerencias.TabIndex = 65;
            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.Location = new System.Drawing.Point(616, 73);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(92, 41);
            this.btnMostrarInformacion.TabIndex = 64;
            this.btnMostrarInformacion.Text = "Mostrar Información";
            this.btnMostrarInformacion.UseVisualStyleBackColor = true;
            this.btnMostrarInformacion.Click += new System.EventHandler(this.btnMostrarInformacion_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(327, 125);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(331, 23);
            this.cmbTipo.TabIndex = 63;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(68, 125);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(183, 21);
            this.txtFecha.TabIndex = 62;
            // 
            // btnEmitirReportesSugerencias
            // 
            this.btnEmitirReportesSugerencias.Location = new System.Drawing.Point(608, 355);
            this.btnEmitirReportesSugerencias.Name = "btnEmitirReportesSugerencias";
            this.btnEmitirReportesSugerencias.Size = new System.Drawing.Size(118, 23);
            this.btnEmitirReportesSugerencias.TabIndex = 61;
            this.btnEmitirReportesSugerencias.Text = "Emitir Reporte";
            this.btnEmitirReportesSugerencias.UseVisualStyleBackColor = true;
            this.btnEmitirReportesSugerencias.Click += new System.EventHandler(this.btnEmitirReportesSugerencias_Click);
            // 
            // btnGuardarSugerencias
            // 
            this.btnGuardarSugerencias.Location = new System.Drawing.Point(608, 305);
            this.btnGuardarSugerencias.Name = "btnGuardarSugerencias";
            this.btnGuardarSugerencias.Size = new System.Drawing.Size(118, 23);
            this.btnGuardarSugerencias.TabIndex = 60;
            this.btnGuardarSugerencias.Text = "Guardar";
            this.btnGuardarSugerencias.UseVisualStyleBackColor = true;
            this.btnGuardarSugerencias.Click += new System.EventHandler(this.btnGuardarSugerencias_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 174);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(702, 67);
            this.txtDescripcion.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Descripción:";
            // 
            // txtIDSugerencia
            // 
            this.txtIDSugerencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDSugerencia.ForeColor = System.Drawing.Color.White;
            this.txtIDSugerencia.Location = new System.Drawing.Point(60, 55);
            this.txtIDSugerencia.Name = "txtIDSugerencia";
            this.txtIDSugerencia.Size = new System.Drawing.Size(100, 14);
            this.txtIDSugerencia.TabIndex = 57;
            this.txtIDSugerencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbBuscarSugerencia
            // 
            this.cmbBuscarSugerencia.FormattingEnabled = true;
            this.cmbBuscarSugerencia.Location = new System.Drawing.Point(215, 78);
            this.cmbBuscarSugerencia.Name = "cmbBuscarSugerencia";
            this.cmbBuscarSugerencia.Size = new System.Drawing.Size(331, 23);
            this.cmbBuscarSugerencia.TabIndex = 56;
            this.cmbBuscarSugerencia.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarSugerencia_SelectedIndexChanged);
            // 
            // lblBuscarSugerencia
            // 
            this.lblBuscarSugerencia.AutoSize = true;
            this.lblBuscarSugerencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarSugerencia.Location = new System.Drawing.Point(24, 86);
            this.lblBuscarSugerencia.Name = "lblBuscarSugerencia";
            this.lblBuscarSugerencia.Size = new System.Drawing.Size(185, 15);
            this.lblBuscarSugerencia.TabIndex = 55;
            this.lblBuscarSugerencia.Text = "Buscar sugerencia(Fecha):";
            // 
            // rbEliminarSugerencia
            // 
            this.rbEliminarSugerencia.AutoSize = true;
            this.rbEliminarSugerencia.BackColor = System.Drawing.Color.LightGray;
            this.rbEliminarSugerencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEliminarSugerencia.Location = new System.Drawing.Point(477, 32);
            this.rbEliminarSugerencia.Name = "rbEliminarSugerencia";
            this.rbEliminarSugerencia.Size = new System.Drawing.Size(79, 19);
            this.rbEliminarSugerencia.TabIndex = 53;
            this.rbEliminarSugerencia.TabStop = true;
            this.rbEliminarSugerencia.Text = "Eliminar";
            this.rbEliminarSugerencia.UseVisualStyleBackColor = false;
            this.rbEliminarSugerencia.CheckedChanged += new System.EventHandler(this.rbEliminarSugerencia_CheckedChanged);
            // 
            // rbIngresaSugerencia
            // 
            this.rbIngresaSugerencia.AutoSize = true;
            this.rbIngresaSugerencia.BackColor = System.Drawing.Color.LightGray;
            this.rbIngresaSugerencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresaSugerencia.Location = new System.Drawing.Point(297, 32);
            this.rbIngresaSugerencia.Name = "rbIngresaSugerencia";
            this.rbIngresaSugerencia.Size = new System.Drawing.Size(82, 19);
            this.rbIngresaSugerencia.TabIndex = 51;
            this.rbIngresaSugerencia.TabStop = true;
            this.rbIngresaSugerencia.Text = "Ingresar";
            this.rbIngresaSugerencia.UseVisualStyleBackColor = false;
            this.rbIngresaSugerencia.CheckedChanged += new System.EventHandler(this.rbIngresaSugerencia_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Seleccione una opción:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(205, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 46);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fecha:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sugerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistema_auditoria.RepoSugerencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(741, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sugerBindingSource
            // 
            this.sugerBindingSource.DataMember = "Suger";
            this.sugerBindingSource.DataSource = this.data;
            // 
            // sugerTableAdapter
            // 
            this.sugerTableAdapter.ClearBeforeFill = true;
            // 
            // Sugerencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "Sugerencias";
            this.Text = "Sugerencias";
            this.Load += new System.EventHandler(this.Sugerencias_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugerencias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sugerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEmitirReportesSugerencias;
        private System.Windows.Forms.Button btnGuardarSugerencias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDSugerencia;
        private System.Windows.Forms.ComboBox cmbBuscarSugerencia;
        private System.Windows.Forms.Label lblBuscarSugerencia;
        private System.Windows.Forms.RadioButton rbEliminarSugerencia;
        private System.Windows.Forms.RadioButton rbIngresaSugerencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSugerencias;
        private System.Windows.Forms.Button btnMostrarInformacion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtFecha;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Data data;
        private System.Windows.Forms.BindingSource sugerBindingSource;
        private DataTableAdapters.SugerTableAdapter sugerTableAdapter;
    }
}