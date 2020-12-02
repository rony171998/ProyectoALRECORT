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
        public FormGenerarFactura()
        {
            InitializeComponent();
            var connectionString = ConfigConnection.connectionString;
            clienteService = new ClienteService(connectionString);
            
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
            cliente.Cargo = cmbCargo.Text;
            return cliente;

        }

        private void boton_Registrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearCliente();
            string mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            /*string connectionString = "Data Source=localhost:1521/XEPDB1;User Id = rony; Password = rony123";
            OracleConnection conection = new OracleConnection(connectionString);
            conection.Open();
            MessageBox.Show("Se abrió la conexión con el servidor ORACLE ");
            OracleCommand command = new OracleCommand();
            command.CommandText = "select * from alumnos";
            OracleDataReader Datos = command.ExecuteReader();
            conection.Close();*/
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
