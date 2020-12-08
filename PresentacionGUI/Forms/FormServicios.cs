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
            servicio.IDServicio = txtNumeroFactura.Text;
            servicio.Nombre = txtNombreServicio.Text;
            servicio.Costo =double.Parse(txtPrecio.Text);          
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

            Servicio servicio = MapearServicio();
            
            string mensaje = servicioService.Guardar(servicio);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MostrarLista();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }
    }
}
