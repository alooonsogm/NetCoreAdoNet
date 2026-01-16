
using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepartamento
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamento()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Departamento>> GetDepartamentoAsync()
        {
            string sql = "select * from DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Departamento> departamentos = new List<Departamento>();
            while (await this.reader.ReadAsync())
            {
                Departamento dept = new Departamento();
                dept.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                dept.Nombre = this.reader["DNOMBRE"].ToString();
                dept.Localidad = this.reader["LOC"].ToString();
                departamentos.Add(dept);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task CreateDepartamentoAsync(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values(@id, @nombre, @localidad)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamLoc = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLoc);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateDepartamentoAsync(int id, string nombre, string localidad)
        {
            string sql = "update DEPT set DNOMBRE=@nombre, LOC=@localidad WHERE DEPT_NO=@id";
            //Tenemos un metodo en el command que nos permite añadir parametros, sin crear objetos, siempre que sean de tipo primitivo.
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteDepartamentoAsync(int id)
        {
            string sql = "delete from DEPT where DEPT_NO=@id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
