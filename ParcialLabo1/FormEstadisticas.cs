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
    public partial class FormEstadisticas : Form
    {
        List<Pasajero> listaPasajeros = new List<Pasajero>();
        string rutaActual;
        string rutaArchivoPasajeros;

        List<Vuelo> listaVuelos = new List<Vuelo>();
        string rutaArchivoVuelos;

        List<Aeronave> listaAviones = new List<Aeronave>();
        string rutaArchivoAeronaves;

        public FormEstadisticas()
        {
            InitializeComponent();
            rutaActual = Directory.GetCurrentDirectory();

            //pasajeros
            rutaArchivoPasajeros = Path.Combine(rutaActual, "Pasajeros.xml");
            listaPasajeros = SerializacionXml.DeserializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros);

            rutaArchivoVuelos = Path.Combine(rutaActual, "Vuelos.xml");
            listaVuelos = SerializacionXml.DeserializarObjetoXml<List<Vuelo>>(rutaArchivoVuelos);

            rutaArchivoAeronaves = Path.Combine(rutaActual, "Aeronaves.json");
            listaAviones = SerializacionJson.DeserializarJson<List<Aeronave>>(rutaArchivoAeronaves);


        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            //LISTA PASAJEROS
            dataGridViewListaPasajeros.Rows.Clear();

            foreach (Pasajero item in listaPasajeros)
            {
                int rowIndex = dataGridViewListaPasajeros.Rows.Add();
                DataGridViewRow row = dataGridViewListaPasajeros.Rows[rowIndex];
                row.Cells[0].Value = item.Dni;
                row.Cells[1].Value = item.Nombre;
                row.Cells[2].Value = item.Apellido;
                row.Cells[3].Value = item.NumeroDeVuelos;
            }
            DataGridViewColumn columnaOrden = dataGridViewListaPasajeros.Columns[3];

            dataGridViewListaPasajeros.Sort(columnaOrden, System.ComponentModel.ListSortDirection.Descending);

            //LISTA VUELOS CABOTAJE/NACIONALES
            float gananciasCabotaje = 0;
            dataGridViewListaVuelosCabotaje.Rows.Clear();

            foreach (Vuelo item in listaVuelos)
            {
                if (item.CabotajeInternacional == "Nacional")
                {
                    int rowIndex = dataGridViewListaVuelosCabotaje.Rows.Add();
                    DataGridViewRow row = dataGridViewListaVuelosCabotaje.Rows[rowIndex];
                    row.Cells[0].Value = item.CodigoDeVuelo;
                    row.Cells[1].Value = item.FechaVuelo.ToString("dd/MM/yyyy");
                    row.Cells[2].Value = item.HorarioSalida.ToString("HH:mm");
                    row.Cells[3].Value = item.Partida;
                    row.Cells[4].Value = item.Destino;
                    row.Cells[5].Value = item.CatidadAsientosPremium;
                    row.Cells[6].Value = item.PrecioPremium;
                    row.Cells[7].Value = item.CantidadAsientosTurista;
                    row.Cells[8].Value = item.PrecioTurista;
                    row.Cells[9].Value = $"{item.DuracionVuelo}hs";

                    gananciasCabotaje += item.GananciaTotal;
                }

            }

            //LISTA VUELOS INTERNACIONALES
            float gananciaInternacional = 0;
            dataGridViewListaVuelosInternacional.Rows.Clear();

            foreach (Vuelo item in listaVuelos)
            {
                if (item.CabotajeInternacional == "Internacional")
                {
                    int rowIndex = dataGridViewListaVuelosInternacional.Rows.Add();
                    DataGridViewRow row = dataGridViewListaVuelosInternacional.Rows[rowIndex];
                    row.Cells[0].Value = item.CodigoDeVuelo;
                    row.Cells[1].Value = item.FechaVuelo.ToString("dd/MM/yyyy");
                    row.Cells[2].Value = item.HorarioSalida.ToString("HH:mm");
                    row.Cells[3].Value = item.Partida;
                    row.Cells[4].Value = item.Destino;
                    row.Cells[5].Value = item.CatidadAsientosPremium;
                    row.Cells[6].Value = item.PrecioPremium;
                    row.Cells[7].Value = item.CantidadAsientosTurista;
                    row.Cells[8].Value = item.PrecioTurista;
                    row.Cells[9].Value = $"{item.DuracionVuelo}hs";

                    gananciaInternacional += item.GananciaTotal;
                }

            }

            labelGananciasCabotaje.Text = gananciasCabotaje.ToString();
            labelGananciasInternacional.Text = gananciaInternacional.ToString();

            //AERONAVES HORAS
            dataGridViewListaAeronaves.Rows.Clear();

            foreach (Aeronave item in listaAviones)
            {

                int rowIndex = dataGridViewListaAeronaves.Rows.Add();
                DataGridViewRow row = dataGridViewListaAeronaves.Rows[rowIndex];
                row.Cells[0].Value = item.Matricula;
                row.Cells[1].Value = item.CantidadAsientosPremium;
                row.Cells[2].Value = item.CantidadAsientosTurista;
                row.Cells[3].Value = item.HorasDeVuelo;
            }
        }
    }
}
