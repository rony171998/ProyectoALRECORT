﻿namespace PresentacionGUI.Forms
{
    partial class FormGenerarFactura
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
            this.sERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new PresentacionGUI.DataSet2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbId_factura = new System.Windows.Forms.ComboBox();
            this.cmbId_servicio = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.registra_detalles = new System.Windows.Forms.Button();
            this.txtId_detalle = new System.Windows.Forms.TextBox();
            this.DTGFacturas = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_IDFactura = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.boton_Registrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtSegundoApelido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sERVICIOTableAdapter = new PresentacionGUI.DataSet2TableAdapters.SERVICIOTableAdapter();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataSet3 = new PresentacionGUI.DataSet3();
            this.sERVICIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICIOTableAdapter1 = new PresentacionGUI.DataSet3TableAdapters.SERVICIOTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFacturas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sERVICIOBindingSource
            // 
            this.sERVICIOBindingSource.DataMember = "SERVICIO";
            this.sERVICIOBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.cmbId_factura);
            this.tabPage2.Controls.Add(this.cmbId_servicio);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.registra_detalles);
            this.tabPage2.Controls.Add(this.txtId_detalle);
            this.tabPage2.Controls.Add(this.DTGFacturas);
            this.tabPage2.Controls.Add(this.btnNext);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lbl_IDFactura);
            this.tabPage2.Controls.Add(this.cmbSexo);
            this.tabPage2.Controls.Add(this.boton_Registrar);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtSexo);
            this.tabPage2.Controls.Add(this.labelEdad);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.txtEdad);
            this.tabPage2.Controls.Add(this.txtIdentificacion);
            this.tabPage2.Controls.Add(this.txtSegundoApelido);
            this.tabPage2.Controls.Add(this.txtPrimerApellido);
            this.tabPage2.Controls.Add(this.txtSegundoNombre);
            this.tabPage2.Controls.Add(this.txtPrimerNombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1191, 697);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos de Cliente";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cmbId_factura
            // 
            this.cmbId_factura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbId_factura.FormattingEnabled = true;
            this.cmbId_factura.Location = new System.Drawing.Point(631, 136);
            this.cmbId_factura.Name = "cmbId_factura";
            this.cmbId_factura.Size = new System.Drawing.Size(233, 21);
            this.cmbId_factura.TabIndex = 79;
            // 
            // cmbId_servicio
            // 
            this.cmbId_servicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbId_servicio.FormattingEnabled = true;
            this.cmbId_servicio.Location = new System.Drawing.Point(630, 183);
            this.cmbId_servicio.Name = "cmbId_servicio";
            this.cmbId_servicio.Size = new System.Drawing.Size(234, 21);
            this.cmbId_servicio.TabIndex = 78;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(971, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 35);
            this.button2.TabIndex = 77;
            this.button2.Text = "Lista detalle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(682, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 76;
            this.button1.Text = "Lista factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registra_detalles
            // 
            this.registra_detalles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registra_detalles.Location = new System.Drawing.Point(952, 497);
            this.registra_detalles.Name = "registra_detalles";
            this.registra_detalles.Size = new System.Drawing.Size(132, 50);
            this.registra_detalles.TabIndex = 74;
            this.registra_detalles.Text = "Registrar detalle";
            this.registra_detalles.UseVisualStyleBackColor = true;
            this.registra_detalles.Click += new System.EventHandler(this.registra_detalles_Click);
            // 
            // txtId_detalle
            // 
            this.txtId_detalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId_detalle.Location = new System.Drawing.Point(631, 100);
            this.txtId_detalle.Name = "txtId_detalle";
            this.txtId_detalle.Size = new System.Drawing.Size(234, 20);
            this.txtId_detalle.TabIndex = 73;
            // 
            // DTGFacturas
            // 
            this.DTGFacturas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTGFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGFacturas.Location = new System.Drawing.Point(506, 264);
            this.DTGFacturas.Name = "DTGFacturas";
            this.DTGFacturas.Size = new System.Drawing.Size(663, 192);
            this.DTGFacturas.TabIndex = 70;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(661, 497);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 50);
            this.btnNext.TabIndex = 69;
            this.btnNext.Text = "Registrar Factura";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(630, 227);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(234, 20);
            this.txtCantidad.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(538, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Id factura";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(882, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Valor Total";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(538, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Id servicio";
            this.label8.Click += new System.EventHandler(this.lbl_IDFactura_Click);
            // 
            // lbl_IDFactura
            // 
            this.lbl_IDFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_IDFactura.AutoSize = true;
            this.lbl_IDFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_IDFactura.Location = new System.Drawing.Point(538, 100);
            this.lbl_IDFactura.Name = "lbl_IDFactura";
            this.lbl_IDFactura.Size = new System.Drawing.Size(71, 17);
            this.lbl_IDFactura.TabIndex = 63;
            this.lbl_IDFactura.Text = "ID Detalle";
            this.lbl_IDFactura.Click += new System.EventHandler(this.lbl_IDFactura_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.Location = new System.Drawing.Point(175, 399);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(234, 21);
            this.cmbSexo.TabIndex = 33;
            // 
            // boton_Registrar
            // 
            this.boton_Registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton_Registrar.Location = new System.Drawing.Point(199, 520);
            this.boton_Registrar.Name = "boton_Registrar";
            this.boton_Registrar.Size = new System.Drawing.Size(166, 86);
            this.boton_Registrar.TabIndex = 32;
            this.boton_Registrar.Text = "Registrar";
            this.boton_Registrar.UseVisualStyleBackColor = true;
            this.boton_Registrar.Click += new System.EventHandler(this.boton_Registrar_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(91, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Telefono";
            // 
            // txtSexo
            // 
            this.txtSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSexo.AutoSize = true;
            this.txtSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSexo.Location = new System.Drawing.Point(91, 400);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(37, 17);
            this.txtSexo.TabIndex = 31;
            this.txtSexo.Text = "Sexo";
            // 
            // labelEdad
            // 
            this.labelEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelEdad.Location = new System.Drawing.Point(91, 361);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(42, 17);
            this.labelEdad.TabIndex = 30;
            this.labelEdad.Text = "Edad";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(57, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Identificacion";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(31, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(48, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(31, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Segundo Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Location = new System.Drawing.Point(175, 437);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(234, 20);
            this.txtTelefono.TabIndex = 24;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdad.Location = new System.Drawing.Point(175, 358);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(234, 20);
            this.txtEdad.TabIndex = 23;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdentificacion.Location = new System.Drawing.Point(175, 98);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(234, 20);
            this.txtIdentificacion.TabIndex = 22;
            // 
            // txtSegundoApelido
            // 
            this.txtSegundoApelido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSegundoApelido.Location = new System.Drawing.Point(175, 247);
            this.txtSegundoApelido.Name = "txtSegundoApelido";
            this.txtSegundoApelido.Size = new System.Drawing.Size(234, 20);
            this.txtSegundoApelido.TabIndex = 21;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimerApellido.Location = new System.Drawing.Point(175, 194);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(234, 20);
            this.txtPrimerApellido.TabIndex = 20;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSegundoNombre.Location = new System.Drawing.Point(175, 143);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(234, 20);
            this.txtSegundoNombre.TabIndex = 19;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimerNombre.Location = new System.Drawing.Point(175, 310);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(234, 20);
            this.txtPrimerNombre.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(46, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Primer Nombre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 723);
            this.tabControl1.TabIndex = 26;
            // 
            // sERVICIOTableAdapter
            // 
            this.sERVICIOTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1199, 723);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1199, 723);
            this.toolStripContainer1.TabIndex = 28;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICIOBindingSource1
            // 
            this.sERVICIOBindingSource1.DataMember = "SERVICIO";
            this.sERVICIOBindingSource1.DataSource = this.dataSet3;
            // 
            // sERVICIOTableAdapter1
            // 
            this.sERVICIOTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(984, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(538, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Cantidad";
            // 
            // FormGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1199, 723);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FormGenerarFactura";
            this.Text = "FormGenerarFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGenerarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFacturas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button boton_Registrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtSexo;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtSegundoApelido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource sERVICIOBindingSource;
        private DataSet2TableAdapters.SERVICIOTableAdapter sERVICIOTableAdapter;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource sERVICIOBindingSource1;
        private DataSet3TableAdapters.SERVICIOTableAdapter sERVICIOTableAdapter1;
        private System.Windows.Forms.DataGridView DTGFacturas;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_IDFactura;
        private System.Windows.Forms.TextBox txtId_detalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button registra_detalles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbId_servicio;
        private System.Windows.Forms.ComboBox cmbId_factura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}