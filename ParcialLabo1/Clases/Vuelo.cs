using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ParcialLabo1.Clases
{
    public class Vuelo
    {
        string codigoDeVuelo;
        string partida;
        DateTime horarioSalida;
        string destino;
        DateTime fechaVuelo;
        Aeronave aeronaveAsiganada;
        int catidadAsientosPremium;
        int cantidadAsientosTurista;
        float precioPremium;
        float precioTurista;
        float duracionVuelo;
        List<Pasajero> listaPasajeros;
        float pesoCabotajeTotal;
        float gananciaTotal;
        string cabotajeInternacional;

        public Vuelo()
        {

        }

        public Vuelo(string codigoDeVuelo, string partida, string destino, DateTime fechaVuelo, Aeronave aeronaveAsiganada, int catidadAsientosPremium, int cantidadAsientosTurista, float precioPremium, float precioTurista, float duracionVuelo, List<Pasajero> listaPasajeros, float pesoCabotajeTotal, DateTime horarioSalida, float gananciaTotal, string cabotajeInternacional)
        {
            this.codigoDeVuelo = codigoDeVuelo;
            this.partida = partida;
            this.destino = destino;
            this.fechaVuelo = fechaVuelo;
            this.aeronaveAsiganada = aeronaveAsiganada;
            this.catidadAsientosPremium = catidadAsientosPremium;
            this.cantidadAsientosTurista = cantidadAsientosTurista;
            this.precioPremium = precioPremium;
            this.precioTurista = precioTurista;
            this.duracionVuelo = duracionVuelo;
            this.listaPasajeros = listaPasajeros;//venta
            this.pesoCabotajeTotal = pesoCabotajeTotal;//venta
            this.horarioSalida = horarioSalida;
            this.gananciaTotal = gananciaTotal;
            this.cabotajeInternacional = cabotajeInternacional;
        }
        public string CodigoDeVuelo
        {
            get { return codigoDeVuelo; }
            set { codigoDeVuelo = value; }
        }

        public string Partida
        {
            get { return partida; }
            set { partida = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public DateTime FechaVuelo
        {
            get { return fechaVuelo; }
            set { fechaVuelo = value; }
        }

        public Aeronave Aeronave
        {
            get { return aeronaveAsiganada; }
            set { aeronaveAsiganada = value; }
        }

        public int CatidadAsientosPremium
        {
            get { return catidadAsientosPremium; }
            set { catidadAsientosPremium = value; }
        }

        public int CantidadAsientosTurista
        {
            get { return cantidadAsientosTurista; }
            set { cantidadAsientosTurista = value; }
        }

        public float PrecioPremium
        {
            get { return precioPremium; }
            set { precioPremium = value; }
        }

        public float PrecioTurista
        {
            get { return precioTurista; }
            set { precioTurista = value; }
        }

        public float DuracionVuelo
        {
            get { return duracionVuelo; }
            set { duracionVuelo = value; }
        }

        public List<Pasajero> ListaPasajeros
        {
            get { return listaPasajeros; }
            set { listaPasajeros = value; }
        }


        public float PesoCabotajeTotal
        {
            get { return pesoCabotajeTotal; }
            set { pesoCabotajeTotal = value; }
        }

        public DateTime HorarioSalida
        {
            get { return horarioSalida; }
            set { horarioSalida = value; }
        }

        public float GananciaTotal
        {
            get { return gananciaTotal; }
            set { gananciaTotal = value; }
        }
        public string CabotajeInternacional
        {
            get { return cabotajeInternacional; }
            set {  cabotajeInternacional = value; }
        }

        public static bool operator ==(Vuelo p1, Vuelo p2)
        {

            if (!(p1 is null || p2 is null))
            {
                return p1.CodigoDeVuelo == p2.CodigoDeVuelo;
            }
            return false;

        }

        public static bool operator !=(Vuelo p1, Vuelo p2)
        {
            return !(p1 == p2);
        }


        public static string GenerarCodigoVuelo()
        {
            Random random = new Random();
            string codigo = "";

            for (int i = 0; i < 6; i++)
            {
                codigo += random.Next(10); // Genera un número aleatorio del 0 al 9
            }

            return codigo;
        }
        //El costo del pasaje se calculará en base a la duración del mismo y el tipo de clase que se
        //ha elegido:
        //● Cada hora de vuelo costará 50 dólares en destinos nacionales y 100 dólares en
        //destinos internacionales(ambos en categoría Turista).
        //● Clase Turista: Podrá llevar un bolso de mano y despachar solo una valija de hasta
        //25 kg.
        //● Clase Premium: Podrá llevar un bolso de mano y despachar hasta dos valijas de
        //hasta 21 kg cada una.Esta clase cuesta un 35% más de lo que costaría el mismo
        //pasaje para turista.
        public static int CalcularDuracionVueloNacional()
        {
            //diccionarion con el tiempo de vuelo por cada destino desde buenosaires
            Random random = new Random();
            int duracionVuelo = 0;

            duracionVuelo = random.Next(2,4);

            return duracionVuelo;
        }

        public static int CalcularDuracionVueloInteracional()
        {
            
            Random random = new Random();
            int duracionVuelo = 0;

            duracionVuelo = random.Next(8, 12);


            return duracionVuelo;
        }


        public static float CalcularPrecioInternacional(string clase, float horasVuelo)
        {
            float precio = horasVuelo * 100;

            if(clase.ToLower() == "premium")
            {
                precio = precio * 1.35f;
            }

            return precio;
        }

        public static float CalcularPrecioNacional(string clase, float horasVuelo)
        {
            float precio = horasVuelo * 50;

            if (clase.ToLower() == "premium")
            {
                precio = precio * 1.35f;
            }

            return precio;
        }

        public static Vuelo BuscarVueloPorCodigo(List<Vuelo> lsitaVuelos, string codigo)
        {
            Vuelo vueloAux = new Vuelo();
            foreach (Vuelo item in lsitaVuelos)
            {
                if (item.codigoDeVuelo == codigo)
                {
                    vueloAux = item;
                }
            }
            return vueloAux;
        }


    }
}
