using BITMINDS.services;
using BITMINDS.ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BITMINDS.controladores
{
    internal class UsuarioAvanzadoControlador
    {
        private ServiceUsuarioAvanzado service = new ServiceUsuarioAvanzado();
        public UsuarioAvanzado ventana { get; set; }
        private int filaSeleccionadaRowIndex;
        private BindingSource binding = new BindingSource();
        public void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                switch (radioButton.Name)
                {
                    case "radiobtnClientes":
                        mostrarClientes();
                        break;
                    case "radiobtnDeportes":
                        mostrarDeportes();
                        break;
                    case "radiobtnEjercicios":
                        mostrarEjercicios();
                        break;
                }

            }
        }

        public void btnAddClick(object sender, EventArgs e)
        {
            if (ventana.radiobtnClientes.Checked)
            {
                var formularioUsuario = new ventanas.FormularioUsuario();

                formularioUsuario.ShowDialog();
                mostrarClientes();
            }
            else if (ventana.radiobtnEjercicios.Checked)
            {
                var formularioEjercicio = new ventanas.FormularioEjercicio();

                formularioEjercicio.ShowDialog();
                mostrarEjercicios();
            }
            else if (ventana.radiobtnDeportes.Checked)
            {
                var formularioDeporte = new ventanas.FormularioDeporte();

                formularioDeporte.ShowDialog();
                mostrarDeportes();
            }
        }

        public void DgvItems_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                filaSeleccionadaRowIndex = e.Row.Index;
            }
          
        }
        public void btnModiClick(object sender, EventArgs e)
        {
            if (binding.List.Count == 0)
            {
                return;
            }

            if (ventana.radiobtnClientes.Checked)
            {
                var formularioUsuario = new ventanas.FormularioUsuario();
                var cliente = (modelos.Cliente)binding.List[filaSeleccionadaRowIndex];
                formularioUsuario.Documento = cliente.NumDoc;
                formularioUsuario.TipoDocumento = cliente.TipoDoc;
                formularioUsuario.ShowDialog();
                mostrarClientes();
            }
            else if (ventana.radiobtnEjercicios.Checked)
            {
                var formularioEjercicio = new ventanas.FormularioEjercicio();
                var ejercicio = (modelos.Ejercicio)binding.List[filaSeleccionadaRowIndex];
                formularioEjercicio.Id = ejercicio.Id;
                formularioEjercicio.ShowDialog();
                mostrarEjercicios();
            }
            else if (ventana.radiobtnDeportes.Checked)
            {
                var formularioDeporte = new ventanas.FormularioDeporte();
                var deporte = (modelos.Deporte)binding.List[filaSeleccionadaRowIndex];
                formularioDeporte.Id = deporte.Id; 
                formularioDeporte.ShowDialog();
                mostrarDeportes();
            }
        }

        public void Ventana_Load(object sender, EventArgs e)
        {
            ventana.dataGridMostrar.DataSource = binding;
        }
        private void mostrarClientes() 
        {
            var clientes = service.Clientes();
            binding.DataSource = clientes;
            binding.ResetBindings(false);
        }
        private void mostrarEjercicios() 
        {
            var ejercicios = service.Ejercicios();
            binding.DataSource = ejercicios;
            binding.ResetBindings(false);
        }
        private void mostrarDeportes() 
        {
           var deportes = service.Deportes();
            binding.DataSource = deportes;
            binding.ResetBindings(false);
        }

        public void btnEliminar(object sender, EventArgs e)
        {
            if (binding.List.Count == 0)
            {
                return;
            }

            if (ventana.radiobtnClientes.Checked)
            {
                var cliente = (modelos.Cliente)binding.List[filaSeleccionadaRowIndex];
                service.EliminarCliente(cliente.NumDoc, cliente.TipoDoc);
                mostrarClientes();
            }
            else if (ventana.radiobtnEjercicios.Checked)
            {
                var ejercicio = (modelos.Ejercicio)binding.List[filaSeleccionadaRowIndex];
                service.EliminarEjercicio(ejercicio.Id);
                mostrarEjercicios();
            }
            else if (ventana.radiobtnDeportes.Checked) 
            {
                var deporte = (modelos.Deporte)binding.List[filaSeleccionadaRowIndex];
                service.EliminarDeporte(deporte.Id);
                mostrarDeportes();
            }
        }

        public void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            ventana.Close();
        }

        public static UsuarioAvanzadoControlador Instance
        {
            get
            {
                if (instance == null) instance = new UsuarioAvanzadoControlador();

                return instance;
            }
        }
        
            private static UsuarioAvanzadoControlador instance;
        }
    }


