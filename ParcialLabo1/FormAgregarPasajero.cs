using ParcialLabo1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialLabo1
{
    public partial class FormAgregarPasajero : Form
    {
        Pasajero pasajeroNuevo = new Pasajero();
        List<Pasajero> listaPasajeros = new List<Pasajero>();
        string rutaActual;
        string rutaArchivoPasajeros;

        public FormAgregarPasajero()
        {
            InitializeComponent();
            rutaActual = Directory.GetCurrentDirectory();
            rutaArchivoPasajeros = Path.Combine(rutaActual, "Pasajeros.xml");
            listaPasajeros = SerializacionXml.DeserializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros);
            textBoxDniPasajero.MaxLength = 8;

        }

        private void textBoxDniPasajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;
            }
        }
        private void textBoxNombrePasajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Cancelar la pulsación del caracter
                e.Handled = true;
            }
        }

        private void textBoxApellidoPasajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Cancelar la pulsación del caracter
                e.Handled = true;
            }

        }

        private void buttonAgregarPasajero_Click(object sender, EventArgs e)
        {

            pasajeroNuevo.Nombre = textBoxNombrePasajero.Text;
            pasajeroNuevo.Apellido = textBoxApellidoPasajero.Text;
            pasajeroNuevo.Edad = (int)numericUpDownEdadPasajero.Value;
            pasajeroNuevo.Dni = textBoxDniPasajero.Text;
            pasajeroNuevo.EqupajeMano = "Sin equipaje";
            pasajeroNuevo.EquipajeBodega = "Sin equipaje";
            pasajeroNuevo.Estado = "Sin estado";
            pasajeroNuevo.Clase = "Sin clase";
            pasajeroNuevo.NumeroDeVuelos = 0;

            listaPasajeros.Add(pasajeroNuevo);

            SerializacionXml.SerializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros, listaPasajeros);

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
