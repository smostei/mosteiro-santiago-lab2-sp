using System;
using System.Text;
using Extensiones;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(PedidoDelivery))]
    public class Pedido
    {
        public enum EEstado
        {
            Preparacion,
            EnCamino,
            Completado
        }

        private int id;
        private string nombrePedido;
        private EEstado estado;
        private float precio;
        private string horarioPedido;
        private bool tieneDelivery;

        public Pedido() { }

        public Pedido(string nombrePedido, EEstado estado, float precio, bool tieneDelivery)
        {
            this.nombrePedido = nombrePedido;
            this.estado = estado;
            this.precio = precio;
            this.tieneDelivery = tieneDelivery;
            horarioPedido = DateTime.Now.HoraActualFormateada(); //Extensión de la fecha actual
        }
        public Pedido(int id, string nombrePedido, EEstado estado, float precio, string horarioPedido, bool tieneDelivery)
        {
            this.id = id;
            this.nombrePedido = nombrePedido;
            this.estado = estado;
            this.precio = precio;
            this.horarioPedido = horarioPedido;
            this.tieneDelivery = tieneDelivery;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombrePedido
        {
            get { return nombrePedido; }
            set { nombrePedido = value; }
        }

        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string HorarioPedido
        {
            get { return horarioPedido; }
            set { horarioPedido = value; }
        }

        public bool TieneDelivery
        {
            get { return tieneDelivery; }
            set { tieneDelivery = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del pedido solicitado: {nombrePedido}");
            sb.AppendLine($"Estado del pedido: {estado}");
            sb.AppendLine($"Precio {precio}");

            return sb.ToString();
        }
    }
}
