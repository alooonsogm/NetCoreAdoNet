using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNombreDepartamentosAsync()
        {
            string sql = "select DNOMBRE FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<List<string>> GetApellidosEmpleadosAsync(string nombreDepart)
        {
            string sql = "select EMP.APELLIDO FROM EMP INNER JOIN DEPT ON EMP.DEPT_NO = DEPT.DEPT_NO WHERE DEPT.DNOMBRE= @nombreDepart";
            SqlParameter pamNombreDepart = new SqlParameter("@nombreDepart", nombreDepart);
            this.com.Parameters.Add(pamNombreDepart);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task<int> DeleteEmpleados(string apellido)
        {
            string sql = "DELETE FROM EMP WHERE APELLIDO=@apellido";
            SqlParameter pamApellido = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamApellido);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }
    }
}
