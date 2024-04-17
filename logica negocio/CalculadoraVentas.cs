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

        
    }
}

}
