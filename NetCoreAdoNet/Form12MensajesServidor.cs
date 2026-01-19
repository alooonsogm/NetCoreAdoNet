using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure SP_ALL_DEPARTAMENTOS
//as 
//	select * from DEPT
//go

//create procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
//as
//	insert into DEPT values(@numero, @nombre, @localidad)
//go

//alter procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
//as
//	if (UPPER(@localidad) = 'TERUEL')
//	begin
//		print 'TERUEL NO EXISTE'
//	end
//	else
//	begin
//		insert into DEPT values(@numero, @nombre, @localidad)
//	end
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionSql = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionSql);
            //Agregamos el evento para capturar mensajes.
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepart();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblServidor.Text = e.Message;
        }

        private async Task LoadDepart()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                this.lstDepartamentos.Items.Add(this.reader["DEPT_NO"].ToString() + " - " + this.reader["DNOMBRE"].ToString() + " - " + this.reader["LOC"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnNuevoDepart_Click(object sender, EventArgs e)
        {
            this.lblServidor.Text = "";
            string sql = "SP_INSERT_DEPARTAMENTO";
            int numero = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;
            this.com.Parameters.AddWithValue("@numero", numero);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", loc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            //int registros = await this.com.ExecuteNonQueryAsync();
            int registros = this.com.ExecuteNonQuery();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            await this.LoadDepart();
            MessageBox.Show("Registros insertados: " + registros);
        }
    }
}
