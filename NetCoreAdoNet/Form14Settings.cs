using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form14Settings : Form
    {
        public Form14Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Necesitamos un constructor de configuraciones
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //En este entorno de proyecto settings no es nativo, es decir, a pesar de llamarlo appsettings.json, no lo reconoce
            //Debemos indicar la ubicacion del fichero y el nombre
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);
            //Necesitamos el objeto para recuperar las keys
            IConfigurationRoot configuration = builder.Build();
            //Existen keys ya configuradas y podemos recuperarlas con metodos nativos.
            //Las keys diferencian mayusculas de minusculas.
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.lblConexion.Text = connectionString;
            //Si no son keys conocidas, debemos navegar hasta ellas.
            //La navegacion entre keys se establecen mediante : KeyPricnipal:SubKey
            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen2").Value;
            string colorLetras = configuration.GetSection("Colores:letras").Value;
            string colorFondo = configuration.GetSection("Colores:fondo").Value;

            this.pictureBox2.Load(imagen1);
            this.pictureBox3.Load(imagen2);
            this.BackColor = Color.FromName(colorFondo);
            this.btnLeerSettings.ForeColor = Color.FromName(colorLetras);
        }

        private void btnLeerHelper_Click(object sender, EventArgs e)
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.lblConexion.Text = connectionString;

            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen2").Value;
            string colorLetras = configuration.GetSection("Colores:letras").Value;
            string colorFondo = configuration.GetSection("Colores:fondo").Value;

            this.pictureBox2.Load(imagen1);
            this.pictureBox3.Load(imagen2);
            this.BackColor = Color.FromName(colorFondo);
            this.btnLeerSettings.ForeColor = Color.FromName(colorLetras);
        }
    }
}
