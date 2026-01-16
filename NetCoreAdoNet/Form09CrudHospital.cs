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
    public partial class Form09CrudHospital : Form
    {
        RepositoryHospitales repo;

        public Form09CrudHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.loadHospitales();
        }

        private async Task loadHospitales()
        {
            List<Hospital> hospitales = await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hosp in hospitales)
            {
                this.lstHospitales.Items.Add(hosp.IdHospital + " - " + hosp.Nombre + " - " + hosp.Direccion + " - " + hosp.Telefono + " - " + hosp.NumeroCamas);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int numCamas = int.Parse(this.txtCamas.Text);

            await this.repo.CreateHospitalAsync(id, nombre, direccion, telefono, numCamas);
            await this.loadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int numCamas = int.Parse(this.txtCamas.Text);

            await this.repo.UpdateHospital(id, nombre, direccion, telefono, numCamas);
            await this.loadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteHospital(id);
            await this.loadHospitales();
        }
    }
}
