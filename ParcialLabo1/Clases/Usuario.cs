using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ParcialLabo1.Clases
{
    public class Usuario : Persona
    {
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;

        public Usuario()
        {

        }

        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, string perfil) : base(apellido, nombre)
        {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

        //setter y getters
        [JsonPropertyName("legajo")]
        public int Legajo
        { 
            get { return legajo; } 
            set { this.legajo = value; } 
        }

        [JsonPropertyName("correo")]
        public string Correo
        { 
            get { return correo; } 
            set { this.correo = value; } 
        }

        [JsonPropertyName("clave")]
        public string Clave
        { 
            get { return clave; } 
            set { this.clave = value; } 
        }

        [JsonPropertyName("perfil")]
        public string Perfil
        { 
            get { return perfil; } 
            set { this.perfil = value; }
        }

        /// <summary>
        /// Valida que los datos ingresados en el inicio de sesion sean validos
        /// </summary>
        /// <param name="listaUsuarios"></param>
        /// <param name="correo"></param>
        /// <param name="clave"></param>
        /// <returns> Usuario si es valido, sino null</returns>
        static public Usuario ValidarCredenciales(List<Usuario> listaUsuarios, string correo, string clave)
        {

            Usuario usuarioIngresado = null;
            
            foreach(Usuario item in listaUsuarios)
            {
               if (item.Correo == correo && item.Clave== clave)
                {
                    usuarioIngresado = item;
                }
             
            }

            return usuarioIngresado;
        }
    }
}
