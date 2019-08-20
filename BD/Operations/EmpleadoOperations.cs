using BD.Door;
using BD.Models;
using Contracts.BD.Door;
using Contracts.BD.Models;
using Contracts.BD.Operations;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BD.Operations
{
    internal class EmpleadoOperations : IEmpledoOperations
    {
        public EmpleadoOperations()
        {
        }
        public async Task<List<IEmpleado>> GetAll(IAccess cs)
        {
            List<IEmpleado> lista = new List<IEmpleado>();
            Proxy proxy = new Proxy(cs);
            using (NpgsqlConnection conn = new NpgsqlConnection(proxy.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select * from st_empleados()", conn))
                    {
                        //cmd.CommandType = CommandType.StoredProcedure;

                        using (NpgsqlDataReader pgreader = cmd.ExecuteReader())
                        {
                            while (pgreader.Read())
                            {//Crear el objeto 
                                Empleado emp = new Empleado();
                                emp.Id = int.Parse(pgreader["_id"].ToString());
                                emp.Nombre = pgreader["_nombre"].ToString();
                                emp.Apellido = pgreader["_apellido"].ToString();
                                emp.Email = pgreader["_email"].ToString();
                                lista.Add(emp);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                }
                conn.Close();
            }
            return lista;
        }
        public async Task<bool> Create(IEmpleado emp, IAccess cs)
        {
            Proxy proxy = new Proxy(cs);
            using (NpgsqlConnection conn = new NpgsqlConnection(proxy.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select * from st_insert(:_nombre,:_apellido,:_email)", conn))
                    {
                        cmd.Parameters.AddWithValue("_nombre", emp.Nombre);
                        cmd.Parameters.AddWithValue("_apellido", emp.Apellido);
                        cmd.Parameters.AddWithValue("_email", emp.Email);
                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return false;
                }
            }
        }
        public async Task<bool> Delete(int id, IAccess cs)
        {
            Proxy proxy = new Proxy(cs);
            using (NpgsqlConnection conn = new NpgsqlConnection(proxy.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select * from st_delete(:clave)", conn))
                    {
                        cmd.Parameters.AddWithValue("clave", id);
                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return false;
                }
            }
        }
        public async Task<bool> Update(IEmpleado emp, IAccess cs)
        {
            Proxy proxy = new Proxy(cs);
            using (NpgsqlConnection conn = new NpgsqlConnection(proxy.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select * from st_update(:_nombre,:_apellido,:clave)", conn))
                    {
                        cmd.Parameters.AddWithValue("_nombre", emp.Nombre);
                        cmd.Parameters.AddWithValue("_apellido", emp.Apellido);
                        cmd.Parameters.AddWithValue("clave", emp.Id);
                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return false;
                }
            }
        }
        public async Task<IEmpleado> GetEmpleado(int id, IAccess cs)
        {
            Proxy proxy = new Proxy(cs);
            Empleado emp = new Empleado();
            using (NpgsqlConnection conn = new NpgsqlConnection(proxy.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand($"select * from st_empleadoid(:clave)", conn))
                    {

                        cmd.Parameters.AddWithValue("clave", id);
                        using (NpgsqlDataReader pgreader = cmd.ExecuteReader())
                        {
                            while (pgreader.Read())
                            {//Crear el objeto 
                                emp.Id = int.Parse(pgreader["_id"].ToString());
                                emp.Nombre = pgreader["_nombre"].ToString();
                                emp.Apellido = pgreader["_apellido"].ToString();
                                emp.Email = pgreader["_email"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                }
                conn.Close();
            }

            return emp;
        }
    }
}
