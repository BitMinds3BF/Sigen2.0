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
    internal class UsuarioAvanzadoControlador
    {
        private ServiceUsuarioAvanzado service = new ServiceUsuarioAvanzado();
        public UsuarioAvanzado ventana {  get; set; }

        public void RadioButton_CheckedChanged (object sender, EventArgs e)
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
            }
            else if (ventana.radiobtnEjercicios.Checked) 
            {
                var formularioEjercicio = new ventanas.FormularioEjercicio();

                formularioEjercicio.ShowDialog();
            }
            else if (ventana.radiobtnDeportes.Checked) 
            {
                var formularioDeporte = new ventanas.FormularioDeporte();
                
                formularioDeporte.ShowDialog();
            }
        }

        private void mostrarClientes() 
        {
            var clientes = service.Clientes();
            ventana.dataGridMostrar.DataSource = clientes;
        }
        private void mostrarEjercicios() 
        {
            var ejercicios = service.Ejercicios();
            ventana.dataGridMostrar.DataSource = ejercicios;
        }
        private void mostrarDeportes() 
        {
           var deportes = service.Deportes();
           ventana.dataGridMostrar.DataSource= deportes;
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


