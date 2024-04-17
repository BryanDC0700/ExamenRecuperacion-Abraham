using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica_negocio
{
    public class ValidadorDatos
    {
        public static bool ValidarTipoCliente(char tipoCliente)
        {
            return (tipoCliente == 'A' || tipoCliente == 'B' || tipoCliente == 'C');
        }

        public static bool ValidarCantidadPersonas(int cantidad)
        {
            return (cantidad > 0);
        }

        public static bool ValidarTipoRuta(int tipoRuta)
        {
            return (tipoRuta >= 1 && tipoRuta <= 3);
        }
    }

}
