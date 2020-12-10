﻿using System;
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
            BusquedaServicioRespuesta respuestaServicioBusqueda = servicioService.BuscarIdentificacion(cmbId_servicio.Text);
            txtServicio.Text = respuestaServicioBusqueda.servicio.Nombre.ToString();
            txtPrecio.Text=respuestaServicioBusqueda.servicio.Costo.ToString();
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
        }
        private Detalle Mapeardetalle()
        {
            detalle = new Detalle();
            //detalle.Id_detalle = txtId_detalle.Text;
            detalle.Id_Servicio = cmbId_servicio.Text;
            //detalle.Id_Factura = cmbId_factura.Text;
            BusquedaServicioRespuesta respuestaservicio = servicioService.BuscarIdentificacion(cmbId_servicio.Text);
            detalle.ValorUnitario = respuestaservicio.servicio.Costo;         
            detalle.Cantidad = int.Parse( txtCantidad.Text);
            detalle.ValorTotal = detalle.CalcularValor();
            factura.AgregarDetalleServicio(respuestaservicio.servicio, int.Parse(txtCantidad.Text));
            return detalle;
        }
        public void mostrarlistafactura()
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            DTGFacturas.DataSource = null;
            respuesta = facturaService.ConsultarTodos();
            DTGFacturas.DataSource = respuesta.facturas;
        }
        public void mostrarlistadetalle()
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
            //mostrarlistadetalle();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            agregarServicio();
        }
    }
}
