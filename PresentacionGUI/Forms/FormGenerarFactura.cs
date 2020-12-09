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
        Factura factura;
        Detalle detalle;
        DetalleService detalleService;
        Servicio servicio;
        ServicioService ServicioService;

        public FormGenerarFactura()
        {
            InitializeComponent();
            var connectionString = ConfigConnection.connectionString;
            clienteService = new ClienteService(connectionString);
            facturaService = new FacturaService(connectionString);
            detalleService = new DetalleService(connectionString);
            
            mostrarlistar();
        }
        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.Identificacion = txtIdentificacion.Text;
            cliente.PrimerNombre = txtPrimerNombre.Text;
            cliente.SegundoNombre = txtSegundoNombre.Text;
            cliente.PrimerApellido = txtPrimerApellido.Text;
            cliente.SegundoApellido = txtPrimerApellido.Text;
            cliente.Edad = txtEdad.Text;
            cliente.Sexo = cmbSexo.Text;
            cliente.Telefono = txtTelefono.Text;
            
            //cliente.Email = txtCorreo.Text;

            return cliente;

        }
        
        private Factura Mapearfactura()
        {
            factura = new Factura();
            factura.IdFactura = txtId_factura.Text;
            factura.IdCliente = txtIdentificacion.Text;
            factura.Fecha = DateTime.Now;
            factura.Total = facturaService.calcularTotal(factura);
            return factura;
        }
        private Detalle Mapeardetalle()
        {
           
            detalle = new Detalle();
            detalle.Id_Factura = txtId_factura.Text;
            detalle.Id_detalle = txtId_detalle.Text;
            detalle.Id_Servicio = txtServicio.Text;
            detalle.ValorUnitario =double.Parse( txtValorunitario.Text);
            
            detalle.Cantidad =int.Parse( txtCantidad.Text);
            detalle.ValorTotal = detalle.CalcularValor();


            return detalle;
        }
        public void mostrarlistar()
        {

            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            DTGFacturas.DataSource = null;
            respuesta = facturaService.ConsultarTodos();
            DTGFacturas.DataSource = respuesta.facturas;
            
        }
        public void mostrarlistardetalle()
        {

            ConsultaDetalleRespuesta respuesta = new ConsultaDetalleRespuesta();
            DTGFacturas.DataSource = null;
            respuesta = detalleService.ConsultarTodos();
            DTGFacturas.DataSource = respuesta.detalles;

        }


        private void boton_Registrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearCliente();
            string mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            
        }

        private void FormGenerarFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.SERVICIO' Puede moverla o quitarla según sea necesario.
            //this.sERVICIOTableAdapter1.Fill(this.dataSet3.SERVICIO);
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.SERVICIO' Puede moverla o quitarla según sea necesario.
            //this.sERVICIOTableAdapter.Fill(this.dataSet2.SERVICIO);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.sERVICIOTableAdapter.FillBy(this.dataSet2.SERVICIO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

                    }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            
            Factura factura = Mapearfactura();
            string mensaje = facturaService.Guardar(factura);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            

            mostrarlistar();
        }

        private void lbl_IDFactura_Click(object sender, EventArgs e)
        {

        }

        private void registra_detalles_Click(object sender, EventArgs e)
        {
            Detalle detalle = Mapeardetalle();
            MessageBox.Show(detalle.Id_Servicio);
            string mensaje2 = detalleService.Guardar(detalle);
            MessageBox.Show(mensaje2, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarlistardetalle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarlistar();
        }
    }
}
