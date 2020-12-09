using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PresentacionGUI.Forms
{
    public partial class FormConsultarMateriales : Form
    {
        Material material;
        MaterialService materialService;
        ProveedorService proveedorService;
        Proveedor proveedor;
        Factura factura;
        FacturaService facturaService;
        public FormConsultarMateriales()
        {
            InitializeComponent();
            materialService = new MaterialService(ConfigConnection.connectionString);
            MostrarLista();
            ListaProveedores();
        }

        private void lbl_IDFactura_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Material material = Mapear();
            string mensaje = materialService.Guardar(material);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MostrarLista();
        }
        
        private Material Mapear()
        {
            material = new Material();
            material.Id = txtIdentificacion.Text;
            material.Nombre = txtNombre.Text;
            material.FechaRegistro = DateTime.Now;
            material.IdProveedor = cmbProveedor.Text;
            material.Existencias = int.Parse(txtCantidad.Text);
            return material;
        }
        public void MostrarLista()
        {
            ConsultaMaterialRespuesta respuesta = new ConsultaMaterialRespuesta();


            DtgMateriales.DataSource = null;
            respuesta = materialService.ConsultarTodos();
            DtgMateriales.DataSource = respuesta.materiales;

        }
        public void ListaProveedores()
        {
            ConsultaProveedorRespuesta respuesta = new ConsultaProveedorRespuesta();
           
            
        }

        private void FormConsultarMateriales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet5.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            //this.pROVEEDORESTableAdapter1.Fill(this.dataSet5.PROVEEDORES);
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            //this.pROVEEDORESTableAdapter.Fill(this.dataSet4.PROVEEDORES);

        }
    }
}
