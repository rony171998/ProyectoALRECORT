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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Facturar = new System.Windows.Forms.TabPage();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtID_cliente = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbId_servicio = new System.Windows.Forms.ComboBox();
            this.DTGFacturas = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sERVICIOTableAdapter = new PresentacionGUI.DataSet2TableAdapters.SERVICIOTableAdapter();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataSet3 = new PresentacionGUI.DataSet3();
            this.sERVICIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICIOTableAdapter1 = new PresentacionGUI.DataSet3TableAdapters.SERVICIOTableAdapter();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Facturar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFacturas)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Facturar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 650);
            this.tabControl1.TabIndex = 26;
            // 
            // Facturar
            // 
            this.Facturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Facturar.Controls.Add(this.TxtNombreCliente);
            this.Facturar.Controls.Add(this.BtnBuscar);
            this.Facturar.Controls.Add(this.txtPrecio);
            this.Facturar.Controls.Add(this.txtServicio);
            this.Facturar.Controls.Add(this.button3);
            this.Facturar.Controls.Add(this.txtID_cliente);
            this.Facturar.Controls.Add(this.textBox1);
            this.Facturar.Controls.Add(this.cmbId_servicio);
            this.Facturar.Controls.Add(this.DTGFacturas);
            this.Facturar.Controls.Add(this.btnNext);
            this.Facturar.Controls.Add(this.txtCantidad);
            this.Facturar.Controls.Add(this.label9);
            this.Facturar.Controls.Add(this.label2);
            this.Facturar.Controls.Add(this.label1);
            this.Facturar.Controls.Add(this.label11);
            this.Facturar.Controls.Add(this.label3);
            this.Facturar.Controls.Add(this.label10);
            this.Facturar.Controls.Add(this.label13);
            this.Facturar.Controls.Add(this.label8);
            this.Facturar.Location = new System.Drawing.Point(4, 22);
            this.Facturar.Name = "Facturar";
            this.Facturar.Padding = new System.Windows.Forms.Padding(3);
            this.Facturar.Size = new System.Drawing.Size(1004, 624);
            this.Facturar.TabIndex = 2;
            this.Facturar.Text = "Facturacion";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(671, 124);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(105, 23);
            this.BtnBuscar.TabIndex = 99;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(671, 166);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(154, 20);
            this.txtPrecio.TabIndex = 98;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(508, 166);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(154, 20);
            this.txtServicio.TabIndex = 98;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(508, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 23);
            this.button3.TabIndex = 97;
            this.button3.Text = "Agregar Servicio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtID_cliente
            // 
            this.txtID_cliente.Location = new System.Drawing.Point(248, 127);
            this.txtID_cliente.Name = "txtID_cliente";
            this.txtID_cliente.Size = new System.Drawing.Size(234, 20);
            this.txtID_cliente.TabIndex = 96;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 95;
            // 
            // cmbId_servicio
            // 
            this.cmbId_servicio.FormattingEnabled = true;
            this.cmbId_servicio.Location = new System.Drawing.Point(248, 167);
            this.cmbId_servicio.Name = "cmbId_servicio";
            this.cmbId_servicio.Size = new System.Drawing.Size(234, 21);
            this.cmbId_servicio.TabIndex = 93;
            this.cmbId_servicio.SelectedIndexChanged += new System.EventHandler(this.cmbId_servicio_SelectedIndexChanged);
            this.cmbId_servicio.SelectedValueChanged += new System.EventHandler(this.FormGenerarFactura_Load);
            // 
            // DTGFacturas
            // 
            this.DTGFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGFacturas.Location = new System.Drawing.Point(162, 251);
            this.DTGFacturas.Name = "DTGFacturas";
            this.DTGFacturas.Size = new System.Drawing.Size(663, 192);
            this.DTGFacturas.TabIndex = 88;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(687, 508);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 50);
            this.btnNext.TabIndex = 87;
            this.btnNext.Text = "Registrar Factura";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(248, 206);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(234, 20);
            this.txtCantidad.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(156, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(522, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Valor Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(166, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Id servicio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(705, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 81;
            this.label11.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(553, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 81;
            this.label10.Text = "Servicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(442, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 81;
            this.label13.Text = "FACTURACION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(166, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 81;
            this.label8.Text = "Id Cliente";
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1012, 650);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1012, 650);
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
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Location = new System.Drawing.Point(510, 127);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(152, 20);
            this.TxtNombreCliente.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(553, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Cliente";
            // 
            // FormGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1012, 650);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FormGenerarFactura";
            this.Text = "FormGenerarFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGenerarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Facturar.ResumeLayout(false);
            this.Facturar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFacturas)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource sERVICIOBindingSource;
        private DataSet2TableAdapters.SERVICIOTableAdapter sERVICIOTableAdapter;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource sERVICIOBindingSource1;
        private DataSet3TableAdapters.SERVICIOTableAdapter sERVICIOTableAdapter1;
        private System.Windows.Forms.TabPage Facturar;
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
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label3;
    }
}