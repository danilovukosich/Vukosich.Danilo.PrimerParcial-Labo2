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
    public partial class FormVenta : Form
    {
        string rutaActual;
        string rutaArchivoPasajeros;
        string rutaArchivoVuelos;
        //string rutaArchivoAeronaves;

        //string[] opcionesDniPasajeros;//Dni para combobox
        string[] opcionesCodigoVuelos;//Codigo vuelo combobox
        DateTime fechaActual;

        List<Pasajero> listaPasajeros = new List<Pasajero>();
        List<Vuelo> listaVuelos = new List<Vuelo>();
        //List<Aeronave> listaAeronaves = new List<Aeronave>();

        public FormVenta()
        {
            InitializeComponent();
            rutaActual = Directory.GetCurrentDirectory();

            rutaArchivoPasajeros = Path.Combine(rutaActual, "Pasajeros.xml");
            listaPasajeros = SerializacionXml.DeserializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros);

            rutaArchivoVuelos = Path.Combine(rutaActual, "Vuelos.xml");
            listaVuelos = SerializacionXml.DeserializarObjetoXml<List<Vuelo>>(rutaArchivoVuelos);

            //rutaArchivoAeronaves = Path.Combine(rutaActual, "Aeronaves.json");
            //listaAeronaves = SerializacionJson.DeserializarJson<List<Aeronave>>(rutaArchivoAeronaves);

            fechaActual = DateTime.Now;//fecha actual

            //opcionesCodigoVuelos = new string[listaVuelos.Count];
            //for (int i = 0; i < listaVuelos.Count; i++)
            //{
            //    //if (listaVuelos[i].FechaVuelo >= fechaActual)//solo vuelos que no salieron
            //    //{
            //    opcionesCodigoVuelos[i] = listaVuelos[i].CodigoDeVuelo;
            //    //}

            //}
            //comboBoxCodigoVuelos.DataSource = opcionesCodigoVuelos;

            //opcionesDniPasajeros = new string[listaPasajeros.Count];
            //for (int i = 0; i < listaPasajeros.Count; i++)
            //{
            //    if (listaPasajeros[i].Estado.ToLower() == "sin estado")
            //    {
            //        opcionesDniPasajeros[i] = listaPasajeros[i].Dni;
            //    }

            //}
            //comboBoxDniPasajeros.DataSource = opcionesDniPasajeros;

            textBoxDniPasajero.MaxLength = 8;
            textBoxCodigoVuelo.MaxLength = 6;

        }

        private void FormVenta_Load(object sender, EventArgs e)
        {

            dataGridViewListaVuelos.Rows.Clear();

            foreach (Vuelo item in listaVuelos)
            {
                //vuelos con fecha actual o futura
                if (item.FechaVuelo >= fechaActual)
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

            dataGridViewListaPasajeros.Rows.Clear();

            foreach (Pasajero item in listaPasajeros)
            {
                //psajeros que no tengan un vuelo asignado.
                //if (item.Estado.ToLower() == "sin estado")
                //{
                    int rowIndex = dataGridViewListaPasajeros.Rows.Add();
                    DataGridViewRow row = dataGridViewListaPasajeros.Rows[rowIndex];
                    row.Cells[0].Value = item.Dni;
                    row.Cells[1].Value = item.Nombre;
                    row.Cells[2].Value = item.Apellido;
                //}
            }
        }

        private void radioButtonClasePremium_CheckedChanged(object sender, EventArgs e)
        {
            //max 42kg
            numericUpDownPesoequipaje.Minimum = 0;
            numericUpDownPesoequipaje.Maximum = 42;

        }

        private void radioButtonClaseTurista_CheckedChanged(object sender, EventArgs e)
        {
            //max 21kg
            numericUpDownPesoequipaje.Minimum = 0;
            numericUpDownPesoequipaje.Maximum = 21;
        }
        private void textBoxDniPasajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void buttonAgregarVuelo_Click(object sender, EventArgs e)//venta
        {
            //int indexPasajero = listaPasajeros.FindIndex(i => i.Dni == comboBoxDniPasajeros.Text);//texboxDniPasajeros.Text
            int indexPasajero = listaPasajeros.FindIndex(i => i.Dni == textBoxDniPasajero.Text);

            if(indexPasajero != -1)
            {
                listaPasajeros[indexPasajero].NumeroDeVuelos += 1;

                if (checkBoxEquipajeMano.Checked)
                {
                    listaPasajeros[indexPasajero].EqupajeMano = "Si";
                }
                else
                {
                    listaPasajeros[indexPasajero].EqupajeMano = "No";
                }

                if (checkBoxEquipajeBodega.Checked)
                {
                    listaPasajeros[indexPasajero].EquipajeBodega = "Si";
                    listaPasajeros[indexPasajero].PesoEquipaje = (float)numericUpDownPesoequipaje.Value;
                }
                else
                {
                    listaPasajeros[indexPasajero].EquipajeBodega = "No";
                }

                listaPasajeros[indexPasajero].Estado = "Vuelo Asignado";

                int indexVuelo = listaVuelos.FindIndex(i => i.CodigoDeVuelo == textBoxCodigoVuelo.Text);

                bool bandera = false;

                foreach(Pasajero pasajero in listaVuelos[indexVuelo].ListaPasajeros)
                {
                    if(pasajero.Dni == textBoxDniPasajero.Text)
                    {
                        bandera = true;
                    }
                }


                if (indexVuelo != -1 )
                {
                    if(bandera== false)
                    {
                        listaVuelos[indexVuelo].PesoCabotajeTotal += (float)numericUpDownPesoequipaje.Value;

                        //asientos disponibles disminuyen y ganancias aumentas
                        if (radioButtonClasePremium.Checked)
                        {
                            listaPasajeros[indexPasajero].Clase = "Premium";
                            listaVuelos[indexVuelo].CatidadAsientosPremium -= 1;
                            listaVuelos[indexVuelo].GananciaTotal += listaVuelos[indexVuelo].PrecioPremium;
                        }
                        if (radioButtonClaseTurista.Checked)
                        {
                            listaVuelos[indexVuelo].CantidadAsientosTurista -= 1;
                            listaVuelos[indexVuelo].GananciaTotal += listaVuelos[indexVuelo].PrecioTurista;
                            listaPasajeros[indexPasajero].Clase = "Turista";
                        }

                        listaVuelos[indexVuelo].ListaPasajeros.Add(listaPasajeros[indexPasajero]);

                        SerializacionXml.SerializarObjetoXml(rutaArchivoPasajeros, listaPasajeros);
                        SerializacionXml.SerializarObjetoXml(rutaArchivoVuelos, listaVuelos);
                        MessageBox.Show($"Venta Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Este pasajero ya esta en este vuelo!");
                    }

                }
                else
                {
                    MessageBox.Show("No se encontro Vuelo\n" +
                                    "Prueba con uno de la lista!");
                }
            }
            else
            {
                MessageBox.Show("No se encontro Pasajero\n" +
                                    "Prueba con uno de la lista!");
            }
            




        }


    }
}
