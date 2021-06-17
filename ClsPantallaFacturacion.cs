using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_proyecto
{
    class ClsPantallaFacturacion
    {
        private String fecha;
        private String Vendedor;
        private String nombreCliente;
        private String apellidoCliente;
        private String direccion;
        private String rtn;
        private String nombreVendedor;
        private String descripcionProducto;
        private double precioUnitario;
        private double descuento;
        private double sumaDescuentos;
        private double subTotal;
        private double importeExcento;
        private double importeExonerado;
        private double importeAgravado15;
        private double importeAgravado18;
        private double isv15;
        private double isv18;
        private double totalPagar;
        private int numeroFactura;
        private int codigoProducto;
        private int cantidad;
        private int tipoPago;
        private int indexTabla;








        public string Fecha { get => fecha; set => fecha = value; }
        public string Vendedor1 { get => Vendedor; set => Vendedor = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Rtn { get => rtn; set => rtn = value; }
        public string NombreVendedor { get => nombreVendedor; set => nombreVendedor = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double SumaDescuentos { get => sumaDescuentos; set => sumaDescuentos = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        public double ImporteExcento { get => importeExcento; set => importeExcento = value; }
        public double ImporteExonerado { get => importeExonerado; set => importeExonerado = value; }
        public double ImporteAgravado15 { get => importeAgravado15; set => importeAgravado15 = value; }
        public double ImporteAgravado18 { get => importeAgravado18; set => importeAgravado18 = value; }
        public double Isv15 { get => isv15; set => isv15 = value; }
        public double Isv18 { get => isv18; set => isv18 = value; }
        public double TotalPagar { get => totalPagar; set => totalPagar = value; }
        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public int CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int TipoPago { get => tipoPago; set => tipoPago = value; }
        public int IndexTabla { get => indexTabla; set => indexTabla = value; }
    }
}
