using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                Hospital hospital = new Hospital();
                hospital.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                hospital.Telefono = this.reader["TELEFONO"].ToString();
                hospital.NumeroCamas = int.Parse(this.reader["NUM_CAMA"].ToString());
                hospitales.Add(hospital);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task CreateHospitalAsync(int id, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "insert into HOSPITAL values(@id, @nombre, @direccion, @telefono, @numCamas)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            SqlParameter pamNumCamas = new SqlParameter("@numCamas", numCamas);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamDireccion);
            this.com.Parameters.Add(pamTelefono);
            this.com.Parameters.Add(pamNumCamas);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateHospital(int id, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "update HOSPITAL set NOMBRE=@nombre, DIRECCION=@direccion, TELEFONO=@telefono, NUM_CAMA=@numCamas where HOSPITAL_COD=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            SqlParameter pamNumCamas = new SqlParameter("@numCamas", numCamas);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamDireccion);
            this.com.Parameters.Add(pamTelefono);
            this.com.Parameters.Add(pamNumCamas);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteHospital(int id)
        {
            string sql = "delete from HOSPITAL where HOSPITAL_COD=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
