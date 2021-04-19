using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using BLL;
using Entity;
namespace PresentacionGUI.Forms
{
    public partial class FormGenerarFactura : Form
    {
        ClienteService clienteService;
        Cliente cliente;
        FacturaService facturaService;
        Factura factura = new Factura();
        Detalle detalle;
        DetalleService detalleService;
        Servicio servicio;
        ServicioService servicioService;       
        public FormGenerarFactura()
        {
            InitializeComponent();
            var connectionString = ConfigConnection.connectionString;
            clienteService = new ClienteService(connectionString);
            facturaService = new FacturaService(connectionString);
            detalleService = new DetalleService(connectionString);
            servicioService = new ServicioService(connectionString);            
            llenarcombos(); 
            
            
        }
        public void llenarcombos()
        {
            ConsultaServicioRespuesta respuestaservicio = servicioService.ConsultarTodos();
            cmbId_servicio.DataSource = respuestaservicio.servicios.Select(p => p.IDServicio).ToList();
            verServicio();
        }
        public void verServicio()
        {
            BusquedaServicioRespuesta respuestaServicioBusqueda = servicioService.BuscarIdentificacion(cmbId_servicio.Text);
            txtServicio.Text = respuestaServicioBusqueda.servicio.Nombre.ToString();
            txtPrecio.Text = respuestaServicioBusqueda.servicio.Costo.ToString();
        }
              
        private Factura Mapearfactura()
        {
            factura.IdCliente = txtID_cliente.Text;
            factura.Fecha = DateTime.Now;            
            return factura;
        }
        private void agregarServicio()
        {
            BusquedaServicioRespuesta respuestaservicio = servicioService.BuscarIdentificacion(cmbId_servicio.Text);
            factura.AgregarDetalleServicio(respuestaservicio.servicio, int.Parse(txtCantidad.Text));
            factura.CalcularTotal();
            textBox1.Text = factura.Total.ToString();
            DTGFacturas.DataSource = null;
            DTGFacturas.DataSource = factura.GetdetalleServicios();
        
            DTGFacturas.Columns.Remove("Id_factura");
            DTGFacturas.Columns.Remove("Id_detalle");
            DTGFacturas.Columns.Remove("factura");
            DTGFacturas.Columns.Remove("servicio");
        }
        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void FormGenerarFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.SERVICIO' Puede moverla o quitarla según sea necesario.
            //this.sERVICIOTableAdapter1.Fill(this.dataSet3.SERVICIO);
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.SERVICIO' Puede moverla o quitarla según sea necesario.
            //this.sERVICIOTableAdapter.Fill(this.dataSet2.SERVICIO);

        }
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {                    }
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        private void registra_detalles_Click(object sender, EventArgs e)
        {
            Mapearfactura();           
        }       
        private void btnNext_Click(object sender, EventArgs e)
        {
            Factura factura = Mapearfactura();
            string mensaje = facturaService.Guardar(factura);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            agregarServicio();
        }

        private void cmbId_servicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            verServicio();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            BusquedaPersonaRespuesta respuesta = clienteService.BuscarxIdentificacion(txtID_cliente.Text);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje, "Mensaje de Buscar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
            }
            else
            {
                
                MessageBox.Show(respuesta.Mensaje, "Mensaje de Buscar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (respuesta.cliente != null)
                {
                    TxtNombreCliente.Text = null;
                    TxtNombreCliente.Text = respuesta.cliente.PrimerNombre;
                }
                
            } 
        }
    }
}
