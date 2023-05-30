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
    public partial class FormModificarPasajero : Form
    {
        Pasajero pasajeroAux = new Pasajero();


        public FormModificarPasajero()
        {
            InitializeComponent();

        }

        public FormModificarPasajero(Pasajero pasajero) : this()
        {
            pasajeroAux = pasajero;
        }

        private void FormModificarPasajero_Load(object sender, EventArgs e)
        {
            numericUpDownEdad.Minimum = 1;
            numericUpDownEdad.Maximum = 110;
            labelDniValor.Text = pasajeroAux.Dni;
            textBoxNombre.Text = pasajeroAux.Nombre;
            textBoxApellido.Text = pasajeroAux.Apellido;
            numericUpDownEdad.Value = pasajeroAux.Edad;

        }

        private void buttonAceptarModificar_Click(object sender, EventArgs e)
        {
            List<Pasajero> listaPasajeros = new List<Pasajero>();
            string rutaActual;
            string rutaArchivoPasajeros;
            rutaActual = Directory.GetCurrentDirectory();
            rutaArchivoPasajeros = Path.Combine(rutaActual, "Pasajeros.xml");
            listaPasajeros = SerializacionXml.DeserializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros);

            int index = listaPasajeros.FindIndex(i => i.Dni == pasajeroAux.Dni);


            listaPasajeros[index].Nombre = textBoxNombre.Text;
            listaPasajeros[index].Apellido = textBoxApellido.Text;
            listaPasajeros[index].Edad = (int)numericUpDownEdad.Value;

            DialogResult resultado = MessageBox.Show("Desea realizar los cambios?", "Modificar Aeronave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                SerializacionXml.SerializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros, listaPasajeros);
                Close();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
