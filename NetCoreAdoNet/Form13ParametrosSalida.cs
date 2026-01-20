using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametersOut repo;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            string connectionSql = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.repo = new RepositoryParametersOut();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            foreach (string depart in departamentos)
            {
                this.cmbDepartamentos.Items.Add(depart);
            }
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombreDepart = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadoParametersOut model = await this.repo.GetEmpleadosModelAsync(nombreDepart);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in model.apellidos)
            {
                this.lstEmpleados.Items.Add(ape);
            }
            this.txtSumaSalarial.Text = model.sumaSalarial.ToString();
            this.txtMediaSalarial.Text = model.mediaSalarial.ToString();
            this.txtPersonas.Text = model.personas.ToString();
        }
    }
}
