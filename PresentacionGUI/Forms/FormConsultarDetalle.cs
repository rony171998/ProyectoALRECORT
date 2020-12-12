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
    public partial class Detalle_Factura : Form
    {
        DetalleService detalleService;
        
        public Detalle_Factura()
        {
            InitializeComponent();
            var connectionString = ConfigConnection.connectionString;
            detalleService = new DetalleService(connectionString);
            
            MostrarLista();
        }
        private void MostrarLista()
        {           
            ConsultaDetalleRespuesta respuesta = detalleService.ConsultarTodos();
            DtgDetalles.DataSource = null;
            DtgDetalles.DataSource = respuesta.detalles;

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            DtgDetalles.DataSource = null;
            ConsultaDetalleRespuesta respuesta = detalleService.ConsultarTodos();
            DtgDetalles.DataSource = respuesta.detalles.Where(p => p.Id_Factura.Equals(txtIdentificacion.Text)).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DtgDetalles.DataSource = null;
            ConsultaDetalleRespuesta respuesta = detalleService.ConsultarTodos();
            DtgDetalles.DataSource = respuesta.detalles.Where(p => p.Id_detalle.Equals(txtIdentificacion.Text)).ToList();
        }
    }
}
