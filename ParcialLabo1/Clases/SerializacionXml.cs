using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParcialLabo1.Clases
{
    internal class SerializacionXml
    {
        
        public static void SerializarObjetoXml<T>(string ruta, T objeto)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(streamWriter, objeto);
            }
        }

        public static T DeserializarObjetoXml<T>(string ruta)
         where T : class
        {
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                T objeto = xmlSerializer.Deserialize(streamReader) as T;
                return objeto;
            }
        }
    }
}
