namespace sistema_auditoria
{
    partial class Plan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.filtraFechasPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new sistema_auditoria.Data();
            this.filtraPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraVerifPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraAudiPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtraProPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OKPrograma = new System.Windows.Forms.CheckBox();
            this.btnMostrarInformacionPlan = new System.Windows.Forms.Button();
            this.btnSiguientePlan = new System.Windows.Forms.Button();
            this.btnGuardarPlan = new System.Windows.Forms.Button();
            this.dgvEquipoAuditoriaPlan = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAlcanceAuditoriaPlan = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaEfectivaAuditoriaPlan = new System.Windows.Forms.TextBox();
            this.txtFechaPlanificadaAuditoriaPlan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDAuditoriaPlan = new System.Windows.Forms.TextBox();
            this.cmbTituloAuditoriaPlan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDProgramaPlan = new System.Windows.Forms.TextBox();
            this.cmbAñoProgramaPlan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEliminarPlan = new System.Windows.Forms.RadioButton();
            this.rbModificarPlan = new System.Windows.Forms.RadioButton();
            this.rbIngresaPlan = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIDProgramaActualPlan = new System.Windows.Forms.TextBox();
            this.txtIDAuditoriaActualPlan = new System.Windows.Forms.TextBox();
            this.txtIDPlanActual = new System.Windows.Forms.TextBox();
            this.btnSiguienteDetallePlan = new System.Windows.Forms.Button();
            this.btnGuardarDetallePlan = new System.Windows.Forms.Button();
            this.txtCriterioPlan = new System.Windows.Forms.TextBox();
            this.txtLugarPlan = new System.Windows.Forms.TextBox();
            this.txtObjetivosPlan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigoPlan = new System.Windows.Forms.TextBox();
            this.txtVersionPlan = new System.Windows.Forms.TextBox();
            this.btnGeneraCódigoPlan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscarPlan = new System.Windows.Forms.Button();
            this.txtIDPlan = new System.Windows.Forms.TextBox();
            this.cmbBuscarPlanDetallePlan = new System.Windows.Forms.ComboBox();
            this.lblBuscarPlan = new System.Windows.Forms.Label();
            this.txtFechaEmisionPlan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnGuardarVerificaciones = new System.Windows.Forms.Button();
            this.txtQuejasPlan = new System.Windows.Forms.TextBox();
            this.txtMejoraContinuaPlan = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.filtraFechasPlanesTableAdapter = new sistema_auditoria.DataTableAdapters.filtraFechasPlanesTableAdapter();
            this.filtraPlanTableAdapter = new sistema_auditoria.DataTableAdapters.filtraPlanTableAdapter();
            this.filtraVerifPlanTableAdapter = new sistema_auditoria.DataTableAdapters.filtraVerifPlanTableAdapter();
            this.filtraAudiPlanTableAdapter = new sistema_auditoria.DataTableAdapters.filtraAudiPlanTableAdapter();
            this.filtraProPlanTableAdapter = new sistema_auditoria.DataTableAdapters.filtraProPlanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filtraFechasPlanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraVerifPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraAudiPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraProPlanBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoAuditoriaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcanceAuditoriaPlan)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtraFechasPlanesBindingSource
            // 
            this.filtraFechasPlanesBindingSource.DataMember = "filtraFechasPlanes";
            this.filtraFechasPlanesBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filtraPlanBindingSource
            // 
            this.filtraPlanBindingSource.DataMember = "filtraPlan";
            this.filtraPlanBindingSource.DataSource = this.data;
            // 
            // filtraVerifPlanBindingSource
            // 
            this.filtraVerifPlanBindingSource.DataMember = "filtraVerifPlan";
            this.filtraVerifPlanBindingSource.DataSource = this.data;
            // 
            // filtraAudiPlanBindingSource
            // 
            this.filtraAudiPlanBindingSource.DataMember = "filtraAudiPlan";
            this.filtraAudiPlanBindingSource.DataSource = this.data;
            // 
            // filtraProPlanBindingSource
            // 
            this.filtraProPlanBindingSource.DataMember = "filtraProPlan";
            this.filtraProPlanBindingSource.DataSource = this.data;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OKPrograma);
            this.tabPage1.Controls.Add(this.btnMostrarInformacionPlan);
            this.tabPage1.Controls.Add(this.btnSiguientePlan);
            this.tabPage1.Controls.Add(this.btnGuardarPlan);
            this.tabPage1.Controls.Add(this.dgvEquipoAuditoriaPlan);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dgvAlcanceAuditoriaPlan);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtFechaEfectivaAuditoriaPlan);
            this.tabPage1.Controls.Add(this.txtFechaPlanificadaAuditoriaPlan);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtIDAuditoriaPlan);
            this.tabPage1.Controls.Add(this.cmbTituloAuditoriaPlan);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtIDProgramaPlan);
            this.tabPage1.Controls.Add(this.cmbAñoProgramaPlan);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbEliminarPlan);
            this.tabPage1.Controls.Add(this.rbModificarPlan);
            this.tabPage1.Controls.Add(this.rbIngresaPlan);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OKPrograma
            // 
            this.OKPrograma.AutoSize = true;
            this.OKPrograma.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKPrograma.Location = new System.Drawing.Point(415, 100);
            this.OKPrograma.Name = "OKPrograma";
            this.OKPrograma.Size = new System.Drawing.Size(45, 19);
            this.OKPrograma.TabIndex = 64;
            this.OKPrograma.Text = "OK";
            this.OKPrograma.UseVisualStyleBackColor = true;
            this.OKPrograma.CheckedChanged += new System.EventHandler(this.OKPrograma_CheckedChanged);
            // 
            // btnMostrarInformacionPlan
            // 
            this.btnMostrarInformacionPlan.Location = new System.Drawing.Point(635, 134);
            this.btnMostrarInformacionPlan.Name = "btnMostrarInformacionPlan";
            this.btnMostrarInformacionPlan.Size = new System.Drawing.Size(137, 23);
            this.btnMostrarInformacionPlan.TabIndex = 63;
            this.btnMostrarInformacionPlan.Text = "Mostrar información";
            this.btnMostrarInformacionPlan.UseVisualStyleBackColor = true;
            this.btnMostrarInformacionPlan.Click += new System.EventHandler(this.btnMostrarInformacionPlan_Click);
            // 
            // btnSiguientePlan
            // 
            this.btnSiguientePlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientePlan.Location = new System.Drawing.Point(442, 437);
            this.btnSiguientePlan.Name = "btnSiguientePlan";
            this.btnSiguientePlan.Size = new System.Drawing.Size(100, 23);
            this.btnSiguientePlan.TabIndex = 62;
            this.btnSiguientePlan.Text = "Siguiente";
            this.btnSiguientePlan.UseVisualStyleBackColor = true;
            this.btnSiguientePlan.Click += new System.EventHandler(this.btnSiguientePlan_Click);
            // 
            // btnGuardarPlan
            // 
            this.btnGuardarPlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPlan.Location = new System.Drawing.Point(277, 437);
            this.btnGuardarPlan.Name = "btnGuardarPlan";
            this.btnGuardarPlan.Size = new System.Drawing.Size(84, 23);
            this.btnGuardarPlan.TabIndex = 61;
            this.btnGuardarPlan.Text = "Guardar";
            this.btnGuardarPlan.UseVisualStyleBackColor = true;
            // 
            // dgvEquipoAuditoriaPlan
            // 
            this.dgvEquipoAuditoriaPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipoAuditoriaPlan.Location = new System.Drawing.Point(16, 349);
            this.dgvEquipoAuditoriaPlan.Name = "dgvEquipoAuditoriaPlan";
            this.dgvEquipoAuditoriaPlan.Size = new System.Drawing.Size(486, 65);
            this.dgvEquipoAuditoriaPlan.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 59;
            this.label9.Text = "Equipo auditor:";
            // 
            // dgvAlcanceAuditoriaPlan
            // 
            this.dgvAlcanceAuditoriaPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlcanceAuditoriaPlan.Location = new System.Drawing.Point(16, 255);
            this.dgvAlcanceAuditoriaPlan.Name = "dgvAlcanceAuditoriaPlan";
            this.dgvAlcanceAuditoriaPlan.Size = new System.Drawing.Size(756, 73);
            this.dgvAlcanceAuditoriaPlan.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Alcance (Procesos a Auditar)";
            // 
            // txtFechaEfectivaAuditoriaPlan
            // 
            this.txtFechaEfectivaAuditoriaPlan.Location = new System.Drawing.Point(221, 201);
            this.txtFechaEfectivaAuditoriaPlan.Name = "txtFechaEfectivaAuditoriaPlan";
            this.txtFechaEfectivaAuditoriaPlan.Size = new System.Drawing.Size(140, 21);
            this.txtFechaEfectivaAuditoriaPlan.TabIndex = 55;
            // 
            // txtFechaPlanificadaAuditoriaPlan
            // 
            this.txtFechaPlanificadaAuditoriaPlan.Location = new System.Drawing.Point(221, 171);
            this.txtFechaPlanificadaAuditoriaPlan.Name = "txtFechaPlanificadaAuditoriaPlan";
            this.txtFechaPlanificadaAuditoriaPlan.Size = new System.Drawing.Size(140, 21);
            this.txtFechaPlanificadaAuditoriaPlan.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Fecha efectiva de la auditoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fecha planificada de la auditoria:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIDAuditoriaPlan
            // 
            this.txtIDAuditoriaPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDAuditoriaPlan.ForeColor = System.Drawing.Color.White;
            this.txtIDAuditoriaPlan.Location = new System.Drawing.Point(648, 107);
            this.txtIDAuditoriaPlan.Name = "txtIDAuditoriaPlan";
            this.txtIDAuditoriaPlan.Size = new System.Drawing.Size(100, 14);
            this.txtIDAuditoriaPlan.TabIndex = 50;
            // 
            // cmbTituloAuditoriaPlan
            // 
            this.cmbTituloAuditoriaPlan.FormattingEnabled = true;
            this.cmbTituloAuditoriaPlan.Location = new System.Drawing.Point(277, 131);
            this.cmbTituloAuditoriaPlan.Name = "cmbTituloAuditoriaPlan";
            this.cmbTituloAuditoriaPlan.Size = new System.Drawing.Size(330, 23);
            this.cmbTituloAuditoriaPlan.TabIndex = 49;
            this.cmbTituloAuditoriaPlan.SelectedIndexChanged += new System.EventHandler(this.cmbTituloAuditoriaPlan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Seleccione una Auditoria (Título):";
            // 
            // txtIDProgramaPlan
            // 
            this.txtIDProgramaPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDProgramaPlan.ForeColor = System.Drawing.Color.White;
            this.txtIDProgramaPlan.Location = new System.Drawing.Point(507, 98);
            this.txtIDProgramaPlan.Name = "txtIDProgramaPlan";
            this.txtIDProgramaPlan.Size = new System.Drawing.Size(100, 14);
            this.txtIDProgramaPlan.TabIndex = 47;
            // 
            // cmbAñoProgramaPlan
            // 
            this.cmbAñoProgramaPlan.FormattingEnabled = true;
            this.cmbAñoProgramaPlan.Location = new System.Drawing.Point(277, 98);
            this.cmbAñoProgramaPlan.Name = "cmbAñoProgramaPlan";
            this.cmbAñoProgramaPlan.Size = new System.Drawing.Size(121, 23);
            this.cmbAñoProgramaPlan.TabIndex = 46;
            this.cmbAñoProgramaPlan.SelectedIndexChanged += new System.EventHandler(this.cmbAñoProgramaPlan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Seleccione un programa (Año):";
            // 
            // rbEliminarPlan
            // 
            this.rbEliminarPlan.AutoSize = true;
            this.rbEliminarPlan.BackColor = System.Drawing.Color.LightGray;
            this.rbEliminarPlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEliminarPlan.Location = new System.Drawing.Point(635, 32);
            this.rbEliminarPlan.Name = "rbEliminarPlan";
            this.rbEliminarPlan.Size = new System.Drawing.Size(79, 19);
            this.rbEliminarPlan.TabIndex = 41;
            this.rbEliminarPlan.Text = "Eliminar";
            this.rbEliminarPlan.UseVisualStyleBackColor = false;
            this.rbEliminarPlan.CheckedChanged += new System.EventHandler(this.rbEliminarPlan_CheckedChanged);
            // 
            // rbModificarPlan
            // 
            this.rbModificarPlan.AutoSize = true;
            this.rbModificarPlan.BackColor = System.Drawing.Color.LightGray;
            this.rbModificarPlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModificarPlan.Location = new System.Drawing.Point(433, 32);
            this.rbModificarPlan.Name = "rbModificarPlan";
            this.rbModificarPlan.Size = new System.Drawing.Size(136, 19);
            this.rbModificarPlan.TabIndex = 40;
            this.rbModificarPlan.Text = "Modificar/Buscar";
            this.rbModificarPlan.UseVisualStyleBackColor = false;
            this.rbModificarPlan.CheckedChanged += new System.EventHandler(this.rbModificarPlan_CheckedChanged);
            // 
            // rbIngresaPlan
            // 
            this.rbIngresaPlan.AutoSize = true;
            this.rbIngresaPlan.BackColor = System.Drawing.Color.LightGray;
            this.rbIngresaPlan.Checked = true;
            this.rbIngresaPlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresaPlan.Location = new System.Drawing.Point(246, 32);
            this.rbIngresaPlan.Name = "rbIngresaPlan";
            this.rbIngresaPlan.Size = new System.Drawing.Size(82, 19);
            this.rbIngresaPlan.TabIndex = 39;
            this.rbIngresaPlan.TabStop = true;
            this.rbIngresaPlan.Text = "Ingresar";
            this.rbIngresaPlan.UseVisualStyleBackColor = false;
            this.rbIngresaPlan.CheckedChanged += new System.EventHandler(this.rbIngresaPlan_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Seleccione una opción:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(209, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 46);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIDProgramaActualPlan);
            this.tabPage2.Controls.Add(this.txtIDAuditoriaActualPlan);
            this.tabPage2.Controls.Add(this.txtIDPlanActual);
            this.tabPage2.Controls.Add(this.btnSiguienteDetallePlan);
            this.tabPage2.Controls.Add(this.btnGuardarDetallePlan);
            this.tabPage2.Controls.Add(this.txtCriterioPlan);
            this.tabPage2.Controls.Add(this.txtLugarPlan);
            this.tabPage2.Controls.Add(this.txtObjetivosPlan);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtCodigoPlan);
            this.tabPage2.Controls.Add(this.txtVersionPlan);
            this.tabPage2.Controls.Add(this.btnGeneraCódigoPlan);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnBuscarPlan);
            this.tabPage2.Controls.Add(this.txtIDPlan);
            this.tabPage2.Controls.Add(this.cmbBuscarPlanDetallePlan);
            this.tabPage2.Controls.Add(this.lblBuscarPlan);
            this.tabPage2.Controls.Add(this.txtFechaEmisionPlan);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle del Plan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIDProgramaActualPlan
            // 
            this.txtIDProgramaActualPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDProgramaActualPlan.ForeColor = System.Drawing.Color.White;
            this.txtIDProgramaActualPlan.Location = new System.Drawing.Point(725, 88);
            this.txtIDProgramaActualPlan.Name = "txtIDProgramaActualPlan";
            this.txtIDProgramaActualPlan.Size = new System.Drawing.Size(100, 14);
            this.txtIDProgramaActualPlan.TabIndex = 67;
            // 
            // txtIDAuditoriaActualPlan
            // 
            this.txtIDAuditoriaActualPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDAuditoriaActualPlan.ForeColor = System.Drawing.Color.White;
            this.txtIDAuditoriaActualPlan.Location = new System.Drawing.Point(725, 52);
            this.txtIDAuditoriaActualPlan.Name = "txtIDAuditoriaActualPlan";
            this.txtIDAuditoriaActualPlan.Size = new System.Drawing.Size(100, 14);
            this.txtIDAuditoriaActualPlan.TabIndex = 66;
            // 
            // txtIDPlanActual
            // 
            this.txtIDPlanActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDPlanActual.ForeColor = System.Drawing.Color.White;
            this.txtIDPlanActual.Location = new System.Drawing.Point(639, 421);
            this.txtIDPlanActual.Name = "txtIDPlanActual";
            this.txtIDPlanActual.Size = new System.Drawing.Size(100, 14);
            this.txtIDPlanActual.TabIndex = 65;
            // 
            // btnSiguienteDetallePlan
            // 
            this.btnSiguienteDetallePlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDetallePlan.Location = new System.Drawing.Point(443, 432);
            this.btnSiguienteDetallePlan.Name = "btnSiguienteDetallePlan";
            this.btnSiguienteDetallePlan.Size = new System.Drawing.Size(100, 23);
            this.btnSiguienteDetallePlan.TabIndex = 64;
            this.btnSiguienteDetallePlan.Text = "Siguiente";
            this.btnSiguienteDetallePlan.UseVisualStyleBackColor = true;
            this.btnSiguienteDetallePlan.Click += new System.EventHandler(this.btnSiguienteDetallePlan_Click);
            // 
            // btnGuardarDetallePlan
            // 
            this.btnGuardarDetallePlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDetallePlan.Location = new System.Drawing.Point(278, 432);
            this.btnGuardarDetallePlan.Name = "btnGuardarDetallePlan";
            this.btnGuardarDetallePlan.Size = new System.Drawing.Size(84, 23);
            this.btnGuardarDetallePlan.TabIndex = 63;
            this.btnGuardarDetallePlan.Text = "Guardar";
            this.btnGuardarDetallePlan.UseVisualStyleBackColor = true;
            this.btnGuardarDetallePlan.Click += new System.EventHandler(this.btnGuardarDetallePlan_Click);
            // 
            // txtCriterioPlan
            // 
            this.txtCriterioPlan.Location = new System.Drawing.Point(87, 309);
            this.txtCriterioPlan.Multiline = true;
            this.txtCriterioPlan.Name = "txtCriterioPlan";
            this.txtCriterioPlan.Size = new System.Drawing.Size(652, 84);
            this.txtCriterioPlan.TabIndex = 61;
            // 
            // txtLugarPlan
            // 
            this.txtLugarPlan.Location = new System.Drawing.Point(87, 247);
            this.txtLugarPlan.Multiline = true;
            this.txtLugarPlan.Name = "txtLugarPlan";
            this.txtLugarPlan.Size = new System.Drawing.Size(652, 40);
            this.txtLugarPlan.TabIndex = 60;
            // 
            // txtObjetivosPlan
            // 
            this.txtObjetivosPlan.Location = new System.Drawing.Point(87, 158);
            this.txtObjetivosPlan.Multiline = true;
            this.txtObjetivosPlan.Name = "txtObjetivosPlan";
            this.txtObjetivosPlan.Size = new System.Drawing.Size(652, 71);
            this.txtObjetivosPlan.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 58;
            this.label15.Text = "Criterio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 57;
            this.label14.Text = "Lugar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 56;
            this.label13.Text = "Objetivos:";
            // 
            // txtCodigoPlan
            // 
            this.txtCodigoPlan.Location = new System.Drawing.Point(290, 98);
            this.txtCodigoPlan.Name = "txtCodigoPlan";
            this.txtCodigoPlan.Size = new System.Drawing.Size(303, 21);
            this.txtCodigoPlan.TabIndex = 55;
            // 
            // txtVersionPlan
            // 
            this.txtVersionPlan.Location = new System.Drawing.Point(76, 98);
            this.txtVersionPlan.Name = "txtVersionPlan";
            this.txtVersionPlan.Size = new System.Drawing.Size(100, 21);
            this.txtVersionPlan.TabIndex = 54;
            // 
            // btnGeneraCódigoPlan
            // 
            this.btnGeneraCódigoPlan.Location = new System.Drawing.Point(618, 99);
            this.btnGeneraCódigoPlan.Name = "btnGeneraCódigoPlan";
            this.btnGeneraCódigoPlan.Size = new System.Drawing.Size(103, 24);
            this.btnGeneraCódigoPlan.TabIndex = 53;
            this.btnGeneraCódigoPlan.Text = "Generar código";
            this.btnGeneraCódigoPlan.UseVisualStyleBackColor = true;
            this.btnGeneraCódigoPlan.Click += new System.EventHandler(this.btnGeneraCódigoPlan_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "Código:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 51;
            this.label12.Text = "Versión:";
            // 
            // btnBuscarPlan
            // 
            this.btnBuscarPlan.Location = new System.Drawing.Point(518, 32);
            this.btnBuscarPlan.Name = "btnBuscarPlan";
            this.btnBuscarPlan.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPlan.TabIndex = 50;
            this.btnBuscarPlan.Text = "Buscar";
            this.btnBuscarPlan.UseVisualStyleBackColor = true;
            this.btnBuscarPlan.Click += new System.EventHandler(this.btnBuscarPlan_Click);
            // 
            // txtIDPlan
            // 
            this.txtIDPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDPlan.ForeColor = System.Drawing.Color.White;
            this.txtIDPlan.Location = new System.Drawing.Point(361, 5);
            this.txtIDPlan.Name = "txtIDPlan";
            this.txtIDPlan.Size = new System.Drawing.Size(100, 14);
            this.txtIDPlan.TabIndex = 49;
            // 
            // cmbBuscarPlanDetallePlan
            // 
            this.cmbBuscarPlanDetallePlan.FormattingEnabled = true;
            this.cmbBuscarPlanDetallePlan.Location = new System.Drawing.Point(216, 29);
            this.cmbBuscarPlanDetallePlan.Name = "cmbBuscarPlanDetallePlan";
            this.cmbBuscarPlanDetallePlan.Size = new System.Drawing.Size(276, 23);
            this.cmbBuscarPlanDetallePlan.TabIndex = 48;
            this.cmbBuscarPlanDetallePlan.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPlanDetallePlan_SelectedIndexChanged);
            // 
            // lblBuscarPlan
            // 
            this.lblBuscarPlan.AutoSize = true;
            this.lblBuscarPlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPlan.Location = new System.Drawing.Point(8, 32);
            this.lblBuscarPlan.Name = "lblBuscarPlan";
            this.lblBuscarPlan.Size = new System.Drawing.Size(202, 15);
            this.lblBuscarPlan.TabIndex = 47;
            this.lblBuscarPlan.Text = "Buscar Plan (Fecha Emisión):";
            // 
            // txtFechaEmisionPlan
            // 
            this.txtFechaEmisionPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaEmisionPlan.Location = new System.Drawing.Point(727, 9);
            this.txtFechaEmisionPlan.Name = "txtFechaEmisionPlan";
            this.txtFechaEmisionPlan.Size = new System.Drawing.Size(100, 14);
            this.txtFechaEmisionPlan.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Fecha emisión:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGenerarReporte);
            this.tabPage3.Controls.Add(this.btnGuardarVerificaciones);
            this.tabPage3.Controls.Add(this.txtQuejasPlan);
            this.tabPage3.Controls.Add(this.txtMejoraContinuaPlan);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(834, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Verificaciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(432, 433);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(152, 23);
            this.btnGenerarReporte.TabIndex = 66;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnGuardarVerificaciones
            // 
            this.btnGuardarVerificaciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVerificaciones.Location = new System.Drawing.Point(267, 433);
            this.btnGuardarVerificaciones.Name = "btnGuardarVerificaciones";
            this.btnGuardarVerificaciones.Size = new System.Drawing.Size(84, 23);
            this.btnGuardarVerificaciones.TabIndex = 65;
            this.btnGuardarVerificaciones.Text = "Guardar";
            this.btnGuardarVerificaciones.UseVisualStyleBackColor = true;
            this.btnGuardarVerificaciones.Click += new System.EventHandler(this.btnGuardarVerificaciones_Click);
            // 
            // txtQuejasPlan
            // 
            this.txtQuejasPlan.Location = new System.Drawing.Point(21, 316);
            this.txtQuejasPlan.Multiline = true;
            this.txtQuejasPlan.Name = "txtQuejasPlan";
            this.txtQuejasPlan.Size = new System.Drawing.Size(794, 93);
            this.txtQuejasPlan.TabIndex = 7;
            // 
            // txtMejoraContinuaPlan
            // 
            this.txtMejoraContinuaPlan.Location = new System.Drawing.Point(21, 190);
            this.txtMejoraContinuaPlan.Multiline = true;
            this.txtMejoraContinuaPlan.Name = "txtMejoraContinuaPlan";
            this.txtMejoraContinuaPlan.Size = new System.Drawing.Size(794, 93);
            this.txtMejoraContinuaPlan.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 298);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(357, 15);
            this.label21.TabIndex = 5;
            this.label21.Text = "Gestión de quejas - ¿Cómo se gestionan las quejas?";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "Mejora continúa:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(590, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "- ¿Se evidencia una mejora en los procesos en base a un análisis cuantitativo de " +
    "los datos obtenidos?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(424, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "- ¿Las actividades del SGC se encuentran incorporadas a nuestra rutina?";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(728, 30);
            this.label17.TabIndex = 1;
            this.label17.Text = "- ¿Aportan valor a las auditorías internas?. ¿Resultó positiva la metodología de " +
    "auto revisión establecida luego de la auditoria \r\n   de mantenimiento?";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(435, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "- Se generaron nuevos indicadores a partir de la medición de satisfacción?";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(834, 474);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Reporte";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource11.Name = "DataSet3";
            reportDataSource11.Value = this.filtraFechasPlanesBindingSource;
            reportDataSource12.Name = "DataSet1";
            reportDataSource12.Value = this.filtraPlanBindingSource;
            reportDataSource13.Name = "DataSet2";
            reportDataSource13.Value = this.filtraVerifPlanBindingSource;
            reportDataSource14.Name = "DataSet4";
            reportDataSource14.Value = this.filtraAudiPlanBindingSource;
            reportDataSource15.Name = "DataSet5";
            reportDataSource15.Value = this.filtraProPlanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistema_auditoria.RepoPlan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(828, 468);
            this.reportViewer1.TabIndex = 0;
            // 
            // filtraFechasPlanesTableAdapter
            // 
            this.filtraFechasPlanesTableAdapter.ClearBeforeFill = true;
            // 
            // filtraPlanTableAdapter
            // 
            this.filtraPlanTableAdapter.ClearBeforeFill = true;
            // 
            // filtraVerifPlanTableAdapter
            // 
            this.filtraVerifPlanTableAdapter.ClearBeforeFill = true;
            // 
            // filtraAudiPlanTableAdapter
            // 
            this.filtraAudiPlanTableAdapter.ClearBeforeFill = true;
            // 
            // filtraProPlanTableAdapter
            // 
            this.filtraProPlanTableAdapter.ClearBeforeFill = true;
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "Plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan";
            this.Load += new System.EventHandler(this.Plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filtraFechasPlanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraVerifPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraAudiPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtraProPlanBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoAuditoriaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcanceAuditoriaPlan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaEfectivaAuditoriaPlan;
        private System.Windows.Forms.TextBox txtFechaPlanificadaAuditoriaPlan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDAuditoriaPlan;
        private System.Windows.Forms.ComboBox cmbTituloAuditoriaPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDProgramaPlan;
        private System.Windows.Forms.ComboBox cmbAñoProgramaPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEliminarPlan;
        private System.Windows.Forms.RadioButton rbModificarPlan;
        private System.Windows.Forms.RadioButton rbIngresaPlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtFechaEmisionPlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnSiguientePlan;
        private System.Windows.Forms.Button btnGuardarPlan;
        private System.Windows.Forms.DataGridView dgvEquipoAuditoriaPlan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAlcanceAuditoriaPlan;
        private System.Windows.Forms.Button btnMostrarInformacionPlan;
        private System.Windows.Forms.Button btnBuscarPlan;
        private System.Windows.Forms.TextBox txtIDPlan;
        private System.Windows.Forms.ComboBox cmbBuscarPlanDetallePlan;
        private System.Windows.Forms.Label lblBuscarPlan;
        private System.Windows.Forms.Button btnSiguienteDetallePlan;
        private System.Windows.Forms.Button btnGuardarDetallePlan;
        private System.Windows.Forms.TextBox txtCriterioPlan;
        private System.Windows.Forms.TextBox txtLugarPlan;
        private System.Windows.Forms.TextBox txtObjetivosPlan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigoPlan;
        private System.Windows.Forms.TextBox txtVersionPlan;
        private System.Windows.Forms.Button btnGeneraCódigoPlan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDPlanActual;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnGuardarVerificaciones;
        private System.Windows.Forms.TextBox txtQuejasPlan;
        private System.Windows.Forms.TextBox txtMejoraContinuaPlan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox OKPrograma;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

       
        private System.Windows.Forms.TextBox txtIDAuditoriaActualPlan;
        private System.Windows.Forms.TextBox txtIDProgramaActualPlan;
    
        private Data data;
  
        private System.Windows.Forms.BindingSource filtraFechasPlanesBindingSource;

       
        private DataTableAdapters.filtraFechasPlanesTableAdapter filtraFechasPlanesTableAdapter;
        
        private System.Windows.Forms.BindingSource filtraPlanBindingSource;
        private System.Windows.Forms.BindingSource filtraVerifPlanBindingSource;
        private System.Windows.Forms.BindingSource filtraAudiPlanBindingSource;
        private System.Windows.Forms.BindingSource filtraProPlanBindingSource;
        private DataTableAdapters.filtraPlanTableAdapter filtraPlanTableAdapter;
        private DataTableAdapters.filtraVerifPlanTableAdapter filtraVerifPlanTableAdapter;
        private DataTableAdapters.filtraAudiPlanTableAdapter filtraAudiPlanTableAdapter;
        private DataTableAdapters.filtraProPlanTableAdapter filtraProPlanTableAdapter;
    }
}