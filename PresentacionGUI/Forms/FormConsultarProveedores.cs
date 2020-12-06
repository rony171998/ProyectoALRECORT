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
    
    public partial class FormConsultarProveedores : Form
    {
        ProveedorService proveedorService;
        Proveedor proveedor;
        public FormConsultarProveedores()
        {
            InitializeComponent();
            proveedorService = new ProveedorService(ConfigConnection.connectionString);
            ConsultaProveedorRespuesta respuesta = new ConsultaProveedorRespuesta();


            DtgProveedores.DataSource = null;
            respuesta = proveedorService.ConsultarTodos();
            DtgProveedores.DataSource = respuesta.proveedores;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = MapearProveedor();
            string mensaje = proveedorService.Guardar(proveedor);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private Proveedor MapearProveedor()
        {
            proveedor = new Proveedor();
            proveedor.Identificacion = txtIdentificacion.Text;
            proveedor.Nombre = txtNombre.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Producto = cmbProductos.Text;
            

            return proveedor;

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_IDFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
