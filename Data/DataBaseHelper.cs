using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Extensiones;
using Entidades;
using Excepciones;

namespace Data
{
    public static class DataBaseHelper
    {
        //Data
        private static Queue<Pedido> pedidosActuales; //Acá van a ir los pedidos que estén en preparación o en camino (delivery)
        private static List<Pedido> pedidosCompletados; //Acá van a ir los pedidos que ya estén en estado completado

        //SQL Requirements
        private static SqlCommand command;
        private static SqlConnection sqlConnection;
        private const string connectionStr = @"Data Source=.\sqlexpress; Initial Catalog=Restaurante; Trusted_Connection=True;";

        static DataBaseHelper()
        {
            sqlConnection = new SqlConnection(connectionStr);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = sqlConnection;

            pedidosActuales = new Queue<Pedido>();
            pedidosCompletados = new List<Pedido>();
        }

        public static Queue<Pedido> PedidosActuales
        {
            get { return pedidosActuales; }
            set { pedidosActuales = value; }
        }

        public static List<Pedido> PedidosCompletados
        {
            get { return pedidosCompletados; }
            set { pedidosCompletados = value; }
        }

        public static bool InsertarPedido<T>(T pedido) where T : Pedido
        {
            bool response = true;

            try
            {
                command.Parameters.Clear();
                command.CommandText = GetInsertQuery(pedido);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                response = false;
            }
            finally
            {
                if (!(sqlConnection is null) && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return response;
        }

        private static string GetInsertQuery<T>(T pedido) where T : Pedido
        {
            string query = string.Empty;

            if (pedido.GetType() == typeof(Pedido))
            {
                query = "INSERT INTO Pedidos (NombrePedido, Estado, Precio, HorarioPedido, Delivery) values " +
                    "(@nombrePedido, @estadoPedido, @precio, @horarioPedido, @tieneDelivery)";
            }
            else
            {
                query = "INSERT INTO Pedidos values " +
                    "(@nombrePedido, @estadoPedido, @precio, @horarioPedido, @tieneDelivery, @nombreCliente, @localidad, @direccion, @numeroDireccion)";
            }

            command.CommandText = query;
            command.Parameters.AddWithValue("nombrePedido", pedido.NombrePedido);
            command.Parameters.AddWithValue("estadoPedido", pedido.Estado.ToString());
            command.Parameters.AddWithValue("precio", pedido.Precio);
            command.Parameters.AddWithValue("horarioPedido", pedido.HorarioPedido);
            command.Parameters.AddWithValue("tieneDelivery", pedido.TieneDelivery);

            if (pedido is PedidoDelivery)
            {
                PedidoDelivery pedidoDelivery = pedido as PedidoDelivery;

                command.Parameters.AddWithValue("nombreCliente", pedidoDelivery.NombreCliente);
                command.Parameters.AddWithValue("localidad", pedidoDelivery.Localidad);
                command.Parameters.AddWithValue("direccion", pedidoDelivery.Direccion);
                command.Parameters.AddWithValue("numeroDireccion", pedidoDelivery.NumeroDireccion);
            }

            return query;
        }

        public static List<Pedido> GetPedidosPorEstado(Pedido.EEstado estadoPedido)
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            try
            {
                string query = "SELECT * FROM Pedidos WHERE Estado = @estado";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("estado", estadoPedido.ToString());

                sqlConnection.Open();

                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Pedido p = null;

                    int id = (int) reader["Id"];
                    string nombrePedido = (string) reader["NombrePedido"];
                    Pedido.EEstado estado = (Pedido.EEstado) Enum.Parse(typeof(Pedido.EEstado), (string) reader["Estado"]);
                    float precio = (float) (double) reader["Precio"];
                    string horarioPedido = (string) reader["HorarioPedido"];
                    bool tieneDelivery = reader.GetBoolean(reader.GetOrdinal("Delivery"));

                    if(tieneDelivery)
                    {
                        //agrego los campos extra que tiene un pedido con delivery
                        string nombreCliente = (string) reader["NombreCliente"];
                        string localidad = (string) reader["Localidad"];
                        string direccion = (string) reader["Direccion"];
                        int numeroDireccion = (int) reader["NumeroDireccion"];

                        p = new PedidoDelivery(
                            id, 
                            nombrePedido, 
                            estado,
                            precio,
                            tieneDelivery,
                            horarioPedido,
                            nombreCliente, 
                            localidad, 
                            direccion,
                            numeroDireccion
                        );
                    }
                    else
                    {
                        p = new Pedido(id, nombrePedido, estado, precio, horarioPedido, tieneDelivery);
                    }

                    listaPedidos.Add(p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (!(sqlConnection is null) && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return listaPedidos;
        }

        public static Pedido GetPedidoPorHorario(string horario)
        {
            Pedido p = null;

            try
            {
                string query = "SELECT * FROM Pedidos WHERE HorarioPedido = @horarioPedido";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("horarioPedido", horario);

                sqlConnection.Open();

                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string nombrePedido = (string)reader["NombrePedido"];
                    Pedido.EEstado estado = (Pedido.EEstado)Enum.Parse(typeof(Pedido.EEstado), (string)reader["Estado"]);
                    float precio = (float)(double)reader["Precio"];
                    string horarioPedido = (string)reader["HorarioPedido"];
                    bool tieneDelivery = reader.GetBoolean(reader.GetOrdinal("Delivery"));

                    if (tieneDelivery)
                    {
                        //agrego los campos extra que tiene un pedido con delivery
                        string nombreCliente = (string)reader["NombreCliente"];
                        string localidad = (string)reader["Localidad"];
                        string direccion = (string)reader["Direccion"];
                        int numeroDireccion = (int)reader["NumeroDireccion"];

                        p = new PedidoDelivery(
                            id,
                            nombrePedido,
                            estado,
                            precio,
                            tieneDelivery,
                            horarioPedido,
                            nombreCliente,
                            localidad,
                            direccion,
                            numeroDireccion
                        );
                    }
                    else
                    {
                        p = new Pedido(id, nombrePedido, estado, precio, horarioPedido, tieneDelivery);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (!(sqlConnection is null) && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return p;
        }

        public static bool ActualizarEstadoPedido(Pedido.EEstado nuevoEstado, string horarioPedido)
        {
            bool response = true;

            try
            {
                string query = "UPDATE Pedidos SET Estado = @nuevoEstado WHERE HorarioPedido = @horarioPedido";

                command.Parameters.Clear();
                command.CommandText = query;

                command.Parameters.AddWithValue("nuevoEstado", nuevoEstado.ToString());
                command.Parameters.AddWithValue("horarioPedido", horarioPedido);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                response = false;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (!(sqlConnection is null) && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return response;
        }


        //Actualmente usado solo para los tests unitarios
        public static bool EliminarPedido(string nombrePedido)
        {
            bool response = true;
            string query = "DELETE FROM Pedidos WHERE NombrePedido = @nombre";

            try
            {
                command.Parameters.Clear();
                command.CommandText = query;
                command.Parameters.AddWithValue("nombre", nombrePedido);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                response = false;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (!(sqlConnection is null) && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return response;
        }
    }
}
