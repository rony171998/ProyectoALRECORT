
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
            this.dtgServicios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.btnRegistrarServicio = new System.Windows.Forms.Button();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_IDFactura = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DatosFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DatosFactura);
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
            this.DatosFactura.Controls.Add(this.dtgServicios);
            this.DatosFactura.Controls.Add(this.button1);
            this.DatosFactura.Controls.Add(this.txtNumeroFactura);
            this.DatosFactura.Controls.Add(this.btnRegistrarServicio);
            this.DatosFactura.Controls.Add(this.txtNombreServicio);
            this.DatosFactura.Controls.Add(this.txtPrecio);
            this.DatosFactura.Controls.Add(this.label2);
            this.DatosFactura.Controls.Add(this.label1);
            this.DatosFactura.Controls.Add(this.lbl_IDFactura);
            this.DatosFactura.Location = new System.Drawing.Point(4, 22);
            this.DatosFactura.Name = "DatosFactura";
            this.DatosFactura.Padding = new System.Windows.Forms.Padding(3);
            this.DatosFactura.Size = new System.Drawing.Size(763, 463);
            this.DatosFactura.TabIndex = 2;
            this.DatosFactura.Text = "DatosFactura";
            // 
            // dtgServicios
            // 
            this.dtgServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServicios.Location = new System.Drawing.Point(100, 226);
            this.dtgServicios.Name = "dtgServicios";
            this.dtgServicios.Size = new System.Drawing.Size(601, 150);
            this.dtgServicios.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(343, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "mostrarLista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroFactura.Location = new System.Drawing.Point(237, 25);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(234, 20);
            this.txtNumeroFactura.TabIndex = 61;
            // 
            // btnRegistrarServicio
            // 
            this.btnRegistrarServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarServicio.Location = new System.Drawing.Point(298, 134);
            this.btnRegistrarServicio.Name = "btnRegistrarServicio";
            this.btnRegistrarServicio.Size = new System.Drawing.Size(120, 50);
            this.btnRegistrarServicio.TabIndex = 59;
            this.btnRegistrarServicio.Text = "Registrar";
            this.btnRegistrarServicio.UseVisualStyleBackColor = true;
            this.btnRegistrarServicio.Click += new System.EventHandler(this.btnRegistrarServicio_Click);
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreServicio.Location = new System.Drawing.Point(237, 60);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(234, 20);
            this.txtNombreServicio.TabIndex = 51;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Location = new System.Drawing.Point(237, 91);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(234, 20);
            this.txtPrecio.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(133, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Numero Factura";
            // 
            // lbl_IDFactura
            // 
            this.lbl_IDFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_IDFactura.AutoSize = true;
            this.lbl_IDFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_IDFactura.Location = new System.Drawing.Point(97, 61);
            this.lbl_IDFactura.Name = "lbl_IDFactura";
            this.lbl_IDFactura.Size = new System.Drawing.Size(134, 17);
            this.lbl_IDFactura.TabIndex = 50;
            this.lbl_IDFactura.Text = "Nombre de servicio";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DatosFactura;
        private System.Windows.Forms.Button btnRegistrarServicio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_IDFactura;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgServicios;
    }
}