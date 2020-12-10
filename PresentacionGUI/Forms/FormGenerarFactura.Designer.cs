namespace PresentacionGUI.Forms
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DTGFacturas = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbId_servicio = new System.Windows.Forms.ComboBox();
            this.txtID_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFacturas)).BeginInit();
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
            // cmbSexo
            // 
            this.cmbSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.Location = new System.Drawing.Point(489, 416);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(234, 21);
            this.cmbSexo.TabIndex = 33;
            // 
            // boton_Registrar
            // 
            this.boton_Registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton_Registrar.Location = new System.Drawing.Point(513, 537);
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
            this.label12.Location = new System.Drawing.Point(405, 454);
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
            this.txtSexo.Location = new System.Drawing.Point(405, 417);
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
            this.labelEdad.Location = new System.Drawing.Point(405, 378);
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
            this.label7.Location = new System.Drawing.Point(371, 118);
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
            this.label6.Location = new System.Drawing.Point(345, 267);
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
            this.label5.Location = new System.Drawing.Point(362, 214);
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
            this.label4.Location = new System.Drawing.Point(345, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Segundo Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Location = new System.Drawing.Point(489, 454);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(234, 20);
            this.txtTelefono.TabIndex = 24;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdad.Location = new System.Drawing.Point(489, 375);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(234, 20);
            this.txtEdad.TabIndex = 23;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdentificacion.Location = new System.Drawing.Point(489, 115);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(234, 20);
            this.txtIdentificacion.TabIndex = 22;
            // 
            // txtSegundoApelido
            // 
            this.txtSegundoApelido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSegundoApelido.Location = new System.Drawing.Point(489, 264);
            this.txtSegundoApelido.Name = "txtSegundoApelido";
            this.txtSegundoApelido.Size = new System.Drawing.Size(234, 20);
            this.txtSegundoApelido.TabIndex = 21;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimerApellido.Location = new System.Drawing.Point(489, 211);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(234, 20);
            this.txtPrimerApellido.TabIndex = 20;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSegundoNombre.Location = new System.Drawing.Point(489, 160);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(234, 20);
            this.txtSegundoNombre.TabIndex = 19;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimerNombre.Location = new System.Drawing.Point(489, 327);
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
            this.label3.Location = new System.Drawing.Point(360, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Primer Nombre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtID_cliente);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.cmbId_servicio);
            this.tabPage1.Controls.Add(this.DTGFacturas);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1191, 697);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(726, 462);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 95;
            // 
            // DTGFacturas
            // 
            this.DTGFacturas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTGFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGFacturas.Location = new System.Drawing.Point(264, 248);
            this.DTGFacturas.Name = "DTGFacturas";
            this.DTGFacturas.Size = new System.Drawing.Size(663, 192);
            this.DTGFacturas.TabIndex = 88;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(789, 505);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 50);
            this.btnNext.TabIndex = 87;
            this.btnNext.Text = "Registrar Factura";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(350, 203);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(234, 20);
            this.txtCantidad.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(258, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(624, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Valor Total";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(268, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 81;
            this.label8.Text = "Id Cliente";
            // 
            // cmbId_servicio
            // 
            this.cmbId_servicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbId_servicio.FormattingEnabled = true;
            this.cmbId_servicio.Location = new System.Drawing.Point(350, 164);
            this.cmbId_servicio.Name = "cmbId_servicio";
            this.cmbId_servicio.Size = new System.Drawing.Size(234, 21);
            this.cmbId_servicio.TabIndex = 93;
            // 
            // txtID_cliente
            // 
            this.txtID_cliente.Location = new System.Drawing.Point(350, 124);
            this.txtID_cliente.Name = "txtID_cliente";
            this.txtID_cliente.Size = new System.Drawing.Size(234, 20);
            this.txtID_cliente.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(268, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Id servicio";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 97;
            this.button3.Text = "agregar Servicio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.tabControl1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFacturas)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbId_servicio;
        private System.Windows.Forms.DataGridView DTGFacturas;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtID_cliente;
        private System.Windows.Forms.Label label1;
    }
}