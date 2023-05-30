using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ParcialLabo1.Clases
{
    public class Persona
    {
        string apellido;
        string mombre;

        public Persona() 
        {

        }
        public Persona(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.Nombre = nombre;
        }

        [JsonPropertyName("apellido")]
        public string Apellido
        { 
            get { return apellido; }
            set { apellido = value; }
        }

        [JsonPropertyName("nombre")]
        public string Nombre
        {
            get { return mombre; }
            set { mombre = value; }
        }
    }

    

}
