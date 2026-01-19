using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            string connectionSql = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionSql);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                this.cmbDepartamentos.Items.Add(this.reader["DNOMBRE"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            //Tenemos un parametro de entrada, por defecto, todos son de entrada.
            //podemos segui usando addWithValue con dicho parametro
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            SqlParameter pamNombre = new SqlParameter();
            pamNombre.ParameterName = "@nombre";
            pamNombre.Value = nombre;
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
            this.lstEmpleados.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            //Cuando hay parametros de salida, se tiene que cerrar primero el lector antes de usar los parametros.
            await this.reader.CloseAsync();
            //Dibujamos los parametros
            this.txtSumaSalarial.Text = pamSuma.Value.ToString();
            this.txtMediaSalarial.Text = pamMedia.Value.ToString();
            this.txtPersonas.Text = pamPersonas.Value.ToString();
            //Liberamos los recursos
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
