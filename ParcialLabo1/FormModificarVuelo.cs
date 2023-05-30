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
    public partial class FormModificarVuelo : Form
    {
        Array opcionesDestinoNacional = Enum.GetValues(typeof(DestinoNacional));
        Array opcionesDestinoInteracional = Enum.GetValues(typeof(DestinoInteracional));
        Array opcionesPartida = Enum.GetValues(typeof(PartidaVuelo));

        Vuelo vueloAux = new Vuelo();
        List<Vuelo> listaVuelos = new List<Vuelo>();
        string rutaActual;
        string rutaArchivoVuelos;
        public FormModificarVuelo()
        {
            InitializeComponent();
        }

        public FormModificarVuelo(Vuelo vuelo) : this()
        {
            vueloAux = vuelo;

            comboBoxVueloPartida.DataSource = opcionesPartida;
            comboBoxVueloPartida.Text = vueloAux.Partida;
            //fecha
            dateTimePickerFechaVuelo.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaVuelo.CustomFormat = "dd/MM/yyyy";
            //dateTimePickerFechaVuelo.Value = vueloAux.FechaVuelo;
            //hora
            dateTimePickerHorarioSalida.Format = DateTimePickerFormat.Time;
            dateTimePickerHorarioSalida.ShowUpDown = true;
            //dateTimePickerHorarioSalida.Value = vueloAux.HorarioSalida;

            if (vueloAux.CabotajeInternacional == "Internacional")
            {
                radioButtonViajeInternacional.Checked = true;


            }
            if (vueloAux.CabotajeInternacional == "Nacional")
            {
                radioButtonViajeNacional.Checked = true;

            }




            rutaActual = Directory.GetCurrentDirectory();
            rutaArchivoVuelos = Path.Combine(rutaActual, "Vuelos.xml");
            listaVuelos = SerializacionXml.DeserializarObjetoXml<List<Vuelo>>(rutaArchivoVuelos);
        }

        private void radioButtonViajeInternacional_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestinos.DataSource = opcionesDestinoInteracional;
        }

        private void radioButtonViajeNacional_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestinos.DataSource = opcionesDestinoNacional;
        }
    }
}
