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
    public partial class FormAgregarVuelo : Form
    {
        //valores combobox
        Array opcionesDestinoNacional = Enum.GetValues(typeof(DestinoNacional));
        Array opcionesDestinoInteracional = Enum.GetValues(typeof(DestinoInteracional));
        Array opcionesPartida = Enum.GetValues(typeof(PartidaVuelo));

        List<Aeronave> listaAeronaves = new List<Aeronave>();
        string rutaActual;
        string rutaArchivoAeronaves;
        string[] opcionesAeronaves;//matriculas para combobox

        Vuelo nuevoVuelo = new Vuelo();
        List<Vuelo> listaVuelos = new List<Vuelo>();
        string rutaArchivoVuelos;


        public FormAgregarVuelo()
        {
            InitializeComponent();
            comboBoxVueloPartida.DataSource = opcionesPartida;
            //fecha
            dateTimePickerFechaVuelo.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaVuelo.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFechaVuelo.MinDate = DateTime.Now;
            //hora
            dateTimePickerHorarioSalida.Format = DateTimePickerFormat.Time;
            dateTimePickerHorarioSalida.ShowUpDown = true;

            rutaActual = Directory.GetCurrentDirectory();

            rutaArchivoAeronaves = Path.Combine(rutaActual, "Aeronaves.json");
            listaAeronaves = SerializacionJson.DeserializarJson<List<Aeronave>>(rutaArchivoAeronaves);


            opcionesAeronaves = new string[listaAeronaves.Count];

            rutaArchivoVuelos = Path.Combine(rutaActual, "Vuelos.xml");
            listaVuelos = SerializacionXml.DeserializarObjetoXml<List<Vuelo>>(rutaArchivoVuelos);


            //for (int i = 0; i < listaAeronaves.Count; i++)
            //{
            //    //if (listaAeronaves[i].Estado.ToLower() == "sin vuelo")
            //    //{
            //    opcionesAeronaves[i] = listaAeronaves[i].Matricula;

            //    //}


            //}

            //comboBoxAeronaveDelVuelo.DataSource = opcionesAeronaves;

            dataGridViewAeronaves.Rows.Clear();

            foreach (Aeronave item in listaAeronaves)
            {
                if (item.Estado.ToLower() == "sin vuelo")
                {
                    int rowIndex = dataGridViewAeronaves.Rows.Add();
                    DataGridViewRow row = dataGridViewAeronaves.Rows[rowIndex];
                    row.Cells[0].Value = item.Matricula;
                    row.Cells[1].Value = item.PoseeInternet;
                    row.Cells[3].Value = item.CapacidadBodega;
                    row.Cells[2].Value = item.OfreceComida;
                    row.Cells[4].Value = item.CantidadAsientosPremium;
                    row.Cells[5].Value = item.CantidadAsientosTurista;
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void radioButtonViajeInternacional_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestinos.DataSource = opcionesDestinoInteracional;
        }

        private void radioButtonViajeNacional_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestinos.DataSource = opcionesDestinoNacional;
        }

        private void buttonAgregarVuelo_Click(object sender, EventArgs e)
        {
            //Vuelos nacionales: entre 2 y 4 horas.
            //Vuelos internacionales: entre 8 y 12 horas.
            Aeronave aeronaveAux = new Aeronave();

            //ASIGANR EL VUELO CREAFDO A LA AERONAVE SELECCIONADA PARA ESTE
            aeronaveAux = Aeronave.BuscarAeronavePorMatricula(listaAeronaves, textBoxMatriculaPasajero.Text);

            nuevoVuelo.CodigoDeVuelo = Vuelo.GenerarCodigoVuelo();
            //nuevoVuelo.Aeronave = aeronaveAux;//genera circular reference was detected while serializing an object!
            nuevoVuelo.Partida = comboBoxVueloPartida.Text;
            nuevoVuelo.FechaVuelo = dateTimePickerFechaVuelo.Value;
            nuevoVuelo.HorarioSalida = dateTimePickerHorarioSalida.Value;
            nuevoVuelo.Destino = comboBoxDestinos.Text;
            if (radioButtonViajeInternacional.Checked)
            {
                nuevoVuelo.DuracionVuelo = Vuelo.CalcularDuracionVueloInteracional();
                nuevoVuelo.PrecioPremium = Vuelo.CalcularPrecioInternacional("premium", nuevoVuelo.DuracionVuelo);
                nuevoVuelo.PrecioTurista = Vuelo.CalcularPrecioInternacional("turista", nuevoVuelo.DuracionVuelo);
                nuevoVuelo.CabotajeInternacional = "Internacional";
            }
            if (radioButtonViajeNacional.Checked)
            {
                nuevoVuelo.DuracionVuelo = Vuelo.CalcularDuracionVueloNacional();
                nuevoVuelo.PrecioPremium = Vuelo.CalcularPrecioNacional("premium", nuevoVuelo.DuracionVuelo);
                nuevoVuelo.PrecioTurista = Vuelo.CalcularPrecioNacional("turista", nuevoVuelo.DuracionVuelo);
                nuevoVuelo.CabotajeInternacional = "Nacional";
            }
            //cant asientos
            nuevoVuelo.CantidadAsientosTurista = aeronaveAux.CantidadAsientosTurista;
            nuevoVuelo.CatidadAsientosPremium = aeronaveAux.CantidadAsientosPremium;



            //nuevoVuelo.ListaPasajeros = new List<Pasajero>();//en venta

            int indexAeronave = listaAeronaves.FindIndex(i => i.Matricula == textBoxMatriculaPasajero.Text);
            if (indexAeronave != -1)
            {
                listaAeronaves[indexAeronave].HorasDeVuelo += nuevoVuelo.DuracionVuelo;
                listaAeronaves[indexAeronave].VueloAsignado = nuevoVuelo;
                listaAeronaves[indexAeronave].Estado = "Vuelo Asignado";
            }
            else
            {
                MessageBox.Show("No se encontro la aeronave");
            }


            nuevoVuelo.PesoCabotajeTotal = 0;


            if (nuevoVuelo.Partida != "" && nuevoVuelo.Destino != "" && indexAeronave != -1)
            {
                listaVuelos.Add(nuevoVuelo);

                SerializacionXml.SerializarObjetoXml<List<Vuelo>>(rutaArchivoVuelos, listaVuelos);
                SerializacionJson.SerializarAJson<List<Aeronave>>(rutaArchivoAeronaves, listaAeronaves);

                MessageBox.Show("Agregado Exitosamente!");
                Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }

        }


    }
}
