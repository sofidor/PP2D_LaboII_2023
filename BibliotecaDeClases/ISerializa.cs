using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public interface ISerializa <T>
    {
        public void SerializarJson(List<T> listaASerializar);

        public void SerializarXml (List<T> listaASerializar);      

    }
}
