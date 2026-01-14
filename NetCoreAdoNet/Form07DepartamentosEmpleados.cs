using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;

        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<string> depart = await this.repo.GetNombreDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string nombre in depart)
            {
                this.lstDepartamentos.Items.Add(nombre);
            }
        }

        private async Task LoadEmpleados()
        {
            string nombreDepart = this.lstDepartamentos.SelectedItem.ToString();
            List<string> emple = await this.repo.GetApellidosEmpleadosAsync(nombreDepart);
            this.lstEmpleados.Items.Clear();
            foreach (string apellido in emple)
            {
                this.lstEmpleados.Items.Add(apellido);
            }
        }

        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadEmpleados();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstEmpleados.SelectedIndex != -1)
            {
                string apellido = this.lstEmpleados.SelectedItem.ToString();
                int registros = await this.repo.DeleteEmpleados(apellido);
                this.LoadEmpleados();
            }
        }
    }
}
