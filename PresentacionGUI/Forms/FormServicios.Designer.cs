
namespace PresentacionGUI.Forms
{
    partial class FormServicios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DatosFactura = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgServicios = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtCodigoServicio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtNombreServicio = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BtnBuscarPorNombre = new System.Windows.Forms.Button();
            this.BtnBuscarPorPrecio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DatosFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DatosFactura);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 489);
            this.tabControl1.TabIndex = 27;
            // 
            // DatosFactura
            // 
            this.DatosFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DatosFactura.Controls.Add(this.label2);
            this.DatosFactura.Controls.Add(this.BtnBuscarPorPrecio);
            this.DatosFactura.Controls.Add(this.BtnBuscarPorNombre);
            this.DatosFactura.Controls.Add(this.textBox4);
            this.DatosFactura.Controls.Add(this.label1);
            this.DatosFactura.Controls.Add(this.dtgServicios);
            this.DatosFactura.Location = new System.Drawing.Point(4, 22);
            this.DatosFactura.Name = "DatosFactura";
            this.DatosFactura.Padding = new System.Windows.Forms.Padding(3);
            this.DatosFactura.Size = new System.Drawing.Size(763, 463);
            this.DatosFactura.TabIndex = 2;
            this.DatosFactura.Text = "Lista Servicios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(322, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Lista Servicios";
            // 
            // dtgServicios
            // 
            this.dtgServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServicios.Location = new System.Drawing.Point(41, 158);
            this.dtgServicios.Name = "dtgServicios";
            this.dtgServicios.Size = new System.Drawing.Size(701, 218);
            this.dtgServicios.TabIndex = 63;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.TxtCodigoServicio);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.TxtNombreServicio);
            this.tabPage1.Controls.Add(this.TxtPrecio);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 463);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Servicios";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 50);
            this.button4.TabIndex = 70;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 50);
            this.button3.TabIndex = 69;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TxtCodigoServicio
            // 
            this.TxtCodigoServicio.Location = new System.Drawing.Point(263, 119);
            this.TxtCodigoServicio.Name = "TxtCodigoServicio";
            this.TxtCodigoServicio.Size = new System.Drawing.Size(234, 20);
            this.TxtCodigoServicio.TabIndex = 68;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 67;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtNombreServicio
            // 
            this.TxtNombreServicio.Location = new System.Drawing.Point(263, 154);
            this.TxtNombreServicio.Name = "TxtNombreServicio";
            this.TxtNombreServicio.Size = new System.Drawing.Size(234, 20);
            this.TxtNombreServicio.TabIndex = 64;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(263, 185);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(234, 20);
            this.TxtPrecio.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(159, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(300, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Servicios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(123, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Codigo Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(123, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Nombre de servicio";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 65;
            // 
            // BtnBuscarPorNombre
            // 
            this.BtnBuscarPorNombre.Location = new System.Drawing.Point(338, 125);
            this.BtnBuscarPorNombre.Name = "BtnBuscarPorNombre";
            this.BtnBuscarPorNombre.Size = new System.Drawing.Size(131, 23);
            this.BtnBuscarPorNombre.TabIndex = 66;
            this.BtnBuscarPorNombre.Text = "Buscar por nombre";
            this.BtnBuscarPorNombre.UseVisualStyleBackColor = true;
            this.BtnBuscarPorNombre.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnBuscarPorPrecio
            // 
            this.BtnBuscarPorPrecio.Location = new System.Drawing.Point(488, 125);
            this.BtnBuscarPorPrecio.Name = "BtnBuscarPorPrecio";
            this.BtnBuscarPorPrecio.Size = new System.Drawing.Size(133, 23);
            this.BtnBuscarPorPrecio.TabIndex = 67;
            this.BtnBuscarPorPrecio.Text = "Buscar por Precio";
            this.BtnBuscarPorPrecio.UseVisualStyleBackColor = true;
            this.BtnBuscarPorPrecio.Click += new System.EventHandler(this.BuscarPorPrecio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(83, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Dato";
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormServicios";
            this.Text = "Servicio";
            this.tabControl1.ResumeLayout(false);
            this.DatosFactura.ResumeLayout(false);
            this.DatosFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DatosFactura;
        private System.Windows.Forms.DataGridView dtgServicios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtNombreServicio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtCodigoServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscarPorPrecio;
        private System.Windows.Forms.Button BtnBuscarPorNombre;
        private System.Windows.Forms.TextBox textBox4;
    }
}