using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCliente
    {
        public IEnumerable<CECliente> listarCliente(string xml)
        {
            CDCliente obj = new CDCliente();

            return obj.listarCliente(xml);
        }

        public IEnumerable<CECliente> agregarCliente(string nombre, string tipo, string numero)
        {
            CDCliente obj = new CDCliente();

            return obj.agregarCliente(nombre, tipo, numero);
        }

        public IEnumerable<CECliente> buscarCliente(string numero)
        {
            CDCliente obj = new CDCliente();

            return obj.buscarCliente(numero);
        }

        public IEnumerable<CECliente> eliminarCliente(string numero)
        {
            CDCliente obj = new CDCliente();

            return obj.eliminarCliente(numero);
        }

        public IEnumerable<CECliente> actualizaCliente(string nombre, string tipo, string numero)
        {
            CDCliente obj = new CDCliente();

            return obj.actualizaCliente(nombre, tipo, numero);
        }
    }
}
