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
    public partial class FormServicios : Form
    {
        ServicioService servicioService;
        Servicio servicio;
        
        public FormServicios()
        {
            InitializeComponent();
            var connectionString = ConfigConnection.connectionString;
            servicioService = new ServicioService(connectionString);

            MostrarLista();
        }
        private Servicio MapearServicio()
        {

            servicio = new Servicio();           
            servicio.IDServicio = TxtCodigoServicio.Text;
            servicio.Nombre = TxtNombreServicio.Text;
            servicio.Costo =double.Parse(TxtPrecio.Text);          
            return servicio;
        }

        public void MostrarLista()
        {
            ConsultaServicioRespuesta respuesta = new ConsultaServicioRespuesta();

            dtgServicios.DataSource = null;
            respuesta = servicioService.ConsultarTodos();
            dtgServicios.DataSource = respuesta.servicios;                      

        }

        private void btnRegistrarServicio_Click(object sender, EventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultaServicioRespuesta respuesta = new ConsultaServicioRespuesta();
            dtgServicios.DataSource = null;
            respuesta = servicioService.ConsultarTodos();
            dtgServicios.DataSource = respuesta.servicios.Where(p=>p.Nombre.ToUpper().Equals(BtnBuscarPorNombre.Text.ToUpper()));
        }

        private void BuscarPorPrecio_Click(object sender, EventArgs e)
        {
            ConsultaServicioRespuesta respuesta = new ConsultaServicioRespuesta();
            dtgServicios.DataSource = null;
            respuesta = servicioService.ConsultarTodos();
            dtgServicios.DataSource = respuesta.servicios.Where(p => p.Costo==Double.Parse(BtnBuscarPorPrecio.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servicio servicio = MapearServicio();

            string mensaje = servicioService.Guardar(servicio);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MostrarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Servicio servicio = MapearServicio();

            string mensaje = servicioService.Eliminar(TxtCodigoServicio.Text);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MostrarLista();
        }
    }
}
