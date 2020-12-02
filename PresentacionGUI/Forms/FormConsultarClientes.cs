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
    public partial class FormConsultarClientes : Form
    {
        ClienteService clienteService;
        public FormConsultarClientes()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnection.connectionString);
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();


            DtgClientes.DataSource = null;
            respuesta = clienteService.ConsultarTodos();
            DtgClientes.DataSource = respuesta.clientes;
        }

        private void FormConsultarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.aLUMNOSTableAdapter.Fill(this.dataSet1.ALUMNOS);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
                
        }
    }
}
