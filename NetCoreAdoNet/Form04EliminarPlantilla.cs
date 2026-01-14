using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.loadEmpleados();
        }

        private void loadEmpleados()
        {
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select * from PLANTILLA";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                this.lstEmpleados.Items.Add(this.reader["EMPLEADO_NO"].ToString() + " - " + this.reader["APELLIDO"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "delete from PLANTILLA where EMPLEADO_NO =" + this.txtEmpleado.Text;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.loadEmpleados();
            MessageBox.Show("Empleados eliminados: " + registros);
        }
    }
}
