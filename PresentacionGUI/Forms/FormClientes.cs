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
    public partial class FormClientes : Form
    {
        ClienteService clienteService;
        Cliente cliente;
        public FormClientes()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnection.connectionString);
            MostrarLista();
        }
        private void FormConsultarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.ALUMNOS' Puede moverla o quitarla según sea necesario.
            //this.aLUMNOSTableAdapter.Fill(this.dataSet1.ALUMNOS);

        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearCliente();
            string mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.Identificacion = txtIdentificacion.Text;
            cliente.PrimerNombre = txtPrimerNombre.Text;
            cliente.SegundoNombre = txtSegundoNombre.Text;
            cliente.PrimerApellido = txtPrimerApellido.Text;
            cliente.SegundoApellido = txtPrimerApellido.Text;
            cliente.Edad = numericEdad.Text;
            cliente.Sexo = cmbSexo.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Email = txtCorreo.Text + CmbCorreos.Text;
            //cliente.FechaCita = dateTimePicker1.Value.Date;
            return cliente;
        }
        private void MostrarLista()
        {
            DTGClientes.DataSource = null;
            ConsultaPersonaRespuesta respuesta = clienteService.ConsultarTodos();
            DTGClientes.DataSource = respuesta.clientes;
        }
        private void limpiarCampos()
        {
            txtIdentificacion.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApelido.Text = "";
            cmbSexo.Text = "";
            txtTelefono.Text = "";
            
            txtCorreo.Text = "";
            CmbCorreos.Text = "";
            numericEdad.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            DTGClientes.DataSource = null;
            ConsultaPersonaRespuesta respuesta = clienteService.ConsultarTodos();
            DTGClientes.DataSource = respuesta.clientes.Where(p=>p.Identificacion.Equals(txtID_cliente.Text)).ToList();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaPersonaRespuesta respuesta = clienteService.BuscarxIdentificacion(txtIdentificacion.Text);
            if (respuesta.cliente==null)
            {
                limpiarCampos();
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                txtIdentificacion.Text = respuesta.cliente.Identificacion;
                txtPrimerNombre.Text = respuesta.cliente.PrimerNombre;
                txtSegundoNombre.Text = respuesta.cliente.SegundoNombre;
                txtPrimerApellido.Text = respuesta.cliente.PrimerApellido;
                txtSegundoApelido.Text = respuesta.cliente.SegundoApellido;
                cmbSexo.Text = respuesta.cliente.Sexo;
                txtTelefono.Text = respuesta.cliente.Telefono;
                string[] cadena = respuesta.cliente.Email.Split('@');
                txtCorreo.Text = cadena[0];
                CmbCorreos.Text = "@"+cadena[1];
                numericEdad.Text = respuesta.cliente.Edad;
                //dateTimePicker1.Text = respuesta.cliente.FechaCita.ToLongDateString();
                //dateTimePicker2.Text = respuesta.cliente.FechaCita.ToShortTimeString();
                //textBox1.Text = respuesta.cliente.FechaCita.ToString();
            } 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {           
            BusquedaPersonaRespuesta respuesta = clienteService.BuscarxIdentificacion(txtIdentificacion.Text);

            if (!respuesta.Error)
            {
                
                string mensaje = clienteService.Modificar(respuesta.cliente);
                MessageBox.Show(mensaje, "Mensaje del Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            //limpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
                string mensaje = clienteService.Eliminar(txtIdentificacion.Text);
                MessageBox.Show(mensaje, "Mensaje de eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                limpiarCampos();
            
            
        }
    }
}
