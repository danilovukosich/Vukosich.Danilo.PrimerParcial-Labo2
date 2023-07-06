using FontAwesome.Sharp;
using ParcialLabo1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;



namespace ParcialLabo1
{
    public partial class FormUsuarioPadre : Form
    {
        public FormUsuarioPadre()
        {
            InitializeComponent();
        }

        private IconButton botonActual;
        private Panel panelIzquierdo;

        private Form formHijoActual;
        private Usuario usuario = new Usuario();

        //Conbstructor form

        public FormUsuarioPadre(Usuario usuarioIngresado) : this()
        {
            panelIzquierdo = new Panel();
            panelIzquierdo.Size = new Size(7, 60);
            panelMenu.Controls.Add(panelIzquierdo);
            usuario = usuarioIngresado;
        }

        //Metodos botones
        //APRETO BOTON
        public void BotonActivo(object senderButton)
        {
            if (senderButton != null)
            {
                BotonInactivo();
                //Boton
                botonActual = (IconButton)senderButton;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;
                //Borde izquierdo del boton
                //panelIzquierdo.Location = new Point(0, botonActual.Location.Y);
                //panelIzquierdo.Visible = true;
                //panelIzquierdo.BringToFront();
            }
        }
        //APRETO OTRO BOTON
        public void BotonInactivo()
        {
            if (botonActual != null)
            {
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //METODO PARA ABIR FORMULARIOS EN EL PANEL DEL FORM
        public void AbrirFormilariohijo(Form formularioHijo)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            formHijoActual = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(formularioHijo);
            panelDesktop.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

            //para abrir un form pongo el metodo en el click de uno de los botones
            //AbrirFormularioHijo(new "nombre del form"):
        }

        //BOTON HOME
        public void iconButtonHome_Click(object sender, EventArgs e)
        {
            //BotonActivo(sender);
            if (formHijoActual != null)
            {
                BotonActivo(sender);
                formHijoActual.Close();
            }
            //formHijoActual.Close();
        }

        //Cerrar sesion
        protected void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea Cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                this.Hide();
                FormInicioSesion form1 = new FormInicioSesion();
                form1.ShowDialog();
            }
        }

        //FECHA Y HORA ACTUALES
        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void labelCerrarSesion2_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuarioPadre_Load(object sender, EventArgs e)
        {
            labelNombreUsuario.Text = usuario.Nombre;
        }
    }
}
