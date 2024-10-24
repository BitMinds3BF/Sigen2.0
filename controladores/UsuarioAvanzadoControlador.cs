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
        }

        private void mostrarClientes() 
        {
            //var clientes = service.ObtenerTodoslosClientes();
            //ventana.dataGridMostrar.DataSource = clientes;
        }
        private void mostrarEjercicios() { }
        private void mostrarDeportes() { }
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


