using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo1.Clases
{
    public class Pasajero : Persona
    {
        private string dni;
        private int edad;
        private string equpajeMano;
        private string equipajeBodega;
        private string clase;
        private string estado;
        private float pesoEquipaje;
        private int nuemeroDeVuelos;
        //Vuelo vuelo;


        public Pasajero()
        {

        }

        public Pasajero(string nombre, string apellido, string dni, int edad, string equpajeMano, string equipajeBodega, string clase, string estado, float pesoEquipaje, int numeroDeVuelos) : base(apellido, nombre)
        {
            this.dni = dni;
            this.edad = edad;
            this.equpajeMano = equpajeMano;
            this.equipajeBodega = equipajeBodega;
            this.clase = clase;
            this.estado = estado;
            this.pesoEquipaje = pesoEquipaje;
            this.nuemeroDeVuelos = numeroDeVuelos;
        }

        
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string EqupajeMano
        {
            get { return equpajeMano; } 
            set { equpajeMano = value; } 
        }

        public string EquipajeBodega
        {
            get { return equipajeBodega; }
            set { equipajeBodega = value; }
        }

        public string Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public float PesoEquipaje
        {
            get { return pesoEquipaje; }
            set { pesoEquipaje = value; }
        }
        public int NumeroDeVuelos
        {
            get { return nuemeroDeVuelos; }
            set { nuemeroDeVuelos = value; }
        }
    }
}
