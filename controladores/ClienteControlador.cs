using BITMINDS.services;
using BITMINDS.ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITMINDS.controladores
{
    public class ClienteControlador
    {
        public Cliente Ventana { get; set; }
        private modelos.Cliente cliente;

        public void Ventana_Load(object sender, EventArgs e)
        {
            service = new ClienteService(Ventana.Documento, Ventana.TipoDocumento);
            cliente = service.MisDatos();
        }

        public void Ventana_MostrarEjercicios(object sender, EventArgs e)
        {
            Ventana.lblTitle.Text = $"Planes de entrenamiento: {cliente.Nombre} {cliente.Apellido}";
            Ventana.dgvItems.DataSource = service.MisEjercicios();
        }

        public void Ventana_MostrarDesempeños(object sender, EventArgs e)
        {
            Ventana.lblTitle.Text = "Mi desempeño";
        }

        public void Ventana_CerrarSesion(object sender, EventArgs e)
        {
            Ventana.Close();
        }

        public static ClienteControlador Instance {
            get
            {
                if (instance == null) instance = new ClienteControlador();

                return instance;
            }
        }

        private ClienteService service;

        private static ClienteControlador instance;
    }
}
