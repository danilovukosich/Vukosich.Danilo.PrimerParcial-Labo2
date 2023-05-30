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
    public partial class FormPasajeros : Form
    {
        List<Pasajero> listaPasajeros = new List<Pasajero>();
        string rutaActual;
        string rutaArchivoPasajeros;

        public FormPasajeros()
        {
            InitializeComponent();
            rutaActual = Directory.GetCurrentDirectory();
            rutaArchivoPasajeros = Path.Combine(rutaActual, "Pasajeros.xml");
            listaPasajeros = SerializacionXml.DeserializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros);

            dataGridViewListaPasajeros.Rows.Clear();

            foreach (Pasajero item in listaPasajeros)
            {
                int rowIndex = dataGridViewListaPasajeros.Rows.Add();
                DataGridViewRow row = dataGridViewListaPasajeros.Rows[rowIndex];
                row.Cells[0].Value = item.Dni;
                row.Cells[1].Value = item.Nombre;
                row.Cells[2].Value = item.Apellido;
                row.Cells[3].Value = item.Edad.ToString();
                row.Cells[4].Value = item.EqupajeMano;
                row.Cells[5].Value = item.EquipajeBodega;
                row.Cells[6].Value = item.Estado;
                row.Cells[7].Value = item.Clase;
            }
        }
        public static Pasajero BuscarPasajeroPorDni(List<Pasajero> listaPasajeros, string dni)
        {
            
            Pasajero pasajeroAux = new Pasajero();
            foreach (Pasajero item in listaPasajeros)
            {
                if (item.Dni == dni)
                {
                    pasajeroAux = item;
                }
            }
            return pasajeroAux;
        }

        private void buttonAgregarPasajero_Click(object sender, EventArgs e)
        {
            FormAgregarPasajero formagrgarPasajero = new FormAgregarPasajero();
            formagrgarPasajero.ShowDialog();
        }


        private void buttonEliminarPasajero_Click(object sender, EventArgs e)
        {
            string dniAEliminar = textBoxDniAEliminar.Text;

            Pasajero pasajeroEliminar = BuscarPasajeroPorDni(listaPasajeros, dniAEliminar);


            if (pasajeroEliminar.Dni == dniAEliminar)
            {
                int index = listaPasajeros.FindIndex(i => i.Dni == pasajeroEliminar.Dni);
                listaPasajeros.RemoveAt(index);

                DialogResult resultado = MessageBox.Show("Desea Eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.Yes && pasajeroEliminar.Estado.ToLower() != "vuelo asignado")
                {
                    SerializacionXml.SerializarObjetoXml<List<Pasajero>>(rutaArchivoPasajeros, listaPasajeros);
                }
                else
                {
                    MessageBox.Show("El pasajero seleccionado tiene un vuelo asignado!\nNo se puede eliminar.");
                }
            }
            else
            {
                MessageBox.Show("No se encotro el Pasajero");
            }
        }

        private void buttonModificarPasajero_Click(object sender, EventArgs e)
        {

            string dniModificar = textBoxDniPasajeroAModificar.Text;

            Pasajero pasajeroAux = new Pasajero();
            pasajeroAux = BuscarPasajeroPorDni(listaPasajeros, dniModificar);

            if (dniModificar == pasajeroAux.Dni)
            {
                if(pasajeroAux.Estado!= "Vuelo Asignado")
                {
                    FormModificarPasajero formModificar = new FormModificarPasajero(pasajeroAux);
                    formModificar.ShowDialog();
                }
                else { MessageBox.Show("El pasajero seleccionado tiene un vuelo asignado!\nNo se puede eliminar."); }
                
            }
            else
            {
                MessageBox.Show("No se encotro el Pasajero");
            }
        }
    }
}
