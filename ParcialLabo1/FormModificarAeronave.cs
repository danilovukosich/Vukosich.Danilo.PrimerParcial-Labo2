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
    public partial class FormModificarAeronave : Form
    {
        Aeronave aeronaveAux = new Aeronave();
        public FormModificarAeronave()
        {
            InitializeComponent();

        }
        public FormModificarAeronave(Aeronave aeronaveAModificar) : this()
        {
            aeronaveAux = aeronaveAModificar;
        }


        private void FormModificarAeronave_Load(object sender, EventArgs e)
        {
            numericUpDownAsientosPremium.Maximum = 182;
            numericUpDownAsientosPremium.Minimum = 10;
            numericUpDownAsientosTurista.Maximum = 338;
            numericUpDownAsientosTurista.Minimum = 10;
            //maximo banios
            numericUpDownCantidadBanos.Maximum = 8;
            numericUpDownCantidadBanos.Minimum = 1;
            //maximo bodega
            numericUpDownCapcidadBodega.Maximum = 10000;
            numericUpDownCapcidadBodega.Minimum = 1000;

            labelMatriculaValor.Text = aeronaveAux.Matricula;
            numericUpDownAsientosPremium.Value = aeronaveAux.CantidadAsientosPremium;
            numericUpDownAsientosTurista.Value = aeronaveAux.CantidadAsientosTurista;
            numericUpDownCantidadBanos.Value = aeronaveAux.CantidadBanos;
            numericUpDownCapcidadBodega.Value = (int)aeronaveAux.CapacidadBodega;
            if (aeronaveAux.PoseeInternet.ToLower() == "si")
            {
                radioButtonSiInternet.Checked = true;
            }
            if (aeronaveAux.PoseeInternet.ToLower() == "no")
            {
                radioButtonNoInternet.Checked = true;
            }
            if (aeronaveAux.OfreceComida.ToLower() == "si")
            {
                radioButtonSiComida.Checked = true;
            }
            if (aeronaveAux.OfreceComida.ToLower() == "no")
            {
                radioButtonNoComida.Checked = true;
            }



        }

        private void buttonAceptarModificar_Click(object sender, EventArgs e)
        {
            string rutaActual = Directory.GetCurrentDirectory();
            string rutaArchivoAeronaves = Path.Combine(rutaActual, "Aeronaves.json");

            List<Aeronave> listaAviones = new List<Aeronave>();
            listaAviones = SerializacionJson.DeserializarJson<List<Aeronave>>(rutaArchivoAeronaves);
            int index = listaAviones.FindIndex(i => i.Matricula == aeronaveAux.Matricula);



            listaAviones[index].Matricula = aeronaveAux.Matricula;
            listaAviones[index].CantidadAsientosPremium = (int)numericUpDownAsientosPremium.Value;
            listaAviones[index].CantidadAsientosTurista = (int)numericUpDownAsientosTurista.Value;
            listaAviones[index].CantidadBanos=(int)numericUpDownCantidadBanos.Value;
            listaAviones[index].CapacidadBodega=(int)numericUpDownCapcidadBodega.Value;

            if (radioButtonSiInternet.Checked)
            {
                listaAviones[index].PoseeInternet = (string)radioButtonSiInternet.Text;
            }
            if (radioButtonNoInternet.Checked)
            {
                listaAviones[index].PoseeInternet = (string)radioButtonNoInternet.Text;
            }

           
            if (radioButtonSiComida.Checked)
            {
                listaAviones[index].OfreceComida = (string)radioButtonSiComida.Text;
            }
            if (radioButtonNoComida.Checked)
            {
                listaAviones[index].OfreceComida = (string)radioButtonNoComida.Text;
            }

            DialogResult resultado = MessageBox.Show("Desea realizar los cambios?", "Modificar Aeronave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                SerializacionJson.SerializarAJson<List<Aeronave>>(rutaArchivoAeronaves, listaAviones);
                Close();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
