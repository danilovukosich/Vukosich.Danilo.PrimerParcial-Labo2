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
    public partial class FormVisualizarViajes : Form
    {
        string rutaActual;
        string rutaArchivoPasajeros;
        string rutaArchivoVuelos;

        string[] opcionesCodigoVuelos;

        List<Pasajero> listaPasajeros = new List<Pasajero>();
        List<Vuelo> listaVuelos = new List<Vuelo>();

        public FormVisualizarViajes()
        {
            InitializeComponent();
            rutaActual = Directory.GetCurrentDirectory();

            rutaArchivoPasajeros = Path.Combine(rutaActual, "Pasajeros.xml");
            listaPasajeros = SerializacionXml.DeserializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros);

            rutaArchivoVuelos = Path.Combine(rutaActual, "Vuelos.xml");
            listaVuelos = SerializacionXml.DeserializarObjetoXml<List<Vuelo>>(rutaArchivoVuelos);

            opcionesCodigoVuelos = new string[listaVuelos.Count];
            for (int i = 0; i < listaVuelos.Count; i++)
            {
                opcionesCodigoVuelos[i] = listaVuelos[i].CodigoDeVuelo;
            }
            comboBoxCodigoVuelo.DataSource = opcionesCodigoVuelos;


        }

        private void FormVisualizarViajes_Load(object sender, EventArgs e)
        {
            dataGridViewListaVuelos.Rows.Clear();

            foreach (Vuelo item in listaVuelos)
            {

                int rowIndex = dataGridViewListaVuelos.Rows.Add();
                DataGridViewRow row = dataGridViewListaVuelos.Rows[rowIndex];
                row.Cells[0].Value = item.CodigoDeVuelo;
                row.Cells[1].Value = item.FechaVuelo.ToString("dd/MM/yyyy");
                row.Cells[2].Value = item.HorarioSalida.ToString("HH:mm");
                row.Cells[3].Value = item.Partida;
                row.Cells[4].Value = item.Destino;
                row.Cells[5].Value = item.GananciaTotal;
                row.Cells[6].Value = item.PesoCabotajeTotal;

            }

            int indexVuelo = listaVuelos.FindIndex(i => i.CodigoDeVuelo == comboBoxCodigoVuelo.Text);
            dataGridViewPasajerosVuelo.Rows.Clear();

            foreach (Pasajero item in listaVuelos[indexVuelo].ListaPasajeros)
            {
                int rowIndex = dataGridViewPasajerosVuelo.Rows.Add();
                DataGridViewRow row = dataGridViewPasajerosVuelo.Rows[rowIndex];
                row.Cells[0].Value = item.Dni;
                row.Cells[1].Value = item.Nombre;
                row.Cells[2].Value = item.Apellido;

            }
        }

        private void comboBoxCodigoVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexVuelo = listaVuelos.FindIndex(i => i.CodigoDeVuelo == comboBoxCodigoVuelo.Text);
            dataGridViewPasajerosVuelo.Rows.Clear();

            foreach (Pasajero item in listaVuelos[indexVuelo].ListaPasajeros)
            {
                int rowIndex = dataGridViewPasajerosVuelo.Rows.Add();
                DataGridViewRow row = dataGridViewPasajerosVuelo.Rows[rowIndex];
                row.Cells[0].Value = item.Dni;
                row.Cells[1].Value = item.Nombre;
                row.Cells[2].Value = item.Apellido;

            }
        }
    }
}
