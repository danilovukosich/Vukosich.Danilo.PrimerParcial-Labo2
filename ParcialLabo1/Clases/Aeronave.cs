using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo1.Clases
{
    public class Aeronave
    {
        string matricula;
        int catidadAsientosPremium;
        int cantidadAsientosTurista;
        int cantidadBanos;
        string poseeInternet;
        string ofreceComida;
        float capacidadBodega;
        float horasDeVuelo;
        Vuelo vueloAsignado;
        string estado;

        public Aeronave()
        {

        }

        public Aeronave(string matricula, int catidadAsientosPremium, int cantidadAsientosTurista, int cantidadBanos, string poseeInternet, string ofreceComida, float capacidadBodega, float horasDeVuelo, Vuelo vueloAsignado, string estado)
        {
            this.matricula = matricula;
            this.catidadAsientosPremium = catidadAsientosPremium;
            this.cantidadAsientosTurista = cantidadAsientosTurista;
            this.cantidadBanos = cantidadBanos;
            this.poseeInternet = poseeInternet;
            this.ofreceComida = ofreceComida;
            this.capacidadBodega = capacidadBodega;
            this.horasDeVuelo = horasDeVuelo;
            this.vueloAsignado = vueloAsignado;
            this.estado = estado;
        }

        public string Matricula
        { 
            get { return this.matricula; }
            set { this.matricula = value;}
        }

        public int CantidadAsientosPremium
        {
            get { return this.catidadAsientosPremium; }
            set { this.catidadAsientosPremium = value; }
        }

        public int CantidadAsientosTurista
        {
            get { return this.cantidadAsientosTurista; }
            set { this.cantidadAsientosTurista = value; }
        }

        public int CantidadBanos
        {
            get { return this.cantidadBanos; }
            set { this.cantidadBanos = value; }
        }

        public string PoseeInternet
        { 
            get { return this.poseeInternet;}
            set { this.poseeInternet = value;}
        }

        public string OfreceComida
        {
            get { return this.ofreceComida; }
            set { this.ofreceComida = value; }
        }

        public float CapacidadBodega
        {
            get { return this.capacidadBodega; }
            set { this.capacidadBodega = value; }
        }

        public float HorasDeVuelo
        {
            get { return this.horasDeVuelo; }
            set { this.horasDeVuelo = value; }
        }

        public Vuelo VueloAsignado
        {
            get { return this.vueloAsignado; }
            set { this.vueloAsignado = value; }
        }

        public string Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public static bool operator ==(Aeronave p1, Aeronave p2)
        {

            if (!(p1 is null || p2 is null))
            {
                return p1.Matricula == p2.Matricula;
            }
            return false;

        }

        public static bool operator !=(Aeronave p1, Aeronave p2)
        {
            return !(p1 == p2);
        }


        /// <summary>
        /// Genera una matricula aleatoria para el avion iniciando con 2 letras y siguendo con 6 numeros
        /// </summary>
        /// <returns> String matricula</returns>
        public static string GenerarMatricula()
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";

            StringBuilder matricula = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                if (i < 2)
                {
                    matricula.Append(letras[random.Next(letras.Length)]);
                }
                else
                {
                    matricula.Append(numeros[random.Next(numeros.Length)]);
                }
            }

            return matricula.ToString();
        }


        /// <summary>
        /// Busca una aeronave en una lista de aeronaves por matricula
        /// </summary>
        /// <param name="listaAeronaves"></param>
        /// <param name="matricula"></param>
        /// <returns> Aeronave que coincida con la busqueda </returns>
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

    }
}
