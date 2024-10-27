using BITMINDS.modelos;
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
        public ventanas.Cliente Ventana { get; set; }
        private modelos.Cliente cliente;
        private int ejercicioSelecionadoRowIndex;
        private BindingSource binding = new BindingSource();

        public void Ventana_Load(object sender, EventArgs e)
        {
            service = new ClienteService(Ventana.Documento, Ventana.TipoDocumento);
            cliente = service.MisDatos();
            Ventana.dgvItems.DataSource = binding;
            Ventana.lblNombreCompleto.Text = $"{cliente.Nombre} {cliente.Apellido}";
        }

        public void DgvItems_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Console.WriteLine(e.StateChanged);
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                ejercicioSelecionadoRowIndex = e.Row.Index;
                string realizado = e.Row.Cells["realizado"].Value as string;

                if (realizado == null)
                {
                    Ventana.btnMarcarCompletado.Text = "Marcar como completado";
                    Ventana.btnMarcarCompletado.Enabled = true;
                } else
                {
                    Ventana.btnMarcarCompletado.Text = "Ejercicio completado";
                    Ventana.btnMarcarCompletado.Enabled = false;
                }
            }
        }

        public void BtnMostrarEjercicios_Click(object sender, EventArgs e)
        {
            binding.DataSource = service.MisEjercicios();
            binding.ResetBindings(false);

            Ventana.lblTitle.Text = $"Planes de entrenamiento";
            Ventana.btnMarcarCompletado.Visible = true;
        }

        public void BtnMostrarDesempeños_Click(object sender, EventArgs e)
        {
            Ventana.lblTitle.Text = "Mis desempeños";
            Ventana.btnMarcarCompletado.Visible = false;
        }

        public void BtnMarcarCompletado_Click(object sender, EventArgs e)
        {
            EjercicioAsignado ejercicio = service.MarcarEjercicioCompletado(
                (EjercicioAsignado)binding.List[ejercicioSelecionadoRowIndex]
            );
            binding.List[ejercicioSelecionadoRowIndex] = ejercicio;
            binding.ResetItem(ejercicioSelecionadoRowIndex); //Usamos ResetItem para que se invalide el actual y se actualice

            Ventana.btnMarcarCompletado.Enabled = false;
            Ventana.btnMarcarCompletado.Text = "Ejercicio completado";
        }

        public void BtnCerrarSesion_Click(object sender, EventArgs e)
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
