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
    public partial class Form10UpdateEmpleadosOficios : Form
    {
        RepositoryUpdateEmpleados repo;

        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }

        private async Task LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string ofi in oficios)
            {
                this.lstOficios.Items.Add(ofi);
            }
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstOficios.SelectedIndex;
            if (index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();

                List<string> apellidos = await this.repo.GetEmpleadosByOficioAsync(oficio);
                this.lstEmpleados.Items.Clear();
                foreach (string ape in apellidos)
                {
                    this.lstEmpleados.Items.Add(ape);
                }

                DatoSalario datos = await this.repo.GetDatosSalarioByOficioAsync(oficio);
                this.lblSumaSalarial.Text = "La suma salarial de " + oficio + " es " + datos.SumaSalarios;
                this.lblMediaSalarial.Text = "La media salarial de " + oficio + " es " + datos.MediaSalarios;
                this.lblMaximoSalario.Text = "El maximo salario de " + oficio + " es " + datos.MaxSalario;
            }
        }

        private async void btnSubirSalario_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncrementoSalarial.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int registros = await this.repo.UpdateSalarioEmpleadosAsync(oficio, incremento);
            MessageBox.Show("Registros afectados: " + registros);
        }
    }
}
