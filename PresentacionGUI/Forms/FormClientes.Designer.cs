namespace PresentacionGUI.Forms
{
    partial class FormClientes
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
            this.aLUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PresentacionGUI.DataSet1();
            this.aLUMNOSTableAdapter = new PresentacionGUI.DataSet1TableAdapters.ALUMNOSTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericEdad = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbCorreos = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtSegundoApelido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Facturar = new System.Windows.Forms.TabPage();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.txtID_cliente = new System.Windows.Forms.TextBox();
            this.DTGClientes = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).BeginInit();
            this.Facturar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // aLUMNOSBindingSource
            // 
            this.aLUMNOSBindingSource.DataMember = "ALUMNOS";
            this.aLUMNOSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMNOSTableAdapter
            // 
            this.aLUMNOSTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Facturar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 614);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.BtnBuscar);
            this.tabPage2.Controls.Add(this.BtnEliminar);
            this.tabPage2.Controls.Add(this.btnModificar);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.numericEdad);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.CmbCorreos);
            this.tabPage2.Controls.Add(this.txtCorreo);
            this.tabPage2.Controls.Add(this.cmbSexo);
            this.tabPage2.Controls.Add(this.BtnRegistrar);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtSexo);
            this.tabPage2.Controls.Add(this.labelEdad);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.txtIdentificacion);
            this.tabPage2.Controls.Add(this.txtSegundoApelido);
            this.tabPage2.Controls.Add(this.txtPrimerApellido);
            this.tabPage2.Controls.Add(this.txtSegundoNombre);
            this.tabPage2.Controls.Add(this.txtPrimerNombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar Cliente";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(544, 130);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(89, 23);
            this.BtnBuscar.TabIndex = 41;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(631, 480);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(114, 56);
            this.BtnEliminar.TabIndex = 40;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(454, 480);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 56);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(544, 414);
            this.dateTimePicker2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // numericEdad
            // 
            this.numericEdad.Location = new System.Drawing.Point(290, 255);
            this.numericEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEdad.Name = "numericEdad";
            this.numericEdad.Size = new System.Drawing.Size(234, 20);
            this.numericEdad.TabIndex = 37;
            this.numericEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 411);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 20, 14, 30, 33, 0);
            // 
            // CmbCorreos
            // 
            this.CmbCorreos.FormattingEnabled = true;
            this.CmbCorreos.Items.AddRange(new object[] {
            "@gmail.com"});
            this.CmbCorreos.Location = new System.Drawing.Point(540, 370);
            this.CmbCorreos.Name = "CmbCorreos";
            this.CmbCorreos.Size = new System.Drawing.Size(205, 21);
            this.CmbCorreos.TabIndex = 35;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(290, 370);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(234, 20);
            this.txtCorreo.TabIndex = 34;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.Location = new System.Drawing.Point(290, 296);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(234, 21);
            this.cmbSexo.TabIndex = 33;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(289, 480);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(137, 56);
            this.BtnRegistrar.TabIndex = 32;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(163, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Fecha de la Cita";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(204, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(206, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Telefono";
            // 
            // txtSexo
            // 
            this.txtSexo.AutoSize = true;
            this.txtSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSexo.Location = new System.Drawing.Point(206, 297);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(37, 17);
            this.txtSexo.TabIndex = 31;
            this.txtSexo.Text = "Sexo";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelEdad.Location = new System.Drawing.Point(206, 258);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(42, 17);
            this.labelEdad.TabIndex = 30;
            this.labelEdad.Text = "Edad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(360, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Cedula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(169, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cedula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(538, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(162, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(538, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Segundo Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(290, 334);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(234, 20);
            this.txtTelefono.TabIndex = 24;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(287, 133);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(234, 20);
            this.txtIdentificacion.TabIndex = 22;
            // 
            // txtSegundoApelido
            // 
            this.txtSegundoApelido.Location = new System.Drawing.Point(682, 217);
            this.txtSegundoApelido.Name = "txtSegundoApelido";
            this.txtSegundoApelido.Size = new System.Drawing.Size(234, 20);
            this.txtSegundoApelido.TabIndex = 21;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(289, 217);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(234, 20);
            this.txtPrimerApellido.TabIndex = 20;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(682, 177);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(234, 20);
            this.txtSegundoNombre.TabIndex = 19;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(289, 179);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(234, 20);
            this.txtPrimerNombre.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(160, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Primer Nombre";
            // 
            // Facturar
            // 
            this.Facturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Facturar.Controls.Add(this.BtnBuscarCliente);
            this.Facturar.Controls.Add(this.txtID_cliente);
            this.Facturar.Controls.Add(this.DTGClientes);
            this.Facturar.Controls.Add(this.label13);
            this.Facturar.Controls.Add(this.label8);
            this.Facturar.Location = new System.Drawing.Point(4, 22);
            this.Facturar.Name = "Facturar";
            this.Facturar.Padding = new System.Windows.Forms.Padding(3);
            this.Facturar.Size = new System.Drawing.Size(1065, 588);
            this.Facturar.TabIndex = 2;
            this.Facturar.Text = "Lista Clientes";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Location = new System.Drawing.Point(544, 106);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarCliente.TabIndex = 97;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtID_cliente
            // 
            this.txtID_cliente.Location = new System.Drawing.Point(278, 109);
            this.txtID_cliente.Name = "txtID_cliente";
            this.txtID_cliente.Size = new System.Drawing.Size(234, 20);
            this.txtID_cliente.TabIndex = 96;
            // 
            // DTGClientes
            // 
            this.DTGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGClientes.Location = new System.Drawing.Point(97, 165);
            this.DTGClientes.Name = "DTGClientes";
            this.DTGClientes.Size = new System.Drawing.Size(841, 252);
            this.DTGClientes.TabIndex = 88;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(472, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 81;
            this.label13.Text = "CLIENTES";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(196, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 81;
            this.label8.Text = "Id Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 448);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 20);
            this.textBox1.TabIndex = 42;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1073, 614);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormClientes";
            this.Text = "FormConsultarClientes";
            this.Load += new System.EventHandler(this.FormConsultarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).EndInit();
            this.Facturar.ResumeLayout(false);
            this.Facturar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aLUMNOSBindingSource;
        private DataSet1TableAdapters.ALUMNOSTableAdapter aLUMNOSTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericEdad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CmbCorreos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtSexo;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtSegundoApelido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Facturar;
        private System.Windows.Forms.TextBox txtID_cliente;
        private System.Windows.Forms.DataGridView DTGClientes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.TextBox textBox1;
    }
}