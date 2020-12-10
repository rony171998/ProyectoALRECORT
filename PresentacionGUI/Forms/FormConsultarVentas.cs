using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PresentacionGUI.Forms
{
    public partial class FormConsultarVentas : Form
    {
        
        DetalleService detalleService;
        FacturaService facturaService;
        public FormConsultarVentas()
        {
            InitializeComponent();
            var connectionString = ConfigConnection.connectionString;
            detalleService = new DetalleService(connectionString);
            facturaService = new FacturaService(connectionString);
            MostrarLista();
        }
        private void MostrarLista()
        {
            DtgFacturas.DataSource = null;
            ConsultaFacturaRespuesta respuesta = facturaService.ConsultarTodos();
            DtgFacturas.DataSource = respuesta.facturas;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DtgFacturas.DataSource = null;
            ConsultaFacturaRespuesta respuesta = facturaService.ConsultarTodos();
            DtgFacturas.DataSource = respuesta.facturas.Where(p=>p.IdCliente.Equals(txtIdentificacion.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DtgFacturas.DataSource = null;
            ConsultaFacturaRespuesta respuesta = facturaService.ConsultarTodos();
            DtgFacturas.DataSource = respuesta.facturas.Where(p => p.IdFactura.Equals(txtIdentificacion.Text));
        }
    }
}
