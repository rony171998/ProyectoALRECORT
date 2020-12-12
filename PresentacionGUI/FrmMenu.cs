using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PresentacionGUI.Forms;

namespace PresentacionGUI
{
    public partial class FrmMenu : Form
    {
        private IconButton botonActual;
        private Panel BotonBordeIzquierdo;
        private Form FormChildActual;
        public FrmMenu()
        {
            InitializeComponent();
            BotonBordeIzquierdo = new Panel();
            BotonBordeIzquierdo.Size = new Size(6,60);
            panelMenu.Controls.Add(BotonBordeIzquierdo);
        }

        private struct ColoresRGB
        {
            public static Color PrimerColor=Color.FromArgb(172,126,241);
            public static Color SegundoColor=Color.FromArgb(24, 161, 251);
            public static Color TercerColor=Color.FromArgb(253,138,114);
            public static Color CuartoColor=Color.FromArgb(95,77,221);
            public static Color QuintoColor=Color.FromArgb(249,88,155) ;
            
        }

        private void ActivarBoton(object senderBoton, Color color)
        {
            if (senderBoton != null)
            {
                DesabilitarBoton();
                botonActual = (IconButton)senderBoton;
                botonActual.BackColor = Color.FromArgb(37, 36, 81);
                botonActual.ForeColor = color;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = color;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;
                BotonBordeIzquierdo.BackColor = color;
                BotonBordeIzquierdo.Location = new Point(0, botonActual.Location.Y);
                BotonBordeIzquierdo.Visible = true;
                BotonBordeIzquierdo.BringToFront();
                FrmIconoChildActual.IconChar = botonActual.IconChar;
                FrmIconoChildActual.IconColor = color;
                TitleFrmChild.Text = botonActual.Text;
            }
        }

        private void DesabilitarBoton()
        {
            if (botonActual != null)
            {
                botonActual.BackColor = Color.FromArgb(31, 32, 71);
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (FormChildActual != null)
            {
                FormChildActual.Close();
            }
            FormChildActual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender,ColoresRGB.PrimerColor);
            OpenChildForm(new FormGenerarFactura());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.SegundoColor);
            OpenChildForm(new FormConsultarClientes());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.TercerColor);
            OpenChildForm(new FormConsultarMateriales());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.CuartoColor);
            OpenChildForm(new FormConsultarProveedores());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.QuintoColor);
            OpenChildForm(new FormConsultarVentas());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            FormChildActual.Close();
            Reset();
        }


        private void Reset()
        {
            DesabilitarBoton();
            BotonBordeIzquierdo.Visible = false;
            FrmIconoChildActual.IconChar = IconChar.Home;
            FrmIconoChildActual.IconColor = Color.MediumPurple;
            TitleFrmChild.Text = "Inicio";
        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.QuintoColor);
            OpenChildForm(new FormServicios());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.QuintoColor);
            OpenChildForm(new Detalle_Factura());
        }
    }
}
