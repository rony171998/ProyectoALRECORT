namespace PresentacionGUI.Forms
{
    partial class FormConsultarClientes
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
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.aLUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PresentacionGUI.DataSet1();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.aLUMNOSTableAdapter = new PresentacionGUI.DataSet1TableAdapters.ALUMNOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgClientes
            // 
            this.DtgClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtgClientes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClientes.Location = new System.Drawing.Point(137, 12);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.Size = new System.Drawing.Size(798, 334);
            this.DtgClientes.TabIndex = 0;
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
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultar.Location = new System.Drawing.Point(416, 365);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(229, 78);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // aLUMNOSTableAdapter
            // 
            this.aLUMNOSTableAdapter.ClearBeforeFill = true;
            // 
            // FormConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1073, 539);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.DtgClientes);
            this.Name = "FormConsultarClientes";
            this.Text = "FormConsultarClientes";
            this.Load += new System.EventHandler(this.FormConsultarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.Button btnConsultar;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aLUMNOSBindingSource;
        private DataSet1TableAdapters.ALUMNOSTableAdapter aLUMNOSTableAdapter;
    }
}