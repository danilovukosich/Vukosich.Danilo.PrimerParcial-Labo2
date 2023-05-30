using Microsoft.VisualBasic.ApplicationServices;
using ParcialLabo1.Clases;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text.Json;


namespace ParcialLabo1
{
    public partial class FormInicioSesion : Form
    {

        public FormInicioSesion()
        {
            InitializeComponent();
            //DialogResult resultado = MessageBox.Show($"Ruta: {rutaArchivo}\nExiste:{bandera}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Usuario")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.Gray;
            }
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Usuario";
                textBoxUsuario.ForeColor = Color.Gray;
            }
        }

        private void textBoxContrasenia_Enter(object sender, EventArgs e)
        {
            if (textBoxContrasenia.Text == "Contraseña")
            {
                textBoxContrasenia.Text = "";
                textBoxContrasenia.ForeColor = Color.Gray;
                textBoxContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void textBoxContrasenia_Leave(object sender, EventArgs e)
        {
            if (textBoxContrasenia.Text == "")
            {
                textBoxContrasenia.Text = "Contraseña";
                textBoxContrasenia.ForeColor = Color.Gray;
                textBoxContrasenia.UseSystemPasswordChar = false;
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            comboBoxInicioSesionRapido.Items.Add("Corey (Vendedor)");
            comboBoxInicioSesionRapido.Items.Add("Ingrid (Vendedor)");
            comboBoxInicioSesionRapido.Items.Add("Steve (Vendedor)");
            comboBoxInicioSesionRapido.Items.Add("Tilda (Supervisor)");
            comboBoxInicioSesionRapido.Items.Add("Michael (Administrador)");
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            
            string rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "MOCK_DATA.json");

            //bool bandera = false;
            List<Usuario> listaUsuarios = new List<Usuario>();
            if (File.Exists(rutaArchivo))
            {
                //bandera = true;
                listaUsuarios = SerializacionJson.DeserializarJson<List<Usuario>>(rutaArchivo);
            }
            else
            {
                DialogResult resultado = MessageBox.Show($"No existe el archivo");
            }

            string correoUsuario = textBoxUsuario.Text;//correo ingresado
            string claveUsuario = textBoxContrasenia.Text;//contraseña ingresada

            Usuario usuarioIngresado = Usuario.ValidarCredenciales(listaUsuarios, correoUsuario, claveUsuario);
            FormBienvenida bienvenida = new FormBienvenida();//pantalla bienvenida

            if (usuarioIngresado != null)
            {

                switch (usuarioIngresado.Perfil)
                {
                    case "vendedor":
                        this.Hide();
                        bienvenida.ShowDialog();
                        FormUsuarioPadre formVendedor = new FormVendedor(usuarioIngresado);
                        formVendedor.ShowDialog();
                        break;

                    case "supervisor":
                        this.Hide();
                        bienvenida.ShowDialog();
                        FormUsuarioPadre formSupervisor = new FormSupervisor(usuarioIngresado);
                        formSupervisor.ShowDialog();
                        break;

                    case "administrador":
                        this.Hide();
                        bienvenida.ShowDialog();
                        FormUsuarioPadre formAdministrador = new FormAdministrador(usuarioIngresado);
                        formAdministrador.ShowDialog();
                        break;
                }

            }
            else { DialogResult resultado = MessageBox.Show($"No existe el usuario"); }
            //ctrl shift t buscar form
        }

        private void comboBoxInicioSesionRapido_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxContrasenia.UseSystemPasswordChar = true;
            switch (comboBoxInicioSesionRapido.Text)
            {
                
                case "Corey (Vendedor)":
                    textBoxUsuario.Text= "cgorgen@vendedor.com";
                    textBoxContrasenia.Text= "123abc45";
                    break;
                case "Ingrid (Vendedor)":
                    textBoxUsuario.Text = "iharroll@vendedor.com";
                    textBoxContrasenia.Text = "qweasdzx";
                    break;
                case "Steve (Vendedor)":
                    textBoxUsuario.Text = "sharris@maiden.com.uk";
                    textBoxContrasenia.Text = "eddie666";
                    break;
                case "Tilda (Supervisor)":
                    textBoxUsuario.Text = "trobinson@super.com";
                    textBoxContrasenia.Text = "12345678";
                    break;
                case "Michael (Administrador)":
                    textBoxUsuario.Text = "admin@admin.com";
                    textBoxContrasenia.Text = "12345678";
                    break;
            }
        }
    }
}