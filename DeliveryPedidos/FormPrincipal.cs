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
using Data;
using Archivos;
using Excepciones;
using System.Threading;

namespace DeliveryPedidos
{
    public delegate void delActualizarPedidos();
    public delegate void delMostrarMensaje(string mensaje);

    public partial class FormPrincipal : Form
    {
        private Thread threadPedidos;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarPedidosIniciales();
            SetupFormulario();

            threadPedidos = new Thread(PrepararPedidos);
            threadPedidos.Start();
        }

        /// <summary>
        /// Metodo que sirve para alternar los colores del datagridview
        /// </summary>
        /// <param name="dataGrid">datagrid que va a alternar sus filas con colores</param>
        private void AlternarColorFilasDataGrid(DataGridView dataGrid, Color backColor, Color cellStyleColor)
        {
            dataGrid.RowsDefaultCellStyle.BackColor = backColor;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = cellStyleColor;
        }

        /// <summary>
        /// Actualiza la lista de ventas que tenemos como atributo en este form con el DataBaseHelper
        /// </summary>
        /// <param name="listaVentas">información a settearle a la lista de ventas</param>
        private void RefrescarColeccion(DataGridView dataGrid, List<Pedido> pedidos)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = pedidos;
        }

        private void SetupFormulario()
        {
            AlternarColorFilasDataGrid(dataGridPreparacion, Color.Red, Color.LightPink); //Pendientes
            DataBaseHelper.PedidosActuales = new Queue<Pedido>(DataBaseHelper.GetPedidosPorEstado(Pedido.EEstado.Preparacion));
            RefrescarColeccion(dataGridPreparacion, DataBaseHelper.GetPedidosPorEstado(Pedido.EEstado.Preparacion));

            AlternarColorFilasDataGrid(dataGridCompletados, Color.Green, Color.LightGreen); //Completados
            DataBaseHelper.PedidosCompletados = DataBaseHelper.GetPedidosPorEstado(Pedido.EEstado.Completado);
            RefrescarColeccion(dataGridCompletados, DataBaseHelper.PedidosCompletados);
        }

        private void CargarPedidosIniciales()
        {
            ArchivoXml<List<Pedido>> archivoXml = new ArchivoXml<List<Pedido>>();
            List<Pedido> listaPedidosIniciales;

            if (archivoXml.Leer(out listaPedidosIniciales))
            {
                foreach(Pedido p in listaPedidosIniciales)
                {
                    DataBaseHelper.InsertarPedido(p);
                }
            }
        }

        private void PrepararPedidos()
        {
            while(DataBaseHelper.PedidosActuales.Count > 0)
            {
                int tiempoGeneracionPedido = new Random().Next(3, 8) * 1000;
                Thread.Sleep(tiempoGeneracionPedido);

                delActualizarPedidos delegadoActualizarPedidos = new delActualizarPedidos(ActualizarPedidos);

                if (InvokeRequired)
                {
                    BeginInvoke(delegadoActualizarPedidos);
                }
            }
        }

        private void ActualizarPedidos()
        {
            if(DataBaseHelper.PedidosActuales.Count > 0)
            {
                Pedido pedidoCompletado = DataBaseHelper.PedidosActuales.Dequeue();
                pedidoCompletado.Estado = Pedido.EEstado.Completado;

                DataBaseHelper.ActualizarEstadoPedido(Pedido.EEstado.Completado, pedidoCompletado.HorarioPedido);
                DataBaseHelper.PedidosCompletados.Add(pedidoCompletado);

                RefrescarColeccion(dataGridPreparacion, DataBaseHelper.PedidosActuales.ToList());
                RefrescarColeccion(dataGridCompletados, DataBaseHelper.PedidosCompletados);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadPedidos.IsAlive)
            {
                threadPedidos.Abort();
            }
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoPedido formNuevoPedido = new FormNuevoPedido();
            formNuevoPedido.enviarMensaje += MandarMensajeAFormulario;

            if (formNuevoPedido.ShowDialog() == DialogResult.OK)
            {
                MostrarMensaje(
                    "Pedido agregado a la cola!",
                    "Nuevo pedido"
                );

                RefrescarColeccion(dataGridPreparacion, DataBaseHelper.PedidosActuales.ToList());
                
                if(!threadPedidos.IsAlive)
                {
                    threadPedidos = new Thread(PrepararPedidos); //mato en memoria lo que habia en el proceso anterior para poder volver a ejecutarlo
                    threadPedidos.Start();
                }
            }
            else
            {
                MostrarMensajeError(
                    "Hubo un error al agregar el pedido",
                    "Error nuevo pedido"
                );
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void MostrarMensajeError(string mensaje, string titulo)
        {
            MessageBox.Show(
                mensaje,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

        }

        private void MostrarMensaje(string mensaje, string titulo)
        {
            MessageBox.Show(
                mensaje,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

        }

        private void MandarMensajeAFormulario(string mensaje)
        {
            MostrarMensaje(mensaje, "Información");
        }
    }
}
