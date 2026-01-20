using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

#region STORED PROCEDURE
//create procedure SP_ALL_DEPARTAMENTOS
//as 
//	select * from DEPT
//go

//create procedure SP_EMPLEADOS_DEPARTAMENTOS_OUT
//(@nombre nvarchar(50), @suma int OUT, @media int OUT, @personas int OUT)
//as
//	declare @iddept int
//	select @iddept = DEPT_NO FROM DEPT where DNOMBRE=@nombre
//	--LA CONSULTA DEL PROCEDIMIENTO
//	select * from EMP where DEPT_NO=@iddept
//	--Rellenamos las variables de salida
//	select @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO) FROM EMP where DEPT_NO=@iddept
//go
#endregion

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryParametersOut
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryParametersOut()
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionSql = configuration.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionSql);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<EmpleadoParametersOut> GetEmpleadosModelAsync(string nombreDepart)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            //Tenemos un parametro de entrada, por defecto, todos son de entrada.
            //podemos segui usando addWithValue con dicho parametro
            SqlParameter pamNombre = new SqlParameter();
            pamNombre.ParameterName = "@nombre";
            pamNombre.Value = nombreDepart;
            this.com.Parameters.Add(pamNombre);
            //Los parametros de salida debemos crearlo de forma explicita.
            //En este ejemplo no hemos puesto valores por defecto a los parametros, por lo que son obligatorios.
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);

            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);

            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            EmpleadoParametersOut model = new EmpleadoParametersOut();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                model.apellidos.Add(apellido);
            }
            //Cuando hay parametros de salida, se tiene que cerrar primero el lector antes de usar los parametros.
            await this.reader.CloseAsync();
            //Establecemos los datos
            model.sumaSalarial = int.Parse(pamSuma.Value.ToString());
            model.mediaSalarial = int.Parse(pamMedia.Value.ToString());
            model.personas = int.Parse(pamPersonas.Value.ToString());
            //Liberamos los recursos
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return model;
        }
    }
}
