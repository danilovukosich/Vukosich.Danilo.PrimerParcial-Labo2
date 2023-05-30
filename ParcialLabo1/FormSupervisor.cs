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
    public partial class FormSupervisor : FormUsuarioPadre
    {
        Usuario usuarioIngresado = new Usuario();
        public FormSupervisor(Usuario usuario)
        {
            InitializeComponent();
            usuarioIngresado = usuario;


        }

        private void FormSupervisor_Load(object sender, EventArgs e)
        {
            labelNombreApellidoUsuario.Text = $"{usuarioIngresado.Nombre} {usuarioIngresado.Apellido}";
            labelTipoUsuario.Text = "Supervisor";
        }

        private void iconButtonAgregarPasajero_Click(object sender, EventArgs e)
        {
            BotonActivo(sender);
            AbrirFormilariohijo(new FormPasajeros());
        }

        private void iconButtonHome_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButtonEstadisticas_Click(object sender, EventArgs e)
        {
            BotonActivo(sender);
            AbrirFormilariohijo(new FormEstadisticas());//formEstadoisticas
        }
    }
}
