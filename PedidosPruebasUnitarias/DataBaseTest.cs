using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Extensiones;
using Data;

namespace PedidosPruebasUnitarias
{
    [TestClass]
    public class DataBaseTest
    {
        [TestMethod]
        public void InsertarNuevoPedidoExitosamente()
        {
            //arrange
            string horaActual = DateTime.Now.HoraActualFormateada();
            Pedido pedido = new Pedido("Grande de muzza (test)", Pedido.EEstado.Preparacion, 200f, false);

            //act
            DataBaseHelper.InsertarPedido(pedido);
            string horarioPedidoInsertado = DataBaseHelper.GetPedidoPorHorario(horaActual).HorarioPedido;

            DataBaseHelper.EliminarPedido(pedido.NombrePedido);

            //assert
            Assert.AreEqual(horaActual, pedido.HorarioPedido);
        }

        [TestMethod]
        public void InsertarNuevoPedidoConDeliveryExitosamente()
        {
            //arrange
            string horaActual = DateTime.Now.HoraActualFormateada();
            PedidoDelivery pedido = new PedidoDelivery(
                "Grande de muzza delivery (test)", 
                Pedido.EEstado.Preparacion, 
                200f,
                true,
                "Santiago",
                "Banfield",
                "CalleFalsa",
                123
            );

            //act
            DataBaseHelper.InsertarPedido(pedido);
            string horarioPedidoInsertado = DataBaseHelper.GetPedidoPorHorario(horaActual).HorarioPedido;

            DataBaseHelper.EliminarPedido(pedido.NombrePedido);

            //assert
            Assert.AreEqual(horaActual, horarioPedidoInsertado);
        }

        [TestMethod]
        public void DevolverTodosLosPedidosCompletados()
        {
            //arrange
            int cantidadPedidosEsperada = 2;
            int cantidadPedidos;

            PedidoDelivery p1 = new PedidoDelivery(
                "Grande de fugazzeta delivery (test)",
                Pedido.EEstado.Completado,
                200f,
                true,
                "Nahuel",
                "Lanus",
                "CalleFalsa",
                123
            );

            PedidoDelivery p2 = new PedidoDelivery(
                "Grande de calabresa delivery (test)",
                Pedido.EEstado.Preparacion,
                200f,
                true,
                "Nahuel",
                "Lanus",
                "CalleFalsa",
                123
            );

            Pedido p3 = new Pedido("Chica de muzza (test)", Pedido.EEstado.Completado, 200f, false);

            //act
            DataBaseHelper.InsertarPedido(p1);
            DataBaseHelper.InsertarPedido(p2);
            DataBaseHelper.InsertarPedido(p3);

            cantidadPedidos = DataBaseHelper.GetPedidosPorEstado(Pedido.EEstado.Completado).Count;

            DataBaseHelper.EliminarPedido(p1.NombrePedido);
            DataBaseHelper.EliminarPedido(p2.NombrePedido);
            DataBaseHelper.EliminarPedido(p3.NombrePedido);

            //assert
            Assert.IsTrue(cantidadPedidosEsperada == cantidadPedidos);
        }

        [TestMethod]
        public void DevolverTodosLosPedidosPreparacion()
        {
            //arrange
            int cantidadPedidosEsperada = 3;
            int cantidadPedidos;

            Pedido p1 = new Pedido("Chica de muzza (test)", Pedido.EEstado.Preparacion, 200f, false);
            Pedido p2 = new Pedido("Chica de calabresa (test)", Pedido.EEstado.Preparacion, 200f, false);
            Pedido p3 = new Pedido("Chica de palmitos (test)", Pedido.EEstado.Preparacion, 200f, false);
            Pedido p4 = new Pedido("Chica de provolone (test)", Pedido.EEstado.Completado, 200f, false);

            //act
            DataBaseHelper.InsertarPedido(p1);
            DataBaseHelper.InsertarPedido(p2);
            DataBaseHelper.InsertarPedido(p3);
            DataBaseHelper.InsertarPedido(p4);

            cantidadPedidos = DataBaseHelper.GetPedidosPorEstado(Pedido.EEstado.Preparacion).Count;

            DataBaseHelper.EliminarPedido(p1.NombrePedido);
            DataBaseHelper.EliminarPedido(p2.NombrePedido);
            DataBaseHelper.EliminarPedido(p3.NombrePedido);
            DataBaseHelper.EliminarPedido(p4.NombrePedido);

            //assert
            Assert.IsTrue(cantidadPedidosEsperada == cantidadPedidos);
        }

        [TestMethod]
        public void ActualizarEstadoDePedido()
        {
            //arrange
            Pedido.EEstado estadoActual;
            Pedido.EEstado estadoEsperado = Pedido.EEstado.Completado;
            Pedido p1 = new Pedido("Chica de jamon (test)", Pedido.EEstado.Preparacion, 200f, false);

            //act
            DataBaseHelper.InsertarPedido(p1);
            DataBaseHelper.ActualizarEstadoPedido(Pedido.EEstado.Completado, p1.HorarioPedido);
            estadoActual = DataBaseHelper.GetPedidoPorHorario(p1.HorarioPedido).Estado;

            DataBaseHelper.EliminarPedido(p1.NombrePedido);

            //assert
            Assert.AreEqual(estadoEsperado, estadoActual);
        }
    }
}
