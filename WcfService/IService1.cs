using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    public class ventas
    {
        public string tipoCliente { get; set; }
        public int cantidadPersonas { get; set; }
        public int tipoRuta { get; set; }
        public float importeBruto { get; set; }
        public float porcentajeDescuento { get; set; }
        public float montoDescuento { get; set; }
        public float importePago { get; set; }  
    }
    public interface IVentaService
    {
        [OperationContract]
        void CalcularMontosVenta(string tipoCliente, int cantidadPersonas, int tipoRuta,
            out float importeBruto, out float porcentajeDescuento, out float montoDescuento, out float importePago);
    }

}
