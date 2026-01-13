using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NetCoreAdoNet
{
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            //Vamos a concatenar, por lo que el salario sera un string
            string salario = this.txtSalario.Text;
            //consulta sql
            string sql = "select * from EMP where SALARIO >= " + salario;
            //Configuramos el comando
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //Entrar y salir
            //Abrimos conexion
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //Dibujamos los datos
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + sal);
            }
            //Salimos. liberamos los recursos.
            this.reader.Close();
            this.cn.Close();
        }
    }
}
