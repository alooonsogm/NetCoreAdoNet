using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficiosList = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficiosList.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficiosList;
        }

        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            string sql = "select APELLIDO from EMP where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string ape = this.reader["APELLIDO"].ToString();
                apellidos.Add(ape);
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();
            return apellidos;
        }

        public async Task<int> UpdateSalarioEmpleadosAsync(string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO=SALARIO + @incremento where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<DatoSalario> GetDatosSalarioByOficioAsync(string oficio)
        {
            string sql = "select sum(SALARIO) as Suma, AVG(SALARIO) as Media, MAX(SALARIO) as Maximo from EMP where OFICIO =@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatoSalario dato = new DatoSalario();
            await this.reader.ReadAsync();
            dato.SumaSalarios = int.Parse(this.reader["Suma"].ToString());
            dato.MediaSalarios = int.Parse(this.reader["Media"].ToString());
            dato.MaxSalario = int.Parse(this.reader["Maximo"].ToString());
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();
            return dato;
        }
    }
}
