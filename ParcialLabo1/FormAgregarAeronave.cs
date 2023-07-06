using ParcialLabo1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialLabo1
{
    public partial class FormAgregarAeronave : Form
    {
        Aeronave aeronaveNueva = new Aeronave();

        public FormAgregarAeronave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutaActual = Directory.GetCurrentDirectory();
            string rutaArchivoAeronaves = Path.Combine(rutaActual, "Aeronaves.json");

            List<Aeronave> listaAviones = new List<Aeronave>();

            if (File.Exists(rutaArchivoAeronaves))
            {
                listaAviones = SerializacionJson.DeserializarJson<List<Aeronave>>(rutaArchivoAeronaves);
            }
            else
            {
                DialogResult resultado = MessageBox.Show($"No existe el archivo");
                Close();
            }

            //agregar aeronave
            aeronaveNueva.Matricula = Aeronave.GenerarMatricula();
            aeronaveNueva.CantidadAsientosTurista = (int)numericUpDownAsientosTurista.Value;
            aeronaveNueva.CantidadAsientosPremium = (int)numericUpDownAsientosPremium.Value;
            aeronaveNueva.CantidadBanos = (int)numericUpDownBanios.Value;
            aeronaveNueva.CapacidadBodega = (float)numericUpDownBodegas.Value;
            string poseeInternet = "";
            string ofreceComida = "";
            if (radioButtonSiPoseeInternet.Checked)
            {
                poseeInternet = "Si";
            }
            if (radioButtonNoPoseeInternet.Checked)
            {
                poseeInternet = "No";
            }
           
            if (radioButtonSiOfreceComida.Checked)
            {
                ofreceComida = "Si";
            }
            if (radioButtonNoOfreceComida.Checked)
            {
                ofreceComida = "No";
            }

            aeronaveNueva.OfreceComida = ofreceComida;
            aeronaveNueva.PoseeInternet = poseeInternet;

            aeronaveNueva.HorasDeVuelo = 0;

            aeronaveNueva.Estado = "Sin Vuelo";

            Vuelo vueloVacio = new Vuelo();
            aeronaveNueva.VueloAsignado = vueloVacio;


            if(aeronaveNueva.CantidadAsientosPremium!=0 && aeronaveNueva.CantidadAsientosTurista!=0 && aeronaveNueva.CapacidadBodega!=0 && aeronaveNueva.PoseeInternet != "" &&aeronaveNueva.OfreceComida != "")
            {
                listaAviones.Add(aeronaveNueva);

                SerializacionJson.SerializarAJson<List<Aeronave>>(rutaArchivoAeronaves, listaAviones);
                MessageBox.Show("Agregado Exitosamente!");
                Close();
            }
            else 
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregarAeronave_Load(object sender, EventArgs e)
        {
            //maximo de asientos 520 asiento del avion mas grande
            //35%premium 65%turista

            numericUpDownAsientosPremium.Maximum = 182;
            numericUpDownAsientosPremium.Minimum = 10;
            numericUpDownAsientosTurista.Maximum = 338;
            numericUpDownAsientosTurista.Minimum = 10;
            //maximo banios
            numericUpDownBanios.Maximum = 8;
            numericUpDownBanios.Minimum = 1;
            //maximo bodega
            numericUpDownBodegas.Maximum = 10000;
            numericUpDownBodegas.Minimum = 1000;

        }

        private void radioButtonSiOfreceComida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
