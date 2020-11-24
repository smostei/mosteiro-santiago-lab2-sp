using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    [Serializable]
    public sealed class PedidoDelivery : Pedido
    {
        private string nombreCliente;
        private string localidad;
        private string direccion;
        private int numeroDireccion;

        public PedidoDelivery() { }

        public PedidoDelivery(string nombrePedido, EEstado estado, float precio, bool tieneDelivery, string nombreCliente, string localidad, string direccion, int numeroDireccion) 
            : base(nombrePedido, estado, precio, tieneDelivery)
        {
            this.nombreCliente = nombreCliente;
            this.localidad = localidad;
            this.direccion = direccion;
            this.numeroDireccion = numeroDireccion;
        }

        public PedidoDelivery(int id, string nombrePedido, EEstado estado, float precio, bool tieneDelivery, string horarioPedido, string nombreCliente, string localidad, string direccion, int numeroDireccion)
            : base(id, nombrePedido, estado, precio, horarioPedido, tieneDelivery)
        {
            this.nombreCliente = nombreCliente;
            this.localidad = localidad;
            this.direccion = direccion;
            this.numeroDireccion = numeroDireccion;
        }

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int NumeroDireccion
        {
            get { return numeroDireccion; }
            set { numeroDireccion = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del cliente: {nombreCliente}");
            sb.AppendLine($"Localidad: {localidad}");
            sb.AppendLine($"Dirección: {direccion}");
            sb.AppendLine($"Número de calle: {numeroDireccion}");
            sb.AppendLine("\nMuchas gracias por su compra!");
            sb.AppendLine("---------------------------------------");

            return "-------------------TICKET-------------------\n" + base.ToString() + sb.ToString();
        }
    }
}
