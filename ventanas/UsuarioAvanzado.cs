using BITMINDS.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITMINDS.ventanas
{
    public partial class UsuarioAvanzado : Form
    {
        public UsuarioAvanzado()
        {
            InitializeComponent();
            controlador = UsuarioAvanzadoControlador.Instance;
            controlador.ventana = this;

            btnAdd.Click += controlador.btnAddClick;
            btnModi.Click += controlador.btnModiClick;
            btnEliminar.Click += controlador.btnEliminar;
            btnCerSes.Click += controlador.BtnCerrarSesion_Click;

            radiobtnClientes.CheckedChanged += controlador.RadioButton_CheckedChanged;
            radiobtnEjercicios.CheckedChanged += controlador.RadioButton_CheckedChanged;
            radiobtnDeportes.CheckedChanged += controlador.RadioButton_CheckedChanged;

            
            dataGridMostrar.RowStateChanged += controlador.DgvItems_RowStateChanged;

            Load += controlador.Ventana_Load;
        }

        private UsuarioAvanzadoControlador controlador;
    }
}
