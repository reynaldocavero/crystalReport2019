using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDCliente
    {
        Conexion objConexion = new Conexion();
        List<CECliente> listCliente = null;
        CECliente oCliente = null;

        public IEnumerable<CECliente> listarCliente(string xml)
        {
            try
            {

                MySqlConnection cn = objConexion.conectar();
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("spCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@xml", xml);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<CECliente>();
                        while (dr.Read())
                        {
                            oCliente = new CECliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "noData" : dr.GetString(dr.GetOrdinal("nombre")),
                                tipoDocumento = dr.IsDBNull(dr.GetOrdinal("tipoDocumento")) ? "noData" : dr.GetString(dr.GetOrdinal("tipoDocumento")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numDoc = dr.IsDBNull(dr.GetOrdinal("numDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public IEnumerable<CECliente> agregarCliente(string nombre, string tipo, string numero)
        {
            try
            {

                MySqlConnection cn = objConexion.conectar();
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("spClienteAgregar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("nombre", nombre);
                    cmd.Parameters.AddWithValue("tipo", tipo);
                    cmd.Parameters.AddWithValue("numero", numero);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<CECliente>();
                        while (dr.Read())
                        {
                            oCliente = new CECliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "noData" : dr.GetString(dr.GetOrdinal("nombre")),
                                tipoDocumento = dr.IsDBNull(dr.GetOrdinal("tipoDocumento")) ? "noData" : dr.GetString(dr.GetOrdinal("tipoDocumento")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numDoc = dr.IsDBNull(dr.GetOrdinal("numDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public IEnumerable<CECliente> buscarCliente(string numero)
        {
            try
            {

                MySqlConnection cn = objConexion.conectar();
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("spClienteBuscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("numero", numero);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<CECliente>();
                        while (dr.Read())
                        {
                            oCliente = new CECliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "noData" : dr.GetString(dr.GetOrdinal("nombre")),
                                tipoDocumento = dr.IsDBNull(dr.GetOrdinal("tipoDocumento")) ? "noData" : dr.GetString(dr.GetOrdinal("tipoDocumento")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numDoc = dr.IsDBNull(dr.GetOrdinal("numDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<CECliente> eliminarCliente(string numero)
        {
            try
            {

                MySqlConnection cn = objConexion.conectar();
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("spClienteEliminar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("numero", numero);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<CECliente>();
                        while (dr.Read())
                        {
                            oCliente = new CECliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "noData" : dr.GetString(dr.GetOrdinal("nombre")),
                                tipoDocumento = dr.IsDBNull(dr.GetOrdinal("tipoDocumento")) ? "noData" : dr.GetString(dr.GetOrdinal("tipoDocumento")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numDoc = dr.IsDBNull(dr.GetOrdinal("numDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<CECliente> actualizaCliente(string nombre, string tipo, string numero)
        {
            try
            {

                MySqlConnection cn = objConexion.conectar();
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("spClienteActualizar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("nombre", nombre);
                    cmd.Parameters.AddWithValue("tipo", tipo);
                    cmd.Parameters.AddWithValue("numero", numero);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<CECliente>();
                        while (dr.Read())
                        {
                            oCliente = new CECliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "noData" : dr.GetString(dr.GetOrdinal("nombre")),
                                tipoDocumento = dr.IsDBNull(dr.GetOrdinal("tipoDocumento")) ? "noData" : dr.GetString(dr.GetOrdinal("tipoDocumento")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numDoc = dr.IsDBNull(dr.GetOrdinal("numDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
