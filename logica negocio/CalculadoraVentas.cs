using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacion_Abraham
{
public class CalculadoraVentas
{
    public static void CalcularMontosVenta(char tipoCliente, int cantidadPersonas, int tipoRuta,
        out float importeBruto, out float porcentajeDescuento, out float montoDescuento, out float importePago)
    {
        float[] precios = { 100, 120, 150 };

        float precioPorPersona = precios[tipoRuta - 1];

        importeBruto = cantidadPersonas * precioPorPersona;

        if (cantidadPersonas == 1)
        {
            porcentajeDescuento = 0;
        }
        else if (cantidadPersonas >= 2 && cantidadPersonas <= 7)
        {
            porcentajeDescuento = 8;
        }
        else if (cantidadPersonas >= 8 && cantidadPersonas <= 16)
        {
            porcentajeDescuento = 13;
        }
        else
        {
            porcentajeDescuento = 15;
        }
        
    }
}

}
