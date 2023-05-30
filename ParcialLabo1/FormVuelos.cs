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
    public partial class FormVuelos : Form
    {
        List<Vuelo> listaVuelos = new List<Vuelo>();
        string rutaActual;
        string rutaArchivoVuelos;

        public FormVuelos()
        {
            InitializeComponent();
            rutaActual = Directory.GetCurrentDirectory();
            rutaArchivoVuelos = Path.Combine(rutaActual, "Vuelos.xml");
            if (File.Exists(rutaArchivoVuelos))
            {
                listaVuelos = SerializacionXml.DeserializarObjetoXml<List<Vuelo>>(rutaArchivoVuelos);
            }
            else
            {
                DialogResult resultado = MessageBox.Show($"No existe el archivo");

            }
        }

        private void FormVuelos_Load(object sender, EventArgs e)
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
                row.Cells[5].Value = item.CatidadAsientosPremium;
                row.Cells[6].Value = item.PrecioPremium;
                row.Cells[7].Value = item.CantidadAsientosTurista;
                row.Cells[8].Value = item.PrecioTurista;
                row.Cells[9].Value = $"{item.DuracionVuelo}hs";
            }
        }

        private void buttonAgregarVuelo_Click(object sender, EventArgs e)
        {
            FormAgregarVuelo formAgregarVuelo = new FormAgregarVuelo();
            formAgregarVuelo.ShowDialog();
        }
        //eliminar
        private void button2_Click(object sender, EventArgs e)
        {

            string codigoVueloEliminar = textBoxCodigoEliminar.Text;

            Vuelo vueloEliminar = Vuelo.BuscarVueloPorCodigo(listaVuelos, codigoVueloEliminar);


            if (vueloEliminar.CodigoDeVuelo == codigoVueloEliminar)
            {
                int index = listaVuelos.FindIndex(i => i.CodigoDeVuelo == vueloEliminar.CodigoDeVuelo);
                

                DialogResult resultado = MessageBox.Show("Desea Eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(vueloEliminar.FechaVuelo > DateTime.Now)
                {
                    if (resultado == DialogResult.Yes)
                    {
                        listaVuelos.RemoveAt(index);
                        SerializacionXml.SerializarObjetoXml(rutaArchivoVuelos, listaVuelos);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar un viaje que ya paso!");
                }
            }
            else
            {
                MessageBox.Show("No se encotro el vuelo");
            }
        }


        //Modificar
        private void button1_Click(object sender, EventArgs e)
        {
            string codigoVueloModificar = textBoxCodigoEliminar.Text;

            Vuelo vueloModificar = Vuelo.BuscarVueloPorCodigo(listaVuelos, codigoVueloModificar);

            FormModificarVuelo formModificarVuelo = new FormModificarVuelo(vueloModificar);
            formModificarVuelo.ShowDialog();
        }
    }
}
