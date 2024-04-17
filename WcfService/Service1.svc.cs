using ExamenRecuperacion_Abraham;
using logica_negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public void CalcularMontosVenta(char tipoCliente, int cantidadPersonas, int tipoRuta,
            out float importeBruto, out float porcentajeDescuento, out float montoDescuento, out float importePago)
        {
            if (!ValidadorDatos.ValidarTipoCliente(tipoCliente))
                throw new ArgumentException("Tipo de cliente no válido.");

            if (!ValidadorDatos.ValidarCantidadPersonas(cantidadPersonas))
                throw new ArgumentException("Cantidad de personas no válida.");

            if (!ValidadorDatos.ValidarTipoRuta(tipoRuta))
                throw new ArgumentException("Tipo de ruta no válido.");
            object value = CalculadoraVentas.CalcularMontosVenta(tipoCliente, cantidadPersonas, tipoRuta,
                out importeBruto, out porcentajeDescuento, out montoDescuento, out importePago);
        }
    }

}
