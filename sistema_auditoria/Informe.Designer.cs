namespace sistema_auditoria
{
    partial class Informe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.filtraInformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new sistema_auditoria.Data();
            this.filtraConformidadesHallazgosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraFortalezasHallazgosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraOportunidadesHallazgosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraObservacionesHallazgosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraNoConformidadesHallazgosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraPlanInformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraAuditoriasInformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraProcesosInformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIDInformeActual = new System.Windows.Forms.TextBox();
            this.txtCodigoInforme = new System.Windows.Forms.TextBox();
            this.btnGeneraCódigoInforme = new System.Windows.Forms.Button();
            this.txtVersionInforme = new System.Windows.Forms.TextBox();
            this.btnSiguienteInforme = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaEmisionInforme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarInforme = new System.Windows.Forms.Button();
            this.dgvEquipoAuditorHallazgo = new System.Windows.Forms.DataGridView();
            this.dgvAlcanceAuditoriaHallazgo = new System.Windows.Forms.DataGridView();
            this.txtFechaProximaAuditoriaInforme = new System.Windows.Forms.TextBox();
            this.txtFechaAuditoriaInforme = new System.Windows.Forms.TextBox();
            this.txtCriterioAuditoriaHalalzgo = new System.Windows.Forms.TextBox();
            this.txtTipoAuditoriaHallazgo = new System.Windows.Forms.TextBox();
            this.txtIDAuditoria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OKPlanInforme = new System.Windows.Forms.CheckBox();
            this.btnMostrarInformación = new System.Windows.Forms.Button();
            this.txtIDPlan = new System.Windows.Forms.TextBox();
            this.cmbBuscarPlanInforme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtIDApartadoHallazgo = new System.Windows.Forms.TextBox();
            this.OKCapitulo = new System.Windows.Forms.CheckBox();
            this.txtIDCapitulo = new System.Windows.Forms.TextBox();
            this.btnGenerarReporteInforme = new System.Windows.Forms.Button();
            this.btnGuardarHallazgo = new System.Windows.Forms.Button();
            this.txtDescripcionHallazgo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbApartadoHallazgo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCapituloHallazgo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTipoHallazgo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbProcesoInformeHallazgo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.filtraInformeTableAdapter = new sistema_auditoria.DataTableAdapters.filtraInformeTableAdapter();
            this.filtraConformidadesHallazgosTableAdapter = new sistema_auditoria.DataTableAdapters.filtraConformidadesHallazgosTableAdapter();
            this.filtraFortalezasHallazgosTableAdapter = new sistema_auditoria.DataTableAdapters.filtraFortalezasHallazgosTableAdapter();
            this.filtraOportunidadesHallazgosTableAdapter = new sistema_auditoria.DataTableAdapters.filtraOportunidadesHallazgosTableAdapter();
            this.filtraObservacionesHallazgosTableAdapter = new sistema_auditoria.DataTableAdapters.filtraObservacionesHallazgosTableAdapter();
            this.filtraNoConformidadesHallazgosTableAdapter = new sistema_auditoria.DataTableAdapters.filtraNoConformidadesHallazgosTableAdapter();
            this.filtraProcesosInformeTableAdapter = new sistema_auditoria.DataTableAdapters.filtraProcesosInformeTableAdapter();
            this.filtraAuditoriasInformeTableAdapter = new sistema_auditoria.DataTableAdapters.filtraAuditoriasInformeTableAdapter();
            this.filtraPlanInformeTableAdapter = new sistema_auditoria.DataTableAdapters.filtraPlanInformeTableAdapter();
            this.filtraEquipoInformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraEquipoInformeTableAdapter = new sistema_auditoria.DataTableAdapters.filtraEquipoInformeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filtraInformeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraConformidadesHallazgosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraFortalezasHallazgosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraOportunidadesHallazgosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraObservacionesHallazgosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraNoConformidadesHallazgosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraPlanInformeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraAuditoriasInformeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraProcesosInformeBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoAuditorHallazgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcanceAuditoriaHallazgo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtraEquipoInformeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filtraInformeBindingSource
            // 
            this.filtraInformeBindingSource.DataMember = "filtraInforme";
            this.filtraInformeBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filtraConformidadesHallazgosBindingSource
            // 
            this.filtraConformidadesHallazgosBindingSource.DataMember = "filtraConformidadesHallazgos";
            this.filtraConformidadesHallazgosBindingSource.DataSource = this.data;
            // 
            // filtraFortalezasHallazgosBindingSource
            // 
            this.filtraFortalezasHallazgosBindingSource.DataMember = "filtraFortalezasHallazgos";
            this.filtraFortalezasHallazgosBindingSource.DataSource = this.data;
            // 
            // filtraOportunidadesHallazgosBindingSource
            // 
            this.filtraOportunidadesHallazgosBindingSource.DataMember = "filtraOportunidadesHallazgos";
            this.filtraOportunidadesHallazgosBindingSource.DataSource = this.data;
            // 
            // filtraObservacionesHallazgosBindingSource
            // 
            this.filtraObservacionesHallazgosBindingSource.DataMember = "filtraObservacionesHallazgos";
            this.filtraObservacionesHallazgosBindingSource.DataSource = this.data;
            // 
            // filtraNoConformidadesHallazgosBindingSource
            // 
            this.filtraNoConformidadesHallazgosBindingSource.DataMember = "filtraNoConformidadesHallazgos";
            this.filtraNoConformidadesHallazgosBindingSource.DataSource = this.data;
            // 
            // filtraPlanInformeBindingSource
            // 
            this.filtraPlanInformeBindingSource.DataMember = "filtraPlanInforme";
            this.filtraPlanInformeBindingSource.DataSource = this.data;
            // 
            // filtraAuditoriasInformeBindingSource
            // 
            this.filtraAuditoriasInformeBindingSource.DataMember = "filtraAuditoriasInforme";
            this.filtraAuditoriasInformeBindingSource.DataSource = this.data;
            // 
            // filtraProcesosInformeBindingSource
            // 
            this.filtraProcesosInformeBindingSource.DataMember = "filtraProcesosInforme";
            this.filtraProcesosInformeBindingSource.DataSource = this.data;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtIDInformeActual);
            this.tabPage1.Controls.Add(this.txtCodigoInforme);
            this.tabPage1.Controls.Add(this.btnGeneraCódigoInforme);
            this.tabPage1.Controls.Add(this.txtVersionInforme);
            this.tabPage1.Controls.Add(this.btnSiguienteInforme);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtFechaEmisionInforme);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnGuardarInforme);
            this.tabPage1.Controls.Add(this.dgvEquipoAuditorHallazgo);
            this.tabPage1.Controls.Add(this.dgvAlcanceAuditoriaHallazgo);
            this.tabPage1.Controls.Add(this.txtFechaProximaAuditoriaInforme);
            this.tabPage1.Controls.Add(this.txtFechaAuditoriaInforme);
            this.tabPage1.Controls.Add(this.txtCriterioAuditoriaHalalzgo);
            this.tabPage1.Controls.Add(this.txtTipoAuditoriaHallazgo);
            this.tabPage1.Controls.Add(this.txtIDAuditoria);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.OKPlanInforme);
            this.tabPage1.Controls.Add(this.btnMostrarInformación);
            this.tabPage1.Controls.Add(this.txtIDPlan);
            this.tabPage1.Controls.Add(this.cmbBuscarPlanInforme);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informe";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtIDInformeActual
            // 
            this.txtIDInformeActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDInformeActual.ForeColor = System.Drawing.Color.White;
            this.txtIDInformeActual.Location = new System.Drawing.Point(726, 406);
            this.txtIDInformeActual.Name = "txtIDInformeActual";
            this.txtIDInformeActual.Size = new System.Drawing.Size(100, 14);
            this.txtIDInformeActual.TabIndex = 72;
            // 
            // txtCodigoInforme
            // 
            this.txtCodigoInforme.Location = new System.Drawing.Point(75, 403);
            this.txtCodigoInforme.Name = "txtCodigoInforme";
            this.txtCodigoInforme.Size = new System.Drawing.Size(339, 21);
            this.txtCodigoInforme.TabIndex = 71;
            // 
            // btnGeneraCódigoInforme
            // 
            this.btnGeneraCódigoInforme.Location = new System.Drawing.Point(439, 401);
            this.btnGeneraCódigoInforme.Name = "btnGeneraCódigoInforme";
            this.btnGeneraCódigoInforme.Size = new System.Drawing.Size(103, 24);
            this.btnGeneraCódigoInforme.TabIndex = 70;
            this.btnGeneraCódigoInforme.Text = "Generar código";
            this.btnGeneraCódigoInforme.UseVisualStyleBackColor = true;
            this.btnGeneraCódigoInforme.Click += new System.EventHandler(this.btnGeneraCódigoInforme_Click);
            // 
            // txtVersionInforme
            // 
            this.txtVersionInforme.Location = new System.Drawing.Point(503, 364);
            this.txtVersionInforme.Name = "txtVersionInforme";
            this.txtVersionInforme.Size = new System.Drawing.Size(100, 21);
            this.txtVersionInforme.TabIndex = 69;
            // 
            // btnSiguienteInforme
            // 
            this.btnSiguienteInforme.Location = new System.Drawing.Point(439, 442);
            this.btnSiguienteInforme.Name = "btnSiguienteInforme";
            this.btnSiguienteInforme.Size = new System.Drawing.Size(180, 23);
            this.btnSiguienteInforme.TabIndex = 68;
            this.btnSiguienteInforme.Text = "Siguiente";
            this.btnSiguienteInforme.UseVisualStyleBackColor = true;
            this.btnSiguienteInforme.Click += new System.EventHandler(this.btnSiguienteInforme_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 67;
            this.label11.Text = "Código:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "Versión:";
            // 
            // txtFechaEmisionInforme
            // 
            this.txtFechaEmisionInforme.Location = new System.Drawing.Point(185, 367);
            this.txtFechaEmisionInforme.Name = "txtFechaEmisionInforme";
            this.txtFechaEmisionInforme.Size = new System.Drawing.Size(190, 21);
            this.txtFechaEmisionInforme.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Fecha emisión del informe:";
            // 
            // btnGuardarInforme
            // 
            this.btnGuardarInforme.Location = new System.Drawing.Point(234, 442);
            this.btnGuardarInforme.Name = "btnGuardarInforme";
            this.btnGuardarInforme.Size = new System.Drawing.Size(180, 23);
            this.btnGuardarInforme.TabIndex = 63;
            this.btnGuardarInforme.Text = "Guardar";
            this.btnGuardarInforme.UseVisualStyleBackColor = true;
            this.btnGuardarInforme.Click += new System.EventHandler(this.btnGuardarInforme_Click);
            // 
            // dgvEquipoAuditorHallazgo
            // 
            this.dgvEquipoAuditorHallazgo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipoAuditorHallazgo.Location = new System.Drawing.Point(437, 223);
            this.dgvEquipoAuditorHallazgo.Name = "dgvEquipoAuditorHallazgo";
            this.dgvEquipoAuditorHallazgo.Size = new System.Drawing.Size(388, 115);
            this.dgvEquipoAuditorHallazgo.TabIndex = 62;
            // 
            // dgvAlcanceAuditoriaHallazgo
            // 
            this.dgvAlcanceAuditoriaHallazgo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlcanceAuditoriaHallazgo.Location = new System.Drawing.Point(16, 223);
            this.dgvAlcanceAuditoriaHallazgo.Name = "dgvAlcanceAuditoriaHallazgo";
            this.dgvAlcanceAuditoriaHallazgo.Size = new System.Drawing.Size(397, 115);
            this.dgvAlcanceAuditoriaHallazgo.TabIndex = 61;
            // 
            // txtFechaProximaAuditoriaInforme
            // 
            this.txtFechaProximaAuditoriaInforme.Location = new System.Drawing.Point(621, 161);
            this.txtFechaProximaAuditoriaInforme.Name = "txtFechaProximaAuditoriaInforme";
            this.txtFechaProximaAuditoriaInforme.Size = new System.Drawing.Size(205, 21);
            this.txtFechaProximaAuditoriaInforme.TabIndex = 60;
            this.txtFechaProximaAuditoriaInforme.Text = "A confirmar";
            // 
            // txtFechaAuditoriaInforme
            // 
            this.txtFechaAuditoriaInforme.Location = new System.Drawing.Point(170, 161);
            this.txtFechaAuditoriaInforme.Name = "txtFechaAuditoriaInforme";
            this.txtFechaAuditoriaInforme.Size = new System.Drawing.Size(205, 21);
            this.txtFechaAuditoriaInforme.TabIndex = 59;
            // 
            // txtCriterioAuditoriaHalalzgo
            // 
            this.txtCriterioAuditoriaHalalzgo.Location = new System.Drawing.Point(169, 107);
            this.txtCriterioAuditoriaHalalzgo.Multiline = true;
            this.txtCriterioAuditoriaHalalzgo.Name = "txtCriterioAuditoriaHalalzgo";
            this.txtCriterioAuditoriaHalalzgo.Size = new System.Drawing.Size(656, 38);
            this.txtCriterioAuditoriaHalalzgo.TabIndex = 58;
            // 
            // txtTipoAuditoriaHallazgo
            // 
            this.txtTipoAuditoriaHallazgo.Location = new System.Drawing.Point(169, 69);
            this.txtTipoAuditoriaHallazgo.Name = "txtTipoAuditoriaHallazgo";
            this.txtTipoAuditoriaHallazgo.Size = new System.Drawing.Size(392, 21);
            this.txtTipoAuditoriaHallazgo.TabIndex = 57;
            // 
            // txtIDAuditoria
            // 
            this.txtIDAuditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDAuditoria.ForeColor = System.Drawing.Color.Transparent;
            this.txtIDAuditoria.Location = new System.Drawing.Point(727, 6);
            this.txtIDAuditoria.Name = "txtIDAuditoria";
            this.txtIDAuditoria.Size = new System.Drawing.Size(88, 14);
            this.txtIDAuditoria.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Equipo Auditor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Alcance de la auditoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Fecha de próxima auditoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fecha de la Auditoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Criterios de la Auditoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Auditoria (Tipo):";
            // 
            // OKPlanInforme
            // 
            this.OKPlanInforme.AutoSize = true;
            this.OKPlanInforme.Location = new System.Drawing.Point(657, 33);
            this.OKPlanInforme.Name = "OKPlanInforme";
            this.OKPlanInforme.Size = new System.Drawing.Size(43, 19);
            this.OKPlanInforme.TabIndex = 49;
            this.OKPlanInforme.Text = "OK";
            this.OKPlanInforme.UseVisualStyleBackColor = true;
            this.OKPlanInforme.CheckedChanged += new System.EventHandler(this.OKPlanInforme_CheckedChanged);
            // 
            // btnMostrarInformación
            // 
            this.btnMostrarInformación.Location = new System.Drawing.Point(706, 33);
            this.btnMostrarInformación.Name = "btnMostrarInformación";
            this.btnMostrarInformación.Size = new System.Drawing.Size(109, 39);
            this.btnMostrarInformación.TabIndex = 48;
            this.btnMostrarInformación.Text = "Mostrar Información";
            this.btnMostrarInformación.UseVisualStyleBackColor = true;
            this.btnMostrarInformación.Click += new System.EventHandler(this.btnMostrarInformación_Click);
            // 
            // txtIDPlan
            // 
            this.txtIDPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDPlan.ForeColor = System.Drawing.Color.Transparent;
            this.txtIDPlan.Location = new System.Drawing.Point(53, 6);
            this.txtIDPlan.Name = "txtIDPlan";
            this.txtIDPlan.Size = new System.Drawing.Size(100, 14);
            this.txtIDPlan.TabIndex = 47;
            // 
            // cmbBuscarPlanInforme
            // 
            this.cmbBuscarPlanInforme.FormattingEnabled = true;
            this.cmbBuscarPlanInforme.Location = new System.Drawing.Point(169, 29);
            this.cmbBuscarPlanInforme.Name = "cmbBuscarPlanInforme";
            this.cmbBuscarPlanInforme.Size = new System.Drawing.Size(472, 23);
            this.cmbBuscarPlanInforme.TabIndex = 46;
            this.cmbBuscarPlanInforme.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPlanInforme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Seleccione un plan:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtIDApartadoHallazgo);
            this.tabPage3.Controls.Add(this.OKCapitulo);
            this.tabPage3.Controls.Add(this.txtIDCapitulo);
            this.tabPage3.Controls.Add(this.btnGenerarReporteInforme);
            this.tabPage3.Controls.Add(this.btnGuardarHallazgo);
            this.tabPage3.Controls.Add(this.txtDescripcionHallazgo);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.cmbApartadoHallazgo);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.cmbCapituloHallazgo);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.cmbTipoHallazgo);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.cmbProcesoInformeHallazgo);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(842, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hallazgos";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // txtIDApartadoHallazgo
            // 
            this.txtIDApartadoHallazgo.BackColor = System.Drawing.Color.White;
            this.txtIDApartadoHallazgo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDApartadoHallazgo.ForeColor = System.Drawing.Color.White;
            this.txtIDApartadoHallazgo.Location = new System.Drawing.Point(657, 208);
            this.txtIDApartadoHallazgo.Name = "txtIDApartadoHallazgo";
            this.txtIDApartadoHallazgo.Size = new System.Drawing.Size(100, 14);
            this.txtIDApartadoHallazgo.TabIndex = 14;
            // 
            // OKCapitulo
            // 
            this.OKCapitulo.AutoSize = true;
            this.OKCapitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKCapitulo.Location = new System.Drawing.Point(596, 147);
            this.OKCapitulo.Name = "OKCapitulo";
            this.OKCapitulo.Size = new System.Drawing.Size(45, 19);
            this.OKCapitulo.TabIndex = 13;
            this.OKCapitulo.Text = "OK";
            this.OKCapitulo.UseVisualStyleBackColor = true;
            this.OKCapitulo.CheckedChanged += new System.EventHandler(this.OKCapitulo_CheckedChanged);
            // 
            // txtIDCapitulo
            // 
            this.txtIDCapitulo.BackColor = System.Drawing.Color.White;
            this.txtIDCapitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCapitulo.ForeColor = System.Drawing.Color.White;
            this.txtIDCapitulo.Location = new System.Drawing.Point(657, 145);
            this.txtIDCapitulo.Name = "txtIDCapitulo";
            this.txtIDCapitulo.Size = new System.Drawing.Size(100, 14);
            this.txtIDCapitulo.TabIndex = 12;
            // 
            // btnGenerarReporteInforme
            // 
            this.btnGenerarReporteInforme.Location = new System.Drawing.Point(451, 432);
            this.btnGenerarReporteInforme.Name = "btnGenerarReporteInforme";
            this.btnGenerarReporteInforme.Size = new System.Drawing.Size(179, 23);
            this.btnGenerarReporteInforme.TabIndex = 11;
            this.btnGenerarReporteInforme.Text = "Generar Reporte";
            this.btnGenerarReporteInforme.UseVisualStyleBackColor = true;
            this.btnGenerarReporteInforme.Click += new System.EventHandler(this.btnGenerarReporteInforme_Click);
            // 
            // btnGuardarHallazgo
            // 
            this.btnGuardarHallazgo.Location = new System.Drawing.Point(202, 432);
            this.btnGuardarHallazgo.Name = "btnGuardarHallazgo";
            this.btnGuardarHallazgo.Size = new System.Drawing.Size(179, 23);
            this.btnGuardarHallazgo.TabIndex = 10;
            this.btnGuardarHallazgo.Text = "Guardar";
            this.btnGuardarHallazgo.UseVisualStyleBackColor = true;
            this.btnGuardarHallazgo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescripcionHallazgo
            // 
            this.txtDescripcionHallazgo.Location = new System.Drawing.Point(47, 279);
            this.txtDescripcionHallazgo.Multiline = true;
            this.txtDescripcionHallazgo.Name = "txtDescripcionHallazgo";
            this.txtDescripcionHallazgo.Size = new System.Drawing.Size(710, 124);
            this.txtDescripcionHallazgo.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Descripción del hallazgo";
            // 
            // cmbApartadoHallazgo
            // 
            this.cmbApartadoHallazgo.FormattingEnabled = true;
            this.cmbApartadoHallazgo.Location = new System.Drawing.Point(44, 206);
            this.cmbApartadoHallazgo.Name = "cmbApartadoHallazgo";
            this.cmbApartadoHallazgo.Size = new System.Drawing.Size(535, 23);
            this.cmbApartadoHallazgo.TabIndex = 7;
            this.cmbApartadoHallazgo.SelectedIndexChanged += new System.EventHandler(this.cmbApartadoHallazgo_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Seleccione un apartado de la Norma:";
            // 
            // cmbCapituloHallazgo
            // 
            this.cmbCapituloHallazgo.FormattingEnabled = true;
            this.cmbCapituloHallazgo.Location = new System.Drawing.Point(44, 145);
            this.cmbCapituloHallazgo.Name = "cmbCapituloHallazgo";
            this.cmbCapituloHallazgo.Size = new System.Drawing.Size(535, 23);
            this.cmbCapituloHallazgo.TabIndex = 5;
            this.cmbCapituloHallazgo.SelectedIndexChanged += new System.EventHandler(this.cmbCapituloHallazgo_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(302, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Seleccione un Capítulo de la Norma ISO 9001:2008";
            // 
            // cmbTipoHallazgo
            // 
            this.cmbTipoHallazgo.FormattingEnabled = true;
            this.cmbTipoHallazgo.Location = new System.Drawing.Point(222, 74);
            this.cmbTipoHallazgo.Name = "cmbTipoHallazgo";
            this.cmbTipoHallazgo.Size = new System.Drawing.Size(535, 23);
            this.cmbTipoHallazgo.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Seleccionar tipo de hallazgo:";
            // 
            // cmbProcesoInformeHallazgo
            // 
            this.cmbProcesoInformeHallazgo.FormattingEnabled = true;
            this.cmbProcesoInformeHallazgo.Location = new System.Drawing.Point(222, 33);
            this.cmbProcesoInformeHallazgo.Name = "cmbProcesoInformeHallazgo";
            this.cmbProcesoInformeHallazgo.Size = new System.Drawing.Size(535, 23);
            this.cmbProcesoInformeHallazgo.TabIndex = 1;
            this.cmbProcesoInformeHallazgo.SelectedIndexChanged += new System.EventHandler(this.cmbProcesoInformeHallazgo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Seleccione un proceso:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(842, 480);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Reporte";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "informe";
            reportDataSource1.Value = this.filtraInformeBindingSource;
            reportDataSource2.Name = "HallazgoConformidad";
            reportDataSource2.Value = this.filtraConformidadesHallazgosBindingSource;
            reportDataSource3.Name = "HallazgoFortaleza";
            reportDataSource3.Value = this.filtraFortalezasHallazgosBindingSource;
            reportDataSource4.Name = "HallazgoOportunidad";
            reportDataSource4.Value = this.filtraOportunidadesHallazgosBindingSource;
            reportDataSource5.Name = "HallazgoObservaciones";
            reportDataSource5.Value = this.filtraObservacionesHallazgosBindingSource;
            reportDataSource6.Name = "HallazgoNoConformidad";
            reportDataSource6.Value = this.filtraNoConformidadesHallazgosBindingSource;
            reportDataSource7.Name = "planCriterio";
            reportDataSource7.Value = this.filtraPlanInformeBindingSource;
            reportDataSource8.Name = "tipoFechaAuditoria";
            reportDataSource8.Value = this.filtraAuditoriasInformeBindingSource;
            reportDataSource9.Name = "Alcance";
            reportDataSource9.Value = this.filtraProcesosInformeBindingSource;
            reportDataSource10.Name = "Equipo";
            reportDataSource10.Value = this.filtraEquipoInformeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistema_auditoria.RepoInforme.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(836, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // filtraInformeTableAdapter
            // 
            this.filtraInformeTableAdapter.ClearBeforeFill = true;
            // 
            // filtraConformidadesHallazgosTableAdapter
            // 
            this.filtraConformidadesHallazgosTableAdapter.ClearBeforeFill = true;
            // 
            // filtraFortalezasHallazgosTableAdapter
            // 
            this.filtraFortalezasHallazgosTableAdapter.ClearBeforeFill = true;
            // 
            // filtraOportunidadesHallazgosTableAdapter
            // 
            this.filtraOportunidadesHallazgosTableAdapter.ClearBeforeFill = true;
            // 
            // filtraObservacionesHallazgosTableAdapter
            // 
            this.filtraObservacionesHallazgosTableAdapter.ClearBeforeFill = true;
            // 
            // filtraNoConformidadesHallazgosTableAdapter
            // 
            this.filtraNoConformidadesHallazgosTableAdapter.ClearBeforeFill = true;
            // 
            // filtraProcesosInformeTableAdapter
            // 
            this.filtraProcesosInformeTableAdapter.ClearBeforeFill = true;
            // 
            // filtraAuditoriasInformeTableAdapter
            // 
            this.filtraAuditoriasInformeTableAdapter.ClearBeforeFill = true;
            // 
            // filtraPlanInformeTableAdapter
            // 
            this.filtraPlanInformeTableAdapter.ClearBeforeFill = true;
            // 
            // filtraEquipoInformeBindingSource
            // 
            this.filtraEquipoInformeBindingSource.DataMember = "filtraEquipoInforme";
            this.filtraEquipoInformeBindingSource.DataSource = this.data;
            // 
            // filtraEquipoInformeTableAdapter
            // 
            this.filtraEquipoInformeTableAdapter.ClearBeforeFill = true;
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "Informe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.Informe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filtraInformeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraConformidadesHallazgosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraFortalezasHallazgosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraOportunidadesHallazgosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraObservacionesHallazgosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraNoConformidadesHallazgosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraPlanInformeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraAuditoriasInformeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraProcesosInformeBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoAuditorHallazgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcanceAuditoriaHallazgo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filtraEquipoInformeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnGuardarInforme;
        private System.Windows.Forms.DataGridView dgvEquipoAuditorHallazgo;
        private System.Windows.Forms.DataGridView dgvAlcanceAuditoriaHallazgo;
        private System.Windows.Forms.TextBox txtFechaProximaAuditoriaInforme;
        private System.Windows.Forms.TextBox txtFechaAuditoriaInforme;
        private System.Windows.Forms.TextBox txtCriterioAuditoriaHalalzgo;
        private System.Windows.Forms.TextBox txtTipoAuditoriaHallazgo;
        private System.Windows.Forms.TextBox txtIDAuditoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox OKPlanInforme;
        private System.Windows.Forms.Button btnMostrarInformación;
        private System.Windows.Forms.TextBox txtIDPlan;
        private System.Windows.Forms.ComboBox cmbBuscarPlanInforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVersionInforme;
        private System.Windows.Forms.Button btnSiguienteInforme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaEmisionInforme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoInforme;
        private System.Windows.Forms.Button btnGeneraCódigoInforme;
        private System.Windows.Forms.TextBox txtIDInformeActual;
        private System.Windows.Forms.ComboBox cmbProcesoInformeHallazgo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGenerarReporteInforme;
        private System.Windows.Forms.Button btnGuardarHallazgo;
        private System.Windows.Forms.TextBox txtDescripcionHallazgo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbApartadoHallazgo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCapituloHallazgo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbTipoHallazgo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIDCapitulo;
        private System.Windows.Forms.CheckBox OKCapitulo;
        private System.Windows.Forms.TextBox txtIDApartadoHallazgo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource filtraInformeBindingSource;
        private Data data;
        private System.Windows.Forms.BindingSource filtraConformidadesHallazgosBindingSource;
        private System.Windows.Forms.BindingSource filtraFortalezasHallazgosBindingSource;
        private System.Windows.Forms.BindingSource filtraOportunidadesHallazgosBindingSource;
        private System.Windows.Forms.BindingSource filtraObservacionesHallazgosBindingSource;
        private System.Windows.Forms.BindingSource filtraNoConformidadesHallazgosBindingSource;
        
        private System.Windows.Forms.BindingSource filtraPlanInformeBindingSource;
        private System.Windows.Forms.BindingSource filtraAuditoriasInformeBindingSource;
        private System.Windows.Forms.BindingSource filtraProcesosInformeBindingSource;
        private DataTableAdapters.filtraInformeTableAdapter filtraInformeTableAdapter;
        private DataTableAdapters.filtraConformidadesHallazgosTableAdapter filtraConformidadesHallazgosTableAdapter;
        private DataTableAdapters.filtraFortalezasHallazgosTableAdapter filtraFortalezasHallazgosTableAdapter;
        private DataTableAdapters.filtraOportunidadesHallazgosTableAdapter filtraOportunidadesHallazgosTableAdapter;
        private DataTableAdapters.filtraObservacionesHallazgosTableAdapter filtraObservacionesHallazgosTableAdapter;
        private DataTableAdapters.filtraNoConformidadesHallazgosTableAdapter filtraNoConformidadesHallazgosTableAdapter;
       
        private DataTableAdapters.filtraProcesosInformeTableAdapter filtraProcesosInformeTableAdapter;
        private DataTableAdapters.filtraAuditoriasInformeTableAdapter filtraAuditoriasInformeTableAdapter;
        private DataTableAdapters.filtraPlanInformeTableAdapter filtraPlanInformeTableAdapter;
        private System.Windows.Forms.BindingSource filtraEquipoInformeBindingSource;
        private DataTableAdapters.filtraEquipoInformeTableAdapter filtraEquipoInformeTableAdapter;
    }
}