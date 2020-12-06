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
            //cliente.Email = txtCorreo.Text;

            return cliente;

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
    }
}
