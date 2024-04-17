using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
namespace ExamenRecuperacion_Abraham
{
    public partial class Form1 : Form
    {
        VentaServiceClient client = new VentaServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxCantidadPersonas_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoRuta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string tipoCliente = cbxTipoCliente.SelectedItem.ToString();
            int cantidadPersonas = Convert.ToInt32(tbxCantidadPersonas.Text);
            int tipoRuta = Convert.ToInt32(cbxTipoRuta.SelectedItem.ToString());

            try
            {
                float importeBruto, porcentajeDescuento, montoDescuento, importePago;
                client.CalcularMontosVenta(tipoCliente, cantidadPersonas, tipoRuta,
                    out importeBruto, out porcentajeDescuento, out montoDescuento, out importePago);

                tbxImporteBruto.Text = importeBruto.ToString();
                tbxPorcentajeDescuento.Text = porcentajeDescuento.ToString();
                tbxMontoDescuento.Text = montoDescuento.ToString();
                tbxImportePago.Text = importePago.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular los montos de la venta: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        [ServiceContract]
        public interface IVentaService
        {
            [OperationContract]
            void EjecutarProcedimientoAlmacenado();
        }

    }
    }
}
