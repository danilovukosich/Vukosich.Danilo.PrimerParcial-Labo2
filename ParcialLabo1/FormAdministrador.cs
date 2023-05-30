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

namespace ParcialLabo1
{
    public partial class FormAdministrador : FormUsuarioPadre
    {
        Usuario usuarioIngresado = new Usuario();


        public FormAdministrador(Usuario usuario)
        {
            InitializeComponent();
            usuarioIngresado = usuario;

        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            labelNombreApellidoUsuario.Text = $"{usuarioIngresado.Nombre} {usuarioIngresado.Apellido}";
            labelTipoUsuario.Text = "Administrador";
        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonViajes_Click(object sender, EventArgs e)
        {
            BotonActivo(sender);
            AbrirFormilariohijo(new FormAeronaves());
        }

        private void iconButtonVuelos_Click(object sender, EventArgs e)
        {
            BotonActivo(sender);
            AbrirFormilariohijo(new FormVuelos());
        }
    }
}
