using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using Excepciones;
using Data;

namespace DeliveryPedidos
{
    public partial class FormNuevoPedido : Form
    {
        private static string MENSAJE = "Bienvenido, acá se agregan nuevos pedidos a la cola!";
        public event delMostrarMensaje enviarMensaje;

        public FormNuevoPedido()
        {
            InitializeComponent();
        }

        private void FormNuevoPedido_Load(object sender, EventArgs e)
        {
            ManejarVisibilidadVistas();
            enviarMensaje.Invoke(MENSAJE);
        }

        private void deliveryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ManejarVisibilidadVistas();
            pedidoButton.Enabled = activarBotonContinuar();
        }

        private void pedidoButton_Click(object sender, EventArgs e)
        {
            Pedido pedido;

            float auxPrecio;
            float.TryParse(precioTxtBox.Text, out auxPrecio);

            int auxDireccion;
            int.TryParse(numeroTxtBox.Text, out auxDireccion);

            if(SonDatosInvalidos(auxPrecio, auxDireccion))
            {
                MessageBox.Show(
                        "Fijate que todos los valores estén bien puestos",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                );

                return;
            }

            if(deliveryCheckBox.Checked)
            {
                pedido = new PedidoDelivery(
                    nombreTxtBox.Text,
                    Pedido.EEstado.Preparacion,
                    auxPrecio,
                    true,
                    clienteTxtBox.Text,
                    localidadTxtBox.Text,
                    direccionTxtBox.Text,
                    auxDireccion
                );

                GuardarTicketDelivery(pedido as PedidoDelivery);
            } 
            else
            {
                pedido = new Pedido(
                    nombreTxtBox.Text,
                    Pedido.EEstado.Preparacion,
                    auxPrecio,
                    false
                );
            }

            if(DataBaseHelper.InsertarPedido(pedido))
            {
                DataBaseHelper.PedidosActuales.Enqueue(DataBaseHelper.GetPedidoPorHorario(pedido.HorarioPedido));
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// booleano que determina la activacion del botón para agregar el producto a la tabla Productos.
        /// </summary>
        /// <returns></returns>
        private bool activarBotonContinuar()
        {
            bool activar;

            if(deliveryCheckBox.Checked)
            {
                activar = !(
                    string.IsNullOrWhiteSpace(nombreTxtBox.Text)
                    || string.IsNullOrWhiteSpace(precioTxtBox.Text)
                    || string.IsNullOrWhiteSpace(clienteTxtBox.Text)
                    || string.IsNullOrWhiteSpace(localidadTxtBox.Text)
                    || string.IsNullOrWhiteSpace(direccionTxtBox.Text)
                    || string.IsNullOrWhiteSpace(numeroTxtBox.Text)
                );
            } else
            {
                activar = !(string.IsNullOrWhiteSpace(nombreTxtBox.Text) || string.IsNullOrWhiteSpace(precioTxtBox.Text));
            }

            return activar;
        }

        /// <summary>
        /// Este listener se va a triggerear cada vez que cualquiera de las vistas actualice su texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oyenteTextosCambiados(object sender, EventArgs e)
        {
            pedidoButton.Enabled = activarBotonContinuar();
        }

        /// <summary>
        /// Este listener se va a triggerear cada vez que cualquiera de las vistas salga de su foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oyenteFocoSalidaTextos(object sender, EventArgs e)
        {
            ((TextBox) sender).Text = ((TextBox) sender).Text.Trim();
        }

        private void ManejarVisibilidadVistas()
        {
            bool visibilidad = deliveryCheckBox.Checked;

            datosEntregaLbl.Visible = visibilidad;
            clienteLbl.Visible = visibilidad;
            clienteTxtBox.Visible = visibilidad;
            localidadLbl.Visible = visibilidad;
            localidadTxtBox.Visible = visibilidad;
            direccionLbl.Visible = visibilidad;
            direccionTxtBox.Visible = visibilidad;
            numeroLbl.Visible = visibilidad;
            numeroTxtBox.Visible = visibilidad;
        }

        private bool GuardarTicketDelivery(PedidoDelivery delivery)
        {
            bool response = true;
            ArchivoTexto archivo = new ArchivoTexto();

            try
            {
                archivo.Guardar(delivery.ToString());
            } 
            catch(ArchivosException e)
            {
                Console.WriteLine(e.Message);
                response = false;
            }

            return response;
        }

        private bool SonDatosInvalidos(float auxPrecio, int auxDireccion)
        {
            bool response = false;

            if (deliveryCheckBox.Checked)
            {
                if (auxPrecio == 0 || auxDireccion == 0)
                {
                    response = true;
                }
            }
            else if (auxPrecio == 0)
            {
                response = true;
            }

            return response;
        }
    }
}
