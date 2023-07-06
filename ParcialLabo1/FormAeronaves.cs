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
    public partial class FormAeronaves : Form
    {
        List<Aeronave> listaAviones = new List<Aeronave>();
        string rutaActual;
        string rutaArchivoAeronaves;

        public FormAeronaves()
        {
            InitializeComponent();
            
            rutaActual = Directory.GetCurrentDirectory();
            rutaArchivoAeronaves = Path.Combine(rutaActual, "Aeronaves.json");
            listaAviones = SerializacionJson.DeserializarJson<List<Aeronave>>(rutaArchivoAeronaves);
        }

        private void FormAeronaves_Load(object sender, EventArgs e)
        {
            dataGridViewListaAeronaves.Rows.Clear();
            
            foreach (Aeronave item in listaAviones)
            {   
                
                int rowIndex = dataGridViewListaAeronaves.Rows.Add();
                DataGridViewRow row = dataGridViewListaAeronaves.Rows[rowIndex];
                row.Cells[0].Value = item.Matricula;
                row.Cells[1].Value = item.CantidadAsientosPremium;
                row.Cells[2].Value = item.CantidadAsientosTurista;
                row.Cells[3].Value = item.CantidadBanos.ToString();
                row.Cells[4].Value = item.PoseeInternet;
                row.Cells[5].Value = item.OfreceComida;
                row.Cells[6].Value = item.CapacidadBodega;
                row.Cells[7].Value = item.HorasDeVuelo;
            }
        }

        private void buttonAgregarAeronaves_Click(object sender, EventArgs e)
        {

            FormAgregarAeronave formagrgarAeronave = new FormAgregarAeronave();
            formagrgarAeronave.ShowDialog();
        }
        public static Aeronave BuscarAeronavePorMatricula(List<Aeronave> listaAeronaves, string matricula)
        {
            
            Aeronave aeronaveAux = new Aeronave();
            foreach (Aeronave item in listaAeronaves)
            {
                if (item.Matricula == matricula)
                {
                    aeronaveAux = item;
                }
            }
            return aeronaveAux;
        }

        private void buttonModificarAeronave_Click(object sender, EventArgs e)
        {
            
            string matriculaAModificar = textBoxMatriculaAModificar.Text;

            Aeronave aeronaveAux = new Aeronave();
            aeronaveAux = BuscarAeronavePorMatricula(listaAviones, matriculaAModificar);

            if (matriculaAModificar == aeronaveAux.Matricula)
            {
                if (aeronaveAux.Estado == "Sin Vuelo")
                {
                    FormModificarAeronave formModificarAeronave = new FormModificarAeronave(aeronaveAux);
                    formModificarAeronave.ShowDialog();
                }
                else { MessageBox.Show("El Avion no se puede eliminar\nporque tiene un vuelo asignado!"); }


            }
            else
            {
                MessageBox.Show("No se encotro el avion");
            }
        }

        private void buttonEliminarAeronave_Click(object sender, EventArgs e)
        {

            string matriculaAeronaveEliminar=textBoxMatriculaAEliminar.Text;

            Aeronave aeronaveEliminar = BuscarAeronavePorMatricula(listaAviones, matriculaAeronaveEliminar);


            if(aeronaveEliminar.Matricula==matriculaAeronaveEliminar)
            {
                if(aeronaveEliminar.Estado == "Sin Vuelo")
                {
                    int index = listaAviones.FindIndex(i => i.Matricula == aeronaveEliminar.Matricula);


                    DialogResult resultado = MessageBox.Show("Desea Eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.Yes)
                    {
                        listaAviones.RemoveAt(index);
                        SerializacionJson.SerializarAJson<List<Aeronave>>(rutaArchivoAeronaves, listaAviones);
                        MessageBox.Show("Eliminado Exitosamente!");
                    }
                }
                else { MessageBox.Show("El Avion no se puede eliminar\nporque tiene un vuelo asignado!"); }
                
            }
            else
            {
                MessageBox.Show("No se encotro el avion");
            }
        }
    }
}
